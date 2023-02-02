using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Medicine
{
    internal class MedecineReport
    {
        protected AbstractMedecine medecine;
        protected int count;

        public void Set(AbstractMedecine medecine, int count)
        {
            this.medecine = medecine;
            this.count = count;
        }
    }
}
