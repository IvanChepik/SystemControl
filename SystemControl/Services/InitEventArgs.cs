using System.Collections.Generic;

namespace Services
{
    public class InitEventArgs<T>
    {
        public List<T> ModelList { get; }

        public InitEventArgs(List<T> modelList)
        {
            ModelList = modelList;
        }
    }
}