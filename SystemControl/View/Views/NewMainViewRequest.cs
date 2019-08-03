using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewMainViewRequest : Form, INewMainViewRequest
    {
        private readonly ApplicationContext _context;

        public NewMainViewRequest(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void CancelNewMainRequestButton_Click(object sender, System.EventArgs e)
        {
            BackToMainView?.Invoke();
        }

        public void GetMessage(string message)
        {
            MessageBox.Show(message);
        }

        public event Action BackToMainView;

        public event Action AddingNewRequest;

        public string DateRequest => DateTextBox.Text;

        public string TimeRequest => TimeTextBox.Text;

        public string Content => ContentTextBox.Text;

        public string Applicant => ApplicantTextBox.Text;

        public string AdmissionTime => AdmissionTextBox.Text;

        public string Notes => NotesTextBox.Text;

        private void AddNewMainRequestButton_Click(object sender, EventArgs e)
        {
            AddingNewRequest?.Invoke();
        }
    }
}
