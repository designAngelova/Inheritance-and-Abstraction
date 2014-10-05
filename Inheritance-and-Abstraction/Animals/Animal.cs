using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private double age;
        private Gender gender;

        public Animal(string name, double age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can not be empty");
                }
                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new NullReferenceException("The age can not be negative");
                }
                this.age = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Gender: {2}", this.Name, this.Age, this.Gender);
        }

    }
}
