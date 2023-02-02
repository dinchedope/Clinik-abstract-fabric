using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Personal
{
    internal abstract class Personal
    {
        protected string name;
        protected string surname;
        protected string description;
        protected string position;

        public abstract string Hello();
    }
}
