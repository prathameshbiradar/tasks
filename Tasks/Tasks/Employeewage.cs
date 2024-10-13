using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class CompanyEmpWage 
    {

        public String company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            
        }
        public void setTotalEmpWage(int totalEmpWage)
        { 
            this.totalEmpWage = totalEmpWage;
        }
        public String toString()
        {
            return "Total Emp Wage for company :" + this.company + " is: " + this.totalEmpWage;
        }
    }
    public class Employeewage
    {
        static void Main(string[] args)
        {

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addcompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
    public class EmpWageBuilderArray
    {
        public const int Is_part_time = 1;
        public const int Is_full_time = 2;

        private int numofcompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(String company, int empRatePerHour, int numofworkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numofcompany] = new CompanyEmpWage(company, empRatePerHour, numofworkingDays, maxHoursPerMonth);
            numofcompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numofcompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Days# : " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}
