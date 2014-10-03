using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : People
    {

        private string uniqueClassNumber;
        public Student(string name, string uniqueClassNumber, string detail = null)
            : base(name, detail)
        {
            this.UniqueClassNumber = UniqueClassNumber;
        }

        public string UniqueClassNumber
        {
            get 
            {
                return this.uniqueClassNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Unique number can not be empty");
                }
                this.uniqueClassNumber = value;
            }
        }
    }
}
