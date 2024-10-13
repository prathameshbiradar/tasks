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
        static void Main(string[] args)
        {
            
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck) {

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
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("Emp Wage : "+empWage);
        }
    }
}
