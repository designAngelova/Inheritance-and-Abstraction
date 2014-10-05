using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class People : IDetail
    {
        private string name;
        private string detail;

        public People(string name, string detail = null)
        {
            this.Name = name;
            this.detail = detail;
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
                    throw new ArgumentNullException("Name can not be empty");
                }
                this.name = value;
            }
        }

        string IDetail.detail
        {
            get
            {
                return this.detail;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Detail can not be empty");
                }
                this.detail = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, {1}", this.Name, this.detail);
        }
    }
}
