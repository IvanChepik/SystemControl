using System;

namespace View.IViews
{
    public interface INewAttendenceVIew : IView
    {
        event Action BackToMainView;

        void GetMessage(string answer);
    }
}