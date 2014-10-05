using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number can not be empty");
                }
                if (value.Length<5|| value.Length>10)
                {
                    throw new FormatException("Faculty number must be between 5 and 10 digits long");
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
