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
        static void Main(string[] args)
        {

            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
    public class EmpWageBuilderObject
    {
        public const int Is_part_time = 1;
        public const int Is_full_time = 2;

        private String company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(String company, int empRatePerHour, int numOfWOrking, int maxHoursPerMonth)
        { 
        
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWOrking;
            this.maxHoursPerMonth = maxHoursPerMonth;  
        }
        public void computeEmpWage() 
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp wage for company : "+company+"is: "+totalEmpWage);
        }
        public String toString() {
            return "Total Emp Wage for company : " + this.company + "is: " + this.totalEmpWage;
        }
    }
}
