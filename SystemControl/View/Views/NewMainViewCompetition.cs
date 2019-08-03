using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewMainViewCompetition : Form, INewMainViewCompetition
    {
        private readonly ApplicationContext _context;

        public NewMainViewCompetition(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void CancelNewMaiCompetitionButton_Click(object sender, System.EventArgs e)
        {
            BackToMainView?.Invoke();
        }

        public void GetMessage(string message)
        {
            MessageBox.Show(message);
        }

        public event Action BackToMainView;
        public event Action AddingNewComp;

        public string DateComp => DateTextBox.Text;

        public string Fullname => FullnameTextBox.Text;

        public int Group => int.Parse(GroupTextBox.Text);

        public string NameComp => NameCompTextBox.Text;

        public string Storage => StorageTextBox.Text;

        private void AddNewMainCompetitionButton_Click(object sender, EventArgs e)
        {
            AddingNewComp?.Invoke();
        }
    }
}
