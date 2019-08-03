using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewOrderView : Form, INewOrderView
    {
        private readonly ApplicationContext _context;

        public NewOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action AddingNewOrder;

        public event Action BackToMainView;

        public void GetMessage(string message)
        {
            MessageBox.Show(message);
        }

        public string NameOrder => NameTextBox.Text;

        public string FullName => FullNameTextBox.Text;

        public string DateOrder => DateTextBox.Text;

        public string StatusOrder => StatusTextBox.Text;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void CancelAddingOrderButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }

        private void AddNewOrderButton_Click(object sender, EventArgs e)
        {
            AddingNewOrder?.Invoke();
        }
    }
}
