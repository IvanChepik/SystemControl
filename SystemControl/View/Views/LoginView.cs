using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class LoginView : Form, ILoginView
    {
        private readonly ApplicationContext _context;

        public LoginView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public string Login => LoginTextBox.Text;

        public string Password => PasswordTextBox.Text;

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка!");
        }

        public event Action TryLogin;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            TryLogin?.Invoke();   
        }
    }
}
