using System;
using WP8._1_MvvmLight_TestApp1.Model;

namespace WP8._1_MvvmLight_TestApp1.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }
    }
}