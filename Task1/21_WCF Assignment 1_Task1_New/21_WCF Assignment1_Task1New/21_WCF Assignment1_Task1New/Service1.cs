using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _21_WCF_Assignment1_Task1New
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string SayHello(string name)
        {
            string Result = string.Empty;

            if (DateTime.Now.Hour < 12)
            {
                Result = string.Concat(name, " Good Morning");
            }
            else if (DateTime.Now.Hour < 17)
            {
                Result = string.Concat(name, " Good Afternoon");
            }
            else
            {
                Result = string.Concat(name, " Good Night");
            }
            return Result;
        }

        public string TodayProgram(string name)
        {
            string Result = string.Empty;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Result = string.Concat(name, " Happy Weekend");
            }
            else
            {
                Result = string.Concat(name, " Enjoy Workingday");
            }
            return Result;

        }
    }
}
