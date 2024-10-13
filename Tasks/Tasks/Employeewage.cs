using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Employeewage
    {
        static void Main(string[] args)
        {
            int Is_part_time = 1;
            int Is_Full_Time = 2;
            int emp_rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == Is_part_time)
            {
                empHrs = 4;
            }
            else if (empCheck == Is_Full_Time) {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("Emp Wage : "+empWage);
        }
    }
}
