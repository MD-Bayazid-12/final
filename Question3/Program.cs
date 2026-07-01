using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public abstract class Employee
    {
        public abstract decimal CalculateMonthlyGross();
    }
    public class PermanentEmployee : Employee
    {
        public DateTime JoinDate { get; set; }
        public decimal Basic { get; set; }
        public decimal Allowance { get; set; }

        public override decimal CalculateMonthlyGross()
        {
            return Basic + Allowance;
        }
    }
    public class HiredEmployee : Employee
    {
        public DateTime HireDate { get; set; }
        public decimal PayRate { get; set; }
        public int WorkHourPerDay { get; set; }
        private const int WorkingDaysPerMonth = 22;

        public override decimal CalculateMonthlyGross()
        {
           
            return PayRate * WorkHourPerDay * WorkingDaysPerMonth;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var perm = new PermanentEmployee { Basic = 50000, Allowance = 5000 };
            Console.WriteLine($"Permanent Gross: {perm.CalculateMonthlyGross()}");

            // Example: Hired Employee
            var hired = new HiredEmployee { PayRate = 50, WorkHourPerDay = 8 };
            Console.WriteLine($"Hired Gross: {hired.CalculateMonthlyGross()}");
        }
    }
}
