using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewMainViewEquipment : Form, INewMainEquipment
    {
        private readonly ApplicationContext _context;

        public NewMainViewEquipment(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void AddNewMainEquipmentButton_Click(object sender, System.EventArgs e)
        {
            AddingNewEquipment?.Invoke();
        }

        public void GetMessage(string message)
        {
            MessageBox.Show(message);
        }

        public event Action BackToMainView;

        public event Action AddingNewEquipment;

        public string DateEquip => DateTextBox.Text;

        public string StatusBegin => BeginStatusTextBox.Text;

        public string Problems => ProblemsTextBox.Text;

        public string DateProblems => DateProblemsTextBox.Text;

        public string RepairPerson => RepairPersonTextBox.Text;

        public string StatusEnd => EndStatusTextBox.Text;

        private void CancelNewMainEquipmentButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }
    }
}
