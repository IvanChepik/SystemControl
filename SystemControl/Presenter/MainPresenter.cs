using System;
using System.Collections.Generic;
using Commands;
using Commands.Commands;
using Models;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;
using Ninject;
using Presenter.MainPresenters;
using View.IViews;

namespace Presenter
{
    public class MainPresenter
    {
        private readonly IKernel _kernel;
        private readonly IMainView _view;
        private readonly ExecutorCommands _executorCommands;

        public MainPresenter(IKernel kernel, IMainView view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            InitTables();

            _view.AddingChildOrders += AddingChildOrders;
            _view.AddingChildCards += AddingChildCards;
            _view.AddingPersonnelOrders += AddingPersonnelOrder;
            _view.AddingPersonnelVacation += AddingPersonnelVacation;
            _view.AddingMainCleaning += AddingMainCleaning;
            _view.AddingMainCompetition += AddingMainCompetition;
            _view.AddingMainEquipment += AddingMainEquipment;
            _view.AddingMainItem += AddingMainItem;
            _view.AddingMainOrder += AddingMainOrder;
            _view.AddingMainRequest += AddingMainRequest;
            _view.AddingChildAttendence += AddingChildAttendence;
            _view.AddingPersonnelWorkTime += AddingWorkTime;

            _view.DeletingChildCards += () => DeletingChildCards(_view.IdSelectedChildCard);
            _view.DeletingChildOrders += () => DeletingChildOrders(_view.IdSelectedChildOrder);
            _view.DeletingPersonnelOrders += () => DeletingPersonnelOrder(_view.IdSelectedPersonnelOrder);
            _view.DeletingPersonnelVacation += () => DeletingPersonnelVacation(_view.IdSelectedPersonnelVacation);
            _view.DeletingMainCleaning += () => DeletingMainCleaning(_view.IdSelectedMainCleaning);
            _view.DeletingMainCompetition += () => DeletingMainCompetition(_view.IdSelectedMainComp);
            _view.DeletingMainEquipment += () => DeletingMainEquipment(_view.IdSelectedMainEquip);
            _view.DeletingMainItem += () => DeletingMainItem(_view.IdSelectedMainItem);
            _view.DeletingMainOrder += () => DeletingMainOrder(_view.IdSelectedMainOrder);
            _view.DeletingMainRequest += () => DeletingMainRequest(_view.IdSelectedMainRequest);
            _view.OpeningFileWord += OpenFileWord;
        }

        private void InitTables()
        {
            InitChildOrders();
            InitChildCards();
            InitPersonnelOrders();
            InitPersonnelVacations();
            InitMainOrders();
            InitMainRequests();
            InitMainCleaning();
            InitMainComp();
            InitMainEquipment();
            InitMainItems();
        }

        private void OpenFileWord()
        {
            _view.OpenWordFile();
        }

        private void InitMainOrders()
        {
            _executorCommands.InitMainOrdersEvent = InitMainOrdersHandler;
            var command = new InitTableCommand<MainOrders>(_executorCommands, ModelsType.MainOrders);
            command.Execute();
        }

        private void InitMainRequests()
        {
            _executorCommands.InitMainRequestEvent = InitMainRequestsHandler;
            var command = new InitTableCommand<MainRequest>(_executorCommands, ModelsType.MainRequest);
            command.Execute();
        }

        private void InitMainComp()
        {
            _executorCommands.InitMainCompEvent = InitMainCompHandler;
            var command = new InitTableCommand<MainCompetition>(_executorCommands, ModelsType.MainCompetition);
            command.Execute();
        }

        private void InitMainCleaning()
        {
            _executorCommands.InitMainCleaningEvent = InitMainCleaningHandler;
            var command = new InitTableCommand<MainCleaning>(_executorCommands, ModelsType.MainCleanings);
            command.Execute();
        }

        private void InitMainItems()
        {
            _executorCommands.InitMainItemEvent = InitMainItemsHandler;
            var command = new InitTableCommand<MainItem>(_executorCommands, ModelsType.MainItem);
            command.Execute();
        }

        private void InitMainEquipment()
        {
            _executorCommands.InitMainEquipEvent = InitMainEquipmentHandler;
            var command = new InitTableCommand<MainEquipment>(_executorCommands, ModelsType.MainEquipment);
            command.Execute();
        }

        private void InitMainEquipmentHandler(List<MainEquipment> model)
        {
            _view.InitMainEquip(model);
        }

        private void InitMainItemsHandler(List<MainItem> modelList)
        {
            _view.InitMainItems(modelList);
        }

        private void InitMainCleaningHandler(List<MainCleaning> modelList)
        {
            _view.InitMainCleanings(modelList);
        }

        private void InitMainCompHandler(List<MainCompetition> modeList)
        {
            _view.InitMainComp(modeList);
        }

        private void InitMainRequestsHandler(List<MainRequest> modelList)
        {
            _view.InitMainRequest(modelList);
        }

        private void InitMainOrdersHandler(List<MainOrders> modeList)
        {
            _view.InitMainOrders(modeList);
        }

        private void InitPersonnelOrders()
        {
            _executorCommands.InitPersonnelOrdersEvent = InitPersonnelOrdersHandler;
            var command = new InitTableCommand<PersonnelOrder>(_executorCommands, ModelsType.PersonnelOrders);
            command.Execute();
        }

        private void InitPersonnelVacations()
        {
            _executorCommands.InitPersonnelVacationEvent = InitPersonnelVacationsHandler;
            var command = new InitTableCommand<PersonnelVacation>(_executorCommands, ModelsType.PersonnelVacation);
            command.Execute();
        }

        private void InitChildOrders()
        {
            _executorCommands.InitEvent = InitDataHandler;
            var command = new InitTableCommand<ChildOrder>(_executorCommands, ModelsType.ChildOrders);
            command.Execute();
        }

        private void InitChildCards()
        {
            _executorCommands.InitChildCardsEvent = InitChildCardsHandler;
            var command = new InitTableCommand<ChildCard>(_executorCommands, ModelsType.ChildCards);
            command.Execute();
        }

        private void InitPersonnelVacationsHandler(List<PersonnelVacation> modelsList)
        {
            _view.InitPersonnelVacations(modelsList);
        }

        private void InitChildCardsHandler(List<ChildCard> modelsList)
        {
            _view.InitChildCards(modelsList);
        }

        private void InitPersonnelOrdersHandler(List<PersonnelOrder> modelsList)
        {
            _view.InitPersonnelOrders(modelsList);
        }

        private void InitDataHandler(List<ChildOrder> modelsList)
        {
            _view.InitChildOrders(modelsList);
        }
        
        private void AddingMainEquipment()
        {
            _kernel.Get<NewMainPresenterEquipment>().Run();
            _view.AddingMainEquipment -= AddingMainEquipment;
            _view.Close();
        }
        
        private void AddingMainOrder()
        {
            _kernel.Get<NewMainPresenterOrder>().Run();
            _view.AddingMainOrder -= AddingMainOrder;
            _view.Close();
        }
        
        private void AddingMainRequest()
        {
            _kernel.Get<NewMainPresenterRequest>().Run();
            _view.AddingMainRequest -= AddingMainRequest;
            _view.Close();
        }
        
        private void AddingMainItem()
        {
            _kernel.Get<NewMainPresenterItem>().Run();
            _view.AddingMainItem -= AddingMainItem;
            _view.Close();
        }
        
        private void AddingMainCleaning()
        {
            _kernel.Get<NewMainPresenterCleaning>().Run();
            _view.AddingMainCleaning -= AddingMainCleaning;
            _view.Close();
        }

        private void AddingMainCompetition()
        {
            _kernel.Get<NewMainPresenterCompetition>().Run();
            _view.AddingMainCompetition -= AddingMainCompetition;
            _view.Close();
        }
        
        private void AddingPersonnelVacation()
        {
            _kernel.Get<NewPersonnelVacationPresenter>().Run();
            _view.AddingPersonnelVacation -= AddingPersonnelVacation;
            _view.Close();
        }

        private void AddingWorkTime()   
        {
            _kernel.Get<NewWorkTimePresenter>().Run();
            _view.AddingPersonnelWorkTime -= AddingWorkTime;
            _view.Close();
        }

        private void AddingPersonnelOrder()
        {
            _kernel.Get<NewPersonnelOrdersPresenter>().Run();
            _view.AddingPersonnelOrders -= AddingPersonnelOrder;
            _view.Close();
        }

        private void AddingChildAttendence()
        {
            _kernel.Get<NewPresenterAttendenceView>().Run();
            _view.AddingPersonnelWorkTime -= AddingChildAttendence;
            _view.Close();
        }

        private void AddingChildCards()
        {
            _kernel.Get<NewChildCardPresenter>().Run();
            _view.AddingChildOrders -= AddingChildCards;
            _view.Close();
        }

        private void AddingChildOrders()
        {
            _kernel.Get<NewOrderPresenter>().Run();
            _view.AddingChildOrders -= AddingChildOrders;
            _view.Close();
        }

        private void DeletingMainEquipment(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.MainEquipment, id);
            command.Execute();
            InitMainEquipment();
        }

        private void DeletingMainOrder(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.MainOrders, id);
            command.Execute();
            InitMainOrders();
        }

        private void DeletingMainRequest(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.MainRequest, id);
            command.Execute();
            InitMainRequests();
        }

        private void DeletingMainItem(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.MainItem, id);
            command.Execute();
            InitMainItems();
        }

        private void DeletingMainCleaning(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.MainCleanings, id);
            command.Execute();
            InitMainCleaning();
        }

        private void DeletingMainCompetition(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.MainCompetition, id);
            command.Execute();
            InitMainComp();
        }

        private void DeletingPersonnelVacation(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.PersonnelVacation, id);
            command.Execute();
            InitPersonnelVacations();
        }

        private void DeletingPersonnelOrder(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.PersonnelOrders, id);
            command.Execute();
            InitPersonnelOrders();
        }

        private void DeletingChildCards(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.ChildCards, id);
            command.Execute();
            InitChildCards();
        }

        private void DeletingChildOrders(int id)
        {
            _executorCommands.DeleteEvent = DeletingHandler;
            var command = new DeleteCommand(_executorCommands, ModelsType.ChildOrders, id);
            command.Execute();
            InitChildOrders();
        }

        private void DeletingHandler(string message)
        {
            _view.ShowErrorMessage(message);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}