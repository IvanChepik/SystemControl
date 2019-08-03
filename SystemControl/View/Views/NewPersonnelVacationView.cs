using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewPersonnelVacationView : Form, INewPersonnelVacationView
    {
        private readonly ApplicationContext _context;

        public NewPersonnelVacationView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public event Action AddingNewVacation;

        public event Action BackToMainView;

        public string Position => PositionTextBox.Text;

        public string FullName => FullNameTextBox.Text;

        public string PersonnelNumber => NumberTextBox.Text;

        public int QuanitityDay => int.Parse(QuantityDaysTextBox.Text);

        public string PlannedDate => PlannedDaysTextBox.Text;

        public string FactDate => FactDaysTextBox.Text;

        public string Notes => NotesTextBox.Text;

        public void GetMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void AddNewPersonnelVacationButton_Click(object sender, EventArgs e)
        {
            AddingNewVacation?.Invoke();
        }

        private void CancelNewVacationButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }
    }
}
