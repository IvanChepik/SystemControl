using System;
using System.Collections.Generic;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;

namespace View.IViews
{
    public interface IMainView : IView
    {
        int IdSelectedChildOrder { get; }

        int IdSelectedChildCard { get; }

        int IdSelectedPersonnelOrder { get; }

        int IdSelectedPersonnelVacation { get; }

        int IdSelectedMainOrder { get; }

        int IdSelectedMainCleaning { get; }

        int IdSelectedMainItem { get; }

        int IdSelectedMainRequest { get; }

        int IdSelectedMainComp { get; }

        int IdSelectedMainEquip { get; }

        event Action AddingChildOrders;

        event Action AddingChildCards;

        event Action AddingPersonnelOrders;

        event Action AddingPersonnelVacation;

        event Action AddingMainOrder;

        event Action AddingMainEquipment;

        event Action AddingMainRequest;

        event Action AddingMainCleaning;

        event Action AddingMainItem;

        event Action AddingMainCompetition;

        event Action AddingChildAttendence;

        event Action OpeningFileWord;

        void OpenWordFile();

        event Action AddingPersonnelWorkTime;

        event Action DeletingChildOrders;

        event Action DeletingChildCards;

        event Action DeletingPersonnelOrders;

        event Action DeletingPersonnelVacation;

        event Action DeletingMainOrder;

        event Action DeletingMainEquipment;

        event Action DeletingMainRequest;

        event Action DeletingMainCleaning;

        event Action DeletingMainItem;

        event Action DeletingMainCompetition;

        void ShowErrorMessage(string message);

        void InitChildOrders(List<ChildOrder> modelsList);

        void InitChildCards(List<ChildCard> modelsList);

        void InitPersonnelOrders(List<PersonnelOrder> modelList);

        void InitPersonnelVacations(List<PersonnelVacation> modelList);

        void InitMainOrders(List<MainOrders> modelList);

        void InitMainRequest(List<MainRequest> modelList);

        void InitMainEquip(List<MainEquipment> modelList);

        void InitMainComp(List<MainCompetition> modelList);

        void InitMainItems(List<MainItem> modelList);

        void InitMainCleanings(List<MainCleaning> modelList);
    }
}