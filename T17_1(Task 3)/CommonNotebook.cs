using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_Task_3_
{
    class CommonNotebook : Notebook
    {
        /// <summary>
        /// Cover material of notebook
        /// </summary>
        private string cover_material;
        /// <summary>
        /// Properties
        /// </summary>
        public string Cover_material { get => (cover_material != " " && cover_material != "")? cover_material : "None"; set => cover_material = value; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of notebook</param>
        /// <param name="k">Number of pages</param>
        /// <param name="cover_material">Initializing cover material og notebook</param>
        public CommonNotebook(string name, int k, string cover_material) : base(name, k)
        {
            this.cover_material = cover_material;
        }
        /// <summary>
        /// New cost with cover material
        /// </summary>
        /// <returns>New cost</returns>
        public new double Cost()
        {
            switch (Cover_material.ToLower())
            {
                case "plastic":
                    return base.Cost() + 50;
                case "cardboard":
                    return base.Cost() + 50;
                case "leather":
                    return base.Cost() + 50;
                default:
                    return base.Cost();
            }
        }
        /// <summary>
        /// Output
        /// </summary>
        public new void Output() { base.Output(); WriteLine($"Cover material: {Cover_material}\nNew cost: {Cost()} RUP"); }
    }
}
