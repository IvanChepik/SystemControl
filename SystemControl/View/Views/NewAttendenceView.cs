using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewAttendenceView : Form, INewAttendenceVIew
    {
        private ApplicationContext _context;

        public NewAttendenceView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public event Action BackToMainView;

        public void GetMessage(string answer)
        {
            MessageBox.Show(answer);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackToMainView?.Invoke();
        }
    }
}
