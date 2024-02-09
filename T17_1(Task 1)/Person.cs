using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace T17_1_Task_1_
{
    class Person
    {
        /// <summary>
        /// Age
        /// </summary>
        private int age;
        /// <summary>
        /// Name
        /// </summary>
        private string name;
        /// <summary>
        /// Surname
        /// </summary>
        private string surname;
        /// <summary>
        /// Field properties
        /// </summary>
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Person() { }
        /// <summary>
        /// Constr. with 1 parameter
        /// </summary>
        /// <param name="age">Initializing age</param>
        public Person(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Constr. with 2 parameters
        /// </summary>
        /// <param name="age">Age</param>
        /// <param name="name">Initializing name</param>
        public Person(int age, string name) : this(age)
        {
            this.name = name;
        }
        /// <summary>
        /// Constr. with 3 parameters
        /// </summary>
        /// <param name="age">Age</param>
        /// <param name="name">Name</param>
        /// <param name="surname">Initializing surname</param>
        public Person(int age, string name, string surname) : this(age, name)
        {
            this.surname = surname;
        }
        /// <summary>
        /// Output
        /// </summary>
        /*public void Print()
        {
            WriteLine($"Age: {Age}\nName: {Name}\nSurname: {Surname}");
        }*/
        virtual public void Print()
        {
            WriteLine($"Age: {Age}\nName: {Name}\nSurname: {Surname}");
        }
    }
}
