using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewMainViewItem : Form, INewMainViewItem
    {
        private readonly ApplicationContext _context;

        public NewMainViewItem(ApplicationContext context)
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
        public event Action AddingNewItem;

        public string NameItem => NameTextBox.Text;

        public string ItemNumber => ItemNumberTextBox.Text;

        public int Quantity => Int32.Parse(QuantityTextBox.Text);

        public string DateItem => DateTextBox.Text;

        public string NumberAct => ActNumberTextBox.Text;

        public string Note => NoteTextBox.Text;

        private void AddNewMainItemButton_Click(object sender, EventArgs e)
        {
            AddingNewItem?.Invoke();
        }

        private void CancelNewMainItemButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }
    }
}
