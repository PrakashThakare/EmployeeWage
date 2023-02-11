namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation ");
            // Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();


            //Coputaion
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Not Present");
            }
            Console.ReadLine();
        }
    }
}