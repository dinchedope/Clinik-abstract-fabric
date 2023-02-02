using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Animal
{
    internal class Cat : AbstractAnimal
    {
        public Cat(string petName, string classification, string breedname, bool haveFur)
        {
            this.petName = petName;
            this.classification = classification;
            this.breedname = breedname;
            this.haveFur = haveFur;
        }

        public override string MainDo()
        {
            return "Meow!!!!!";
        }
    }
}
