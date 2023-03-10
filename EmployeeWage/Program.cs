using EmployeeWagesUCPrograms;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder builder = new EmployeeWageBuilder();
            builder.AddCompanyEmpwage("DMart", 20, 3, 10);
            builder.AddCompanyEmpwage("Reliance", 10, 2, 20);
            builder.ComputeEmpWageForCompany();
        }
    }
}