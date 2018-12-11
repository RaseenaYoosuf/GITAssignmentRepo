using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
//using 21_WCF

namespace _21_WCF_Assign1_Task1_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost ObjHost = new ServiceHost(typeof(_21_WCF_Assignment1_Task1New.Service1));
            ObjHost.Open();
            Console.WriteLine("Service Hosted Successfully!!");
            string tcpaddr = ObjHost.BaseAddresses[0].ToString();
            string httpaddr = ObjHost.BaseAddresses[1].ToString();
            Console.WriteLine("To close Press any key!!");
            Console.ReadLine();
            ObjHost.Close();

        }
    }
}
