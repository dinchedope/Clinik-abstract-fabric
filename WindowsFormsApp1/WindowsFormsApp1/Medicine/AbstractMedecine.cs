using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Medicine
{
    internal abstract class AbstractMedecine
    {
        protected string name;
        protected string description;

        public abstract string Do();
    }
}
