using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_Task_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Person person = new Person(15);
                person.Print();
                WriteLine();

                Person person1 = new Person(15, "Kirill");
                person1.Print();
                WriteLine();

                Person person2 = new Person(15, "Kirill", "Markow");
                person2.Print();
                WriteLine();

                Employee employee = new Employee(15, "Darya", "Ovcharuk", "DEX", "Programmer");
                employee.Print();
                WriteLine();

                Person person3 = new Employee(15, "n", "n", "n", "n");
                person3.Print();
                WriteLine();

                Students student = new Students(15, "Kirill", "Markow", new DateTime(2007, 02, 12), 215);
                student.Print();*/

                /*List<Person> person = new List<Person>();
                person.Add(new Person(12,"",""));
                person.Add(new Employee(18, "Kirill", "", "DEX", "Uborschik"));
                person.Add(new Students(19, "", "", new DateTime(2005,04,27), 215));
                foreach (var elem in person) { elem.Print(); WriteLine(); }*/

                List<Person> person = new List<Person>();
                bool redflag = true;
                while(redflag)
                {
                    Write("Enter first letter of status E/S: ");
                    string status = ReadLine();
                    Clear();
                    switch (status.ToLower())
                    {
                        case "e":
                            Employee employee = new Employee();
                            person.Add(Employee.Enter());
                            Clear();
                            break;
                        case "s":
                            Students students = new Students();
                            person.Add(Students.Enter());
                            Clear();
                            break;
                        default:
                            Clear();
                            WriteLine("This status doesn't exist\n");
                            redflag = false;
                            break;
                    }
                }
                foreach (var elem in person) { WriteLine(); elem.Print();  }

                
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
