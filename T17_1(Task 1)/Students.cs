using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace T17_1_Task_1_
{
    class Students : Person
    {
        /// <summary>
        /// Date of birth
        /// </summary>
        private DateTime dateofbirth;
        /// <summary>
        /// Number of course
        /// </summary>
        private int course;
        /// <summary>
        /// Properties
        /// </summary>
        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public int Course { get => course; set => course = value; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="age">Age</param>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="dateofbirth">Initializing date of birth</param>
        /// <param name="course">Initializing number of course</param>
        public Students(int age, string name, string surname, DateTime dateofbirth, int course) : base(age, name, surname)
        {
            this.dateofbirth = dateofbirth; this.course = course;
        }
        /// <summary>
        /// Output
        /// </summary>
        public new void Print()
        {
            base.Print();
            WriteLine($"Date of birth: {Dateofbirth.ToLongDateString()}\nCourse: {Course}");
        }
    }
}
