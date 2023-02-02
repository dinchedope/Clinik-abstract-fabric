using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Animal;
using WindowsFormsApp1.Clinik;
using WindowsFormsApp1.Medicine;
using WindowsFormsApp1.Personal;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Clinik.AbstractClinik thisClinik;
        public Form1()
        {
            InitializeComponent();
            AbstractAnimal cat = new Cat("Bela", "Cat", "Cat", true);
            Queue<AbstractAnimal> animal = new Queue<AbstractAnimal>();
            animal.Enqueue(cat);

            Personal.Personal doctor = new Doctor("Viktor", "Hight");
            Personal.Personal menegder = new Menedger("Vladislav", "Voytenko");
            Queue<Personal.Personal> personal = new Queue<Personal.Personal>();
            personal.Enqueue(doctor);
            personal.Enqueue(menegder);

            AbstractMedecine espumizan = new Espumizan("Espumizan");
            MedecineReport clinikMedicineString = new MedecineReport();
            clinikMedicineString.Set(espumizan, 20);
            Queue<MedecineReport> medecineReport = new Queue<MedecineReport>();
            medecineReport.Enqueue(clinikMedicineString);

            thisClinik = new SaveUrPet("Save Your Pet", "Kyiv city Veterenayevo 12 B", animal, personal, medecineReport);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            textBox1.Text = thisClinik.Help();
        }
    }
}
