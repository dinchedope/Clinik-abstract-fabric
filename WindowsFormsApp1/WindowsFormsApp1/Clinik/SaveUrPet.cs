using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Animal;

namespace WindowsFormsApp1.Clinik
{
    internal class SaveUrPet : AbstractClinik
    {
        public SaveUrPet(string Name, string Adress, Queue<Animal.AbstractAnimal> animalList, Queue<Personal.Personal> personalList, Queue<Medicine.MedecineReport> medicineList)
        {
            this.Name = Name;
            this.Adress = Adress;
            this.animalList = animalList;
            this.personalList = personalList;
            this.medicineList = medicineList;
        }
        public override string Help()
        {
            return "We are say your pet!";
        }

        public override Queue<AbstractAnimal> TakeAnimalList()
        {
            return this.animalList;
        }

        public override Queue<Personal.Personal> TakePersonalList()
        {
            return this.personalList;
        }

        public override Queue<Medicine.MedecineReport> TakeMedicineList()
        {
            return this.medicineList;
        }
    }
}
