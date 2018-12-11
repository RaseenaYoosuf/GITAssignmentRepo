using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _21_WCF_Assignment1_Task1New
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string SayHello(String value);

        [OperationContract]
        string TodayProgram(String value);



        // TODO: Add your service operations here
    }
}
