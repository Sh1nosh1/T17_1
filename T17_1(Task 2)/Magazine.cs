using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_Task_2_
{
    class Magazine : Press
    {
        /// <summary>
        /// Quality of magazine
        /// </summary>
        private string quality;
        /// <summary>
        /// Properties
        /// </summary>
        public string Quality { get => quality; set => quality = value; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copies">Number of copies</param>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="quality">Initializing quality</param>
        public Magazine(int copies, string name, double price, string quality) : base(copies, name, price)
        {
            this.quality = quality;
        }
        /// <summary>
        /// Cost calculation
        /// </summary>
        /// <returns>Cost of magazine</returns>
        new public double Cost()
        {
            if (Quality == "High") { return base.Cost() + (base.Cost() * 0.1); }
            else if (Quality == "Middle") { return base.Cost(); }
            else { return base.Cost() - (base.Cost() * 0.1); }
        }
        /// <summary>
        /// Output
        /// </summary>
        new public void Output()
        {
            base.Output();
            WriteLine($"Quality: {Quality}\nNew cost: {Cost()}");
        }
    }
}
