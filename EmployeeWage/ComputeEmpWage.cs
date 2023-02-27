using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class ComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDay;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public ComputeEmpWage(string company, int empRatePerhour, int numOfWorkingDay, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerhour;
            this.numOfWorkingDay = numOfWorkingDay;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            
                int empHrs = 0, totalEmpHrs = 0, totalWorkingdays = 0;

                while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingdays < this.numOfWorkingDay)
                {
                    totalWorkingdays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day# : {0} Emp Hrs : {1}", totalWorkingdays,empHrs);
                }

                totalEmpWage = totalEmpHrs * this.empRatePerHour;
                Console.WriteLine("Total Emp Wage for Company : \n{0} is : {1}", company,totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company : " + this.company + "is" + this.totalEmpWage;
        }
    }
}