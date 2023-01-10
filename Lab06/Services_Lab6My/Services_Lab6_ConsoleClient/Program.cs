using Services_Lab6Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWS_6_client
{
    class Program
    {
        private static String urlConnect = "http://localhost:51906/WcfDataService1.svc";
        static void Main(string[] args)
        {
            try
            {

                int choise = 1;
                while (choise != 0)
                {
                    Console.WriteLine("1.Add\n" +
                                        "2.Update Name\n" +
                                        "3.Print\n" +
                                        "0.Exit");
                    choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1: Add(); break;
                        case 2: Update(); break;
                        case 3: PrintValues(); break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }

        }

        static void PrintValues()
        {
            Services_Lab6Entities2 service = new Services_Lab6Entities2(new Uri(urlConnect));

            foreach (var student in service.Students.AsEnumerable())
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Id: {student.Id}\nName: {student.Name}");
                Console.WriteLine();
                foreach (var note in service.Notes.Where(i => i.Id_student == student.Id).AsEnumerable())
                {
                    Console.WriteLine($"  Subj: {note.Subj}, Note: {note.Note1}");
                }
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("\n\n\n");
        }
        static void Add()
        {
            Services_Lab6Entities2 service = new Services_Lab6Entities2(new Uri(urlConnect));

            Student student = new Student();
            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();
            //Console.Write("Enter Phone: ");
            //student.Phone = Console.ReadLine();
            service.AddToStudents(student);
            service.SaveChanges();
        }
        static void Update()
        {
            Services_Lab6Entities2 service = new Services_Lab6Entities2(new Uri(urlConnect));
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            var student = service.Students.AsEnumerable().First(i => i.Id == id);
            Console.Write("New Name: ");
            student.Name = Console.ReadLine();
            service.UpdateObject(student);
            service.SaveChanges();
        }
    }
}
