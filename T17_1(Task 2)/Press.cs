using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace T17_1_Task_2_
{
    class Press
    {
        /// <summary>
        /// Number of copies
        /// </summary>
        private int copies;
        /// <summary>
        /// Name of edition
        /// </summary>
        private string name;
        /// <summary>
        /// Price of copies
        /// </summary>
        private double price;
        /// <summary>
        /// Properties
        /// </summary>
        public int Copies { get => copies; set => copies = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        /// <summary>
        /// Cost calculating
        /// </summary>
        /// <returns></returns>
        public double Cost()
        {
            return price * copies;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"Copies: {Copies}\nName: {Name}\nPrice: {Price}\nCost: {Cost()}");
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copies">Initializing number of copies</param>
        /// <param name="name">Initializing name of edition</param>
        /// <param name="price">Initializing price of copies</param>
        public Press(int copies, string name, double price)
        {
            this.copies = copies; this.name = name; this.price = price;
        }
    }
}
