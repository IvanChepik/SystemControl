using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewMainViewOrder : Form, INewMainViewOrder
    {
        private readonly ApplicationContext _context;

        public NewMainViewOrder(ApplicationContext context)
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
        public event Action AddingNewOrder;

        public string DateOrder => DateTextBox.Text;

        public string NameOrder => NameTextBox.Text;

        public string Status => StatusTextBox.Text;

        private void CancelNewMainOrderButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }

        private void AddNewMainOrderButton_Click(object sender, EventArgs e)
        {
            AddingNewOrder?.Invoke();
        }
    }
}
