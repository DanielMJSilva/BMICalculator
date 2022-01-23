using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_MachadoJustoDaSilva_Ex_01
{
    class Person
    {
        public string PersonID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set;  }
        public string Birthday { get; set; }
        public string BMI { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string NumSystem { get; set; }

        private static int CURRENT_ID = 15;
        public Person()
        {

        }

        public Person(string name, string sex, string birth, string bmi, string height, string weight, string numSystem, string id)
        {
            PersonID = id;
            Name = name;
            Sex = sex;
            Birthday = birth;
            BMI = bmi;
            Height = height;
            Weight = weight;
            NumSystem = numSystem;
        }

        public Person(string name, string sex, string birth, string bmi, string height, string weight, string numSystem)
        {
            PersonID = $"{CURRENT_ID++}";
            Name = name;
            Sex = sex;
            Birthday = birth;
            BMI = bmi;
            Height = height;
            Weight = weight;
            NumSystem = numSystem;
        }


        public string GetPersonID()
        {
            return PersonID;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetSex()
        {
            return Sex;
        }
        public string GetBirthday()
        {
            return Birthday;
        }
        public string GetBMI()
        {
            return BMI;

        }
        public string GetHeight()
        {
            return Height;
        }
        public string GetWeight()
        {
            return Weight;
        }
        public string GetNumSystem()
        {
            return NumSystem;
        }
        public override string ToString()
        {
            return PersonID + ", " + Name + ", " + Sex + ", " + Birthday + ", " + BMI + ", " + Height + ", " + Weight + ", " + NumSystem + "\n";

        }

    }



    
}
