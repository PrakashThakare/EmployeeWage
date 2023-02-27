namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputeEmpWage dMart = new ComputeEmpWage("DMart", 20, 2, 10);
            ComputeEmpWage reliance = new ComputeEmpWage("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}