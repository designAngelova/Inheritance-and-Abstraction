using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : People
    {
        private IList<Discipline> disciplines;

        public Teacher(string name, IList<Discipline> disciplines, string detail = null)
            : base(name, detail)
        {
            this.Disciplines = disciplines;
        }

        public IList<Discipline> Disciplines 
        { 
            get
            {
                return this.disciplines;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Disciplines can not be empty");
                }
                this.disciplines = value;
            }
        }
    }
}
