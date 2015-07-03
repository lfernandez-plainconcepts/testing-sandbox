using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP8._1_MvvmLight_TestApp1.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
    }
}
