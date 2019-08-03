
using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewPersonnellOrdersView : Form, INewPersonnelOrdersView
    {
        private readonly ApplicationContext _context;

        public NewPersonnellOrdersView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public event Action AddingNewOrder;

        public event Action BackToMainView;

        public string NameOrder => NameTextBox.Text;

        public string Position => PositionTextBox.Text;

        public string FullName => FullNameTextBox.Text;

        public string Date => DateTextBox.Text;

        public string Status => StatusTextBox.Text;

        public void GetMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void AddPersonnelOrderButton_Click(object sender, EventArgs e)
        {
            AddingNewOrder?.Invoke();
        }

        private void CancelPersonnelOrderButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }
    }
}
