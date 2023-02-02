using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clinik
{
    internal abstract class AbstractClinik
    {
        protected string Name;
        protected string Adress;
        protected Queue<Animal.AbstractAnimal> animalList;
        protected Queue<Personal.Personal> personalList;
        protected Queue<Medicine.MedecineReport> medicineList;

        public abstract string Help();

        public abstract Queue<Animal.AbstractAnimal> TakeAnimalList();
        public abstract Queue<Personal.Personal> TakePersonalList();
        public abstract Queue<Medicine.MedecineReport> TakeMedicineList();
    }
}
