using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class ComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int getComputeEmpWage(string company,int empRatePerhour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingdays = 0;

                while (totalEmpHrs <= maxHoursPerMonth && totalWorkingdays < numOfWorkingDays)
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

                    Console.WriteLine("Day# : {0} Emp Hrs : {1}", totalWorkingdays, empHrs);
                }

                int totalEmpWage = totalEmpHrs * empRatePerhour;
                Console.WriteLine("Total Emp Wage for Company : \n{0} is : {1}", company, totalEmpWage);
                return totalEmpWage;
            }
        }
    }
}
