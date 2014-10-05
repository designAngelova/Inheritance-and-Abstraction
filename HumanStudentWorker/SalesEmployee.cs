using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class SalesEmployee:RegularEmployee,ISaleEmployee
    {
        private IList<ISale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, Departments departament, IList<ISale> sales) :
            base(id, firstName, lastName, salary, departament)
        {
            this.Sales = sales;
        }

        public IList<ISale> Sales
        {
            get
            {
                return this.sales;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Sales", "Sales can not be null!");
                }

                this.sales = value;
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nSales: \n{0}", string.Join("\n", this.Sales));
        }
    }
}
