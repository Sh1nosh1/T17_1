using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_Task_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Notebook notebook1 = new Notebook("Mathematics", 12);
                notebook1.Output();
                WriteLine();

                CommonNotebook notebook2 = new CommonNotebook("Chemistry", 96, "Leather");
                notebook2.Output();
                WriteLine();

                CommonNotebook notebook3 = new CommonNotebook("Anatomy", 24, "Plastic");
                notebook3.Output();
                WriteLine();

                CommonNotebook notebook4 = new CommonNotebook("Biology", 64, "Cardboard");
                notebook4.Output();
                WriteLine();

                CommonNotebook notebook5 = new CommonNotebook("Informatic", 48, "");
                notebook5.Output();
                WriteLine();
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
