using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;
using View.IViews;

namespace View.Views
{
    public partial class MainView : Form, IMainView
    {
        private readonly ApplicationContext _context;

        public MainView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            ChildOrdersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public int IdSelectedChildOrder => int.Parse(ChildOrdersView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedChildCard => int.Parse(ChildCardView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedPersonnelOrder => int.Parse(PersonnelOrdersView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedPersonnelVacation => int.Parse(PersonnelVacationView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedMainOrder => int.Parse(MainOrdersView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedMainCleaning => int.Parse(MainCleaningView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedMainItem => int.Parse(MainItemView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedMainRequest => int.Parse(MainRequestsView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedMainComp => int.Parse(MainCompetitionView.SelectedRows[0].Cells[0].Value.ToString());

        public int IdSelectedMainEquip => int.Parse(MainEquipmentView.SelectedRows[0].Cells[0].Value.ToString());

        public event Action AddingChildOrders;

        public event Action AddingChildCards;

        public event Action AddingPersonnelOrders;

        public event Action AddingPersonnelVacation;

        public event Action AddingMainOrder;

        public event Action AddingMainEquipment;

        public event Action AddingMainRequest;

        public event Action AddingMainCleaning;

        public event Action AddingMainItem;

        public event Action AddingMainCompetition;

        public event Action AddingChildAttendence;

        public event Action OpeningFileWord;

        public void OpenWordFile()
        {
            if (WordFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = WordFileDialog.FileName;
                Process.Start(filename);
            }
        }


        public event Action AddingPersonnelWorkTime;

        public event Action DeletingChildOrders;

        public event Action DeletingChildCards;

        public event Action DeletingPersonnelOrders;

        public event Action DeletingPersonnelVacation;

        public event Action DeletingMainOrder;

        public event Action DeletingMainEquipment;

        public event Action DeletingMainRequest;

        public event Action DeletingMainCleaning;

        public event Action DeletingMainItem;

        public event Action DeletingMainCompetition;

        public void InitChildOrders(List<ChildOrder> modelsList)
        {
            ChildOrdersView.DataSource = modelsList;
        }

        public void InitChildCards(List<ChildCard> modelsList)
        {
            ChildCardView.DataSource = modelsList;
        }

        public void InitPersonnelOrders(List<PersonnelOrder> modelList)
        {
            PersonnelOrdersView.DataSource = modelList;
        }

        public void InitPersonnelVacations(List<PersonnelVacation> modelList)
        {
            PersonnelVacationView.DataSource = modelList;
        }

        public void InitMainOrders(List<MainOrders> modelList)
        {
            MainOrdersView.DataSource = modelList;
        }

        public void InitMainRequest(List<MainRequest> modelList)
        {
            MainRequestsView.DataSource = modelList;
        }

        public void InitMainEquip(List<MainEquipment> modelList)
        {
            MainEquipmentView.DataSource = modelList;
        }

        public void InitMainComp(List<MainCompetition> modelList)
        {
            MainCompetitionView.DataSource = modelList;
        }

        public void InitMainItems(List<MainItem> modelList)
        {
            MainItemView.DataSource = modelList;
        }

        public void InitMainCleanings(List<MainCleaning> modelList)
        {
            MainCleaningView.DataSource = modelList;
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void AddChildOrder_Click(object sender, System.EventArgs e)
        {
            AddingChildOrders?.Invoke();
        }

        private void ChildCardAdd_Click(object sender, EventArgs e)
        {
            AddingChildCards?.Invoke();
        }

        private void PersonnelVacationAdd_Click(object sender, EventArgs e)
        {
            AddingPersonnelVacation?.Invoke();
        }

        private void PersonnelOrderAddButton_Click(object sender, EventArgs e)
        {
            AddingPersonnelOrders?.Invoke();
        }

        private void AddNewMainOrderButton_Click(object sender, EventArgs e)
        {
            AddingMainOrder?.Invoke();
        }

        private void AddNewMainEquipmentButton_Click(object sender, EventArgs e)
        {
            AddingMainEquipment?.Invoke();
        }

        private void AddNewMainItemButton_Click(object sender, EventArgs e)
        {
            AddingMainItem?.Invoke();
        }

        private void AddNewMainRequestButton_Click(object sender, EventArgs e)
        {
            AddingMainRequest?.Invoke();
        }

        private void AddNewMainCleaningButton_Click(object sender, EventArgs e)
        {
            AddingMainCleaning?.Invoke();
        }

        private void AddNewMainCompetitionButton_Click(object sender, EventArgs e)
        {
            AddingMainCompetition?.Invoke();
        }

        private void DeleteChildOrder_Click(object sender, EventArgs e)
        {
            DeletingChildOrders?.Invoke();
        }

        private void DeleteChildCard_Click(object sender, EventArgs e)
        {
            DeletingChildCards?.Invoke();
        }

        private void DeletePersonnelOrder_Click(object sender, EventArgs e)
        {
            DeletingPersonnelOrders?.Invoke();
        }

        private void CleaningFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindCleaningTextBox.Text;

            for (var i = 0; i < MainCleaningView.RowCount; i++)
            {
                if (fullname.Equals(MainCleaningView[1, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(MainCleaningView, i));
                    return;
                }
            }
        }

        private void DeletePersonnelVacation_Click(object sender, EventArgs e)
        {
            DeletingPersonnelVacation?.Invoke();
        }

        private void DeleteMainItem_Click(object sender, EventArgs e)
        {
            DeletingMainItem?.Invoke();
        }

        private void DeleteMainRequest_Click(object sender, EventArgs e)
        {
            DeletingMainRequest?.Invoke();
        }

        private void DeleteMainCleaning_Click(object sender, EventArgs e)
        {
            DeletingMainCleaning?.Invoke();
        }

        private void DeleteMainComp_Click(object sender, EventArgs e)
        {
            DeletingMainCompetition?.Invoke();
        }

        private void DeleteMainOrder_Click(object sender, EventArgs e)
        {
            DeletingMainOrder?.Invoke();
        }

        private void DeleteMainEquip_Click(object sender, EventArgs e)
        {
            DeletingMainEquipment?.Invoke();
        }

        private void AddChildAttendence_Click(object sender, EventArgs e)
        {
            AddingChildAttendence?.Invoke();
        }

        private void AddWorkTimeButton_Click(object sender, EventArgs e)
        {
            AddingPersonnelWorkTime?.Invoke();
        }

        private void WordChildOrderButton_Click(object sender, EventArgs e)
        {
            OpeningFileWord?.Invoke();
        }

        private void WordOpenMainButton_Click(object sender, EventArgs e)
        {
            OpeningFileWord?.Invoke();
        }

        private void WordOrderPersonnelButton_Click(object sender, EventArgs e)
        {
            OpeningFileWord?.Invoke();
        }

        private void MainItemFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindItemTextBox.Text;

            for (var i = 0; i < MainItemView.RowCount; i++)
            {
                if (fullname.Equals(MainItemView[2, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(MainItemView, i));
                    return;
                }
            }

            MessageBox.Show("Не найдено.");
        }

        private void OrderChildFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindChildOrderTextBox.Text;

            for (var i = 0; i < ChildOrdersView.RowCount; i++)
            {
                if (fullname.Equals(ChildOrdersView[3, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(ChildOrdersView, i));
                    return;
                }                
            }

            MessageBox.Show("Не найдено.");
        }

        private string GetAllRow(DataGridView gridView, int index)
        {
            string row = string.Empty;

            for (var i = 0; i < gridView.ColumnCount; i++)
            {
                row += gridView[i, index].Value + "//";
            }

            return row;
        }

        private void CardFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindChildCardTextBox.Text;

            for (var i = 0; i < ChildCardView.RowCount; i++)
            {
                if (fullname.Equals(ChildCardView[1, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(ChildCardView, i));
                    return;
                }
            }
        }

        private void PersonnelOrderFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindPersonnelOrderTextBox.Text;

            for (var i = 0; i < PersonnelOrdersView.RowCount; i++)
            {
                if (fullname.Equals(PersonnelOrdersView[3, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(PersonnelOrdersView, i));
                    return;
                }
            }
        }

        private void VacationFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindVacationTextBox.Text;

            for (var i = 0; i < PersonnelVacationView.RowCount; i++)
            {
                if (fullname.Equals(PersonnelVacationView[2, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(PersonnelVacationView, i));
                    return;
                }
            }
        }

        private void OrderMainFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindMainOrderTextBOx.Text;

            for (var i = 0; i < MainOrdersView.RowCount; i++)
            {
                if (fullname.Equals(MainOrdersView[1, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(MainOrdersView, i));
                    return;
                }
            }
        }

        private void EquipFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindEquipTextBox.Text;

            for (var i = 0; i < MainEquipmentView.RowCount; i++)
            {
                if (fullname.Equals(MainEquipmentView[1, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(MainEquipmentView, i));
                    return;
                }
            }
        }

        private void RequestFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindRequestTextBox.Text;

            for (var i = 0; i < MainRequestsView.RowCount; i++)
            {
                if (fullname.Equals(MainRequestsView[1, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(MainRequestsView, i));
                    return;
                }
            }
        }

        private void CompFindButton_Click(object sender, EventArgs e)
        {
            var fullname = FindCompTextBox.Text;

            for (var i = 0; i < MainCompetitionView.RowCount; i++)
            {
                if (fullname.Equals(MainCompetitionView[1, i].Value.ToString()))
                {
                    MessageBox.Show(GetAllRow(MainCompetitionView, i));
                    return;
                }
            }
        }
    }
}
