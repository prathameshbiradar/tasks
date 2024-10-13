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
        public const int emp_rate_per_hour = 20;
        public const int num_of_working_days = 2;
        public const int max_hrs_in_month = 10;

        public static int computeEmpWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= max_hrs_in_month && totalWorkingDays < num_of_working_days)
            {

                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0,3);
                switch (empCheck)
                { 
                    case Is_part_time :
                        empHrs = 4;
                        break;
                    case Is_full_time :
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0; 
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * emp_rate_per_hour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {

           computeEmpWage();
        }
    }
}
