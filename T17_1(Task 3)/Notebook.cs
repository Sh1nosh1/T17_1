using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_Task_3_
{
    class Notebook
    {
        /// <summary>
        /// Name of notebook
        /// </summary>
        private string name;
        /// <summary>
        /// Number of pages
        /// </summary>
        private int k;
        /// <summary>
        /// Properties
        /// </summary>
        public string Name { get => (name != "" && name != " ")? name : "None"; set => name = value; }
        public int K { get => (k > 0)? k : 0; set => k = value; }
        /// <summary>
        /// Constr. without parameters
        /// </summary>
        public Notebook() { }
        /// <summary>
        /// Constr. with parameters
        /// </summary>
        /// <param name="name">Initializing name of notebook</param>
        /// <param name="k">Number of pages</param>
        public Notebook(string name, int k)
        {
            this.name = name; this.k = k;
        }
        /// <summary>
        /// Cost calculating
        /// </summary>
        /// <returns>Cost of notebook</returns>
        public double Cost() { return k * 15; }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"Name of notebook: {Name}\nNumber of pages: {K}\nCost of notebook: {Cost()} RUP");
        }


    }
}
