using Services_Lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebServiceHost(typeof(Service1));
            host.Open();
            Console.WriteLine($"The service is ready at {host.BaseAddresses[0].AbsoluteUri}");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
