using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Animal
{
    internal abstract class AbstractAnimal
    {
        protected string petName;
        protected string description;
        protected int pawCount;
        protected bool haveFur;

        protected string classification;
        protected string breedname;

        public abstract string MainDo();

    }
}
