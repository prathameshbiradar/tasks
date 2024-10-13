using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Employeewage
    {
        public const int Is_part_time = 1;
        public const int Is_full_time = 2;
        public static int computeEmpWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {

                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_part_time:
                        empHrs = 4;
                        break;
                    case Is_full_time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
              }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {

           computeEmpWage("DMart", 20,2,10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
