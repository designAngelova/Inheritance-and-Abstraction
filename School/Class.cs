using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class : IDetail
    {
        private string uniqueTextId;
        private IList<Student> students;
        private IList<Teacher> techers;

        public Class(string uniqueTextId, IList<Student> students, IList<Teacher> teachers)
        {
            this.UniqueTextId = uniqueTextId;
            this.Students = students;
            this.Teachers = techers;

        }
       
        public string UniqueTextId
        {
            get
            {
                return this.uniqueTextId;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Unique text Id can not be empty");
                }
                this.uniqueTextId = value;
            }
        }
       
        public IList<Student> Students 
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
        public IList<Teacher> Teachers 
        {
            get
            {
                return this.techers;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Techers can not be null");
                }
                this.techers = value;
            }
        }


        public string detail
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
