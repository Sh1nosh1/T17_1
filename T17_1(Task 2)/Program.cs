using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_Task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Press press = new Press(5, "", 460);
                press.Output();
                WriteLine();

                Magazine magazine = new Magazine(15, "", 2500, "High");
                magazine.Output();
                WriteLine();

                Magazine magazine1 = new Magazine(17, "It", 3000, "Middle");
                magazine1.Output();
                WriteLine();

                Magazine magazine2 = new Magazine(21, "Horror", 1250, "Low");
                magazine2.Output();
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
