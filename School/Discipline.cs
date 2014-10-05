using System;
using System.Collections.Generic;

namespace School
{
    public class Discipline : IDetail
    {
        private string name;
        private int lecturesNumber;
        private List<Student> students;
        private string detail;

        public Discipline(string name, List<Student> students, int lecturesNumber, string detail = null)
        {
            this.Name = name;
            this.Students = students;
            this.LecturesNumber = lecturesNumber;
            this.detail = detail;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students can not be null");
                }
                this.students = value;
            }
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
        public override string ToString()
        {
            return string.Format("Name of discipline: {0}, Number of lectures:{1}, Students: {2}, Details: {3}", this.Name, this.LecturesNumber, this.students, this.detail);
        }
    }
}