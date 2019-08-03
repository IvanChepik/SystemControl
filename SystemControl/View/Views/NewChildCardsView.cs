using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewChildCardsView : Form, INewChildCardsView
    {
        private readonly ApplicationContext _context;

        public NewChildCardsView(ApplicationContext context)
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

        public string FullName => FullNameTextBox.Text;

        public string DateBirth => DateBirthTextBox.Text;

        public string PlaceBirth => PlaceBirthTextBox.Text;

        public string Address => AddressTextBox.Text;

        public string NumberAccount => AccountNumberTextBox.Text;

        public string FullNameParents => FullNameTextBox.Text;

        public string HomePhoneNumber => HomeNumberTextBox.Text;

        public string CellPhoneNumber => CellTextBox.Text;

        public string Mail => MailTextBox.Text;

        public string Notes => NotesTextBox.Text;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void AddNewChildCardButton_Click(object sender, EventArgs e)
        {
            AddingNewOrder?.Invoke();
        }

        private void CancelNewChildCardButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }
    }
}
