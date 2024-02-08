using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_Task_1_
{
    class Employee : Person
    {
        /// <summary>
        /// Name of company
        /// </summary>
        private string company;
        /// <summary>
        /// Position
        /// </summary>
        private string job;
        /// <summary>
        /// Field properties
        /// </summary>
        public string Company { get => company; set => company = value; }
        public string Job { get => job; set => job = value; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="age">Age</param>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="company">Initializing company</param>
        /// <param name="job">Initializing job</param>
        public Employee(int age, string name, string surname, string company, string job) : base(age, name, surname)
        {
            this.company = company; this.job = job;
        }
        /// <summary>
        /// Output
        /// </summary>
        new public void Print()
        {
            base.Print();
            WriteLine($"Company: {Company}\nJob: {Job}");
        }
    }
}
