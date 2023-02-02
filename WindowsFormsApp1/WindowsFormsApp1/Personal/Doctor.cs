using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Personal
{
    internal class Doctor : Personal
    {
        public Doctor(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public override string Hello()
        {
            return $"Hello, my name is {this.name} {this.surname}. Hot i can help your pet?";
        }
    }
}
