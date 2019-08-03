
using System;

namespace View.IViews
{
    public interface INewWorkTimeView : IView
    {
        void GetMessage(string answer);

        event Action BackToMainView;
    }
}
