using System;
using System.Collections.Generic;

namespace School
{
    public class Discipline : IDetail
    {
        private string name;
        private int lecturesNumber;
        public IList<Student> students;
        private string detail;

        public Discipline(string name, IList<Student> students, int lecturesNumber, string detail = null)
            
        {
            this.Name = name;
            this.students = students;
            this.LecturesNumber = lecturesNumber;
            this.detail = detail;
        }


        public int LecturesNumber
        {
            get
            {
                return this.lecturesNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("LecturesNumber", "The number of lectures can not be negative!");
                }

                this.lecturesNumber = value;
            }
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
                    throw new ArgumentNullException("Name", "Discipline name can not be null or empty!");
                }

                this.name = value;
            }
        }





        string IDetail.detail
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}