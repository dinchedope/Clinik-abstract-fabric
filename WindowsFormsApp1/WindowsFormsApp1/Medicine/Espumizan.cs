using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Medicine
{
    internal class Espumizan : AbstractMedecine
    {
        public Espumizan(string name)
        {
            this.name = name;
        }

        public override string Do()
        {
            return $"I something do for pet. I hope it's helping him";
        }
    }
}
