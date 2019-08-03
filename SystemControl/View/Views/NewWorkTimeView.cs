using System;
using System.Windows.Forms;
using View.IViews;

namespace View.Views
{
    public partial class NewWorkTimeView : Form, INewWorkTimeView
    {
        private readonly ApplicationContext _context;

        public NewWorkTimeView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            BackToMainView?.Invoke();
            
        }

        public void GetMessage(string answer)
        {
            MessageBox.Show(answer);
        }

        public event Action BackToMainView;
    }
}
