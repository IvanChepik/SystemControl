using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewMainViewCleaning : Form, INewMainViewCleaning
    {
        private readonly ApplicationContext _context;

        public NewMainViewCleaning(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void GetMessage(string message)
        {
            MessageBox.Show(message);
        }

        public event Action BackToMainView;
        public event Action AddingNewCleaning;

        public string PlaceCleaning => PlaceTextBox.Text;

        public string PlannedData => PlannedDateTextBox.Text;

        public string DesName => DisinfectantTextBox.Text;

        public string FactData => FactDateTextBox.Text;

        public string Executor => ExecutorTextBox.Text;

        private void CancelNewMainCleaningButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }

        private void AddNewMainCleaningButton_Click(object sender, EventArgs e)
        {
            AddingNewCleaning?.Invoke();
        }
    }
}
