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

        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> disciplines)
            : this(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, List<Discipline> disciplines, string detail)
            : this(name, disciplines)
        {
            this.Detail = detail;
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
        public override string ToString()
        {
            return string.Format("Name: {0}, List of Disciplines: {1}", this.Name, this.Disciplines);
        }
    }
}
