using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
  public class Worker:Human
    {
        private decimal weekSalary;
        private float workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, float workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        { 
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value<0)
                {
                    throw new NullReferenceException("Week salary can not be negative");
                }
                this.weekSalary = value;
            }
        }

        public float WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new NullReferenceException("Work hours per day can not be negative");
                }
                this.workHoursPerDay = value;
            }
        }
        public decimal MoneyPerHour(int workDays)
        {
            decimal result = this.weekSalary / (decimal)(workDays * this.workHoursPerDay);
            return result;

        }

        public override string ToString()
        {
            return string.Format("Week salary: {0}, Work hours per day: {1}",
                this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
