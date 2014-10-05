using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student:People
    {
        private string uniqueClassNumber;
       
        public Student(string name, string uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;

        }

        public Student(string name, string uniqueClassNumber, string detail)
            : this(name, uniqueClassNumber)
        {
            this.Detail = detail;
        }

        public string UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {

                this.uniqueClassNumber = value;
            }
        }
        public override string ToString()
        {

            return string.Format("Name: {0}, Student Number:{1}", this.Name, this.UniqueClassNumber);
        }
    }
}
