using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Host.Service;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ServiceHost host = new ServiceHost(typeof(WCFSiplex));
                host.Open();
                Console.WriteLine("Host running");
                Console.ReadKey();
                host.Close();
            }
            catch
            {
                Console.WriteLine("Error Host");
            }
        }
    }
}
