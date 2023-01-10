using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client1.ServiceClient1;

namespace Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFSiplexClient service1Client = new WCFSiplexClient();

            string input = string.Empty;

            while (input != "4")
            {
                Console.Write("\n1. Add\n2. Concat\n3. Sum\n4. Exit\n\tCode: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        {
                            Console.Write("x = ");
                            var x = Console.ReadLine();

                            Console.Write("y = ");
                            var y = Console.ReadLine();

                            if (int.TryParse(x, out var xVal) && int.TryParse(y, out var yVal))
                            {
                                var response = service1Client.Add(xVal, yVal);
                                Console.WriteLine($"x + y = {response}");
                            }
                            else
                            {
                                Console.WriteLine("Check inputs");
                            }

                            break;
                        }
                    case "2":
                        {
                            Console.Write("s = ");
                            var s = Console.ReadLine();

                            Console.Write("d = ");
                            var d = Console.ReadLine();

                            if (double.TryParse(d, out var dVal))
                            {
                                var response = service1Client.Concat(s, dVal);
                                Console.WriteLine($"x + y = {response}");
                            }
                            else
                            {
                                Console.WriteLine("Check inputs");
                            }

                            break;
                        }
                    case "3":
                        {
                            Console.Write("s1 = ");
                            var s1 = Console.ReadLine();

                            Console.Write("s2 = ");
                            var s2 = Console.ReadLine();

                            Console.Write("k1 = ");
                            var k1 = Console.ReadLine();

                            Console.Write("k2 = ");
                            var k2 = Console.ReadLine();

                            Console.Write("f1 = ");
                            var f1 = Console.ReadLine();

                            Console.Write("f2 = ");
                            var f2 = Console.ReadLine();

                            if (int.TryParse(k1, out var k1Val)
                                && int.TryParse(k2, out var k2Val)
                                && float.TryParse(f1, out var f1Val)
                                && float.TryParse(f2, out var f2Val))
                            {
                                var response = service1Client.Sum(
                                    new A { s = s1, k = k1Val, f = f1Val },
                                    new A { s = s2, k = k2Val, f = f2Val });

                                Console.WriteLine($"A = [S = {response.s}, K = {response.k}, F = {response.f}]");
                            }
                            else
                            {
                                Console.WriteLine("Check inputs");
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid code");
                            break;
                        }
                }
            }
            service1Client.Close();
        }
    }
}
