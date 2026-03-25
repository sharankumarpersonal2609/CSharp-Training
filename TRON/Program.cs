using System;
 
namespace EmployeeDepartment

{
    class EmployeeCost
    {
        public double CalculateEmployeeCost()
        {
            Console.WriteLine("\n--- Employee Department ---");
            Console.Write("Packages delivered: ");
            int packages = int.Parse(Console.ReadLine());
            Console.Write("Working days: ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("Shift (day/night): ");
            string shift = Console.ReadLine().ToLower();
            Console.Write("Feedback (1-5): ");
            int feedback = int.Parse(Console.ReadLine());
            double salary = (packages * 50) + (days * 75);
            if (shift == "night")
                salary += salary * 0.10;
            if (feedback >= 4)
                salary += 500;
            else if (feedback <= 2)
                salary -= 200;
 
            double tax = salary * 0.10;

            double medical = 200;

            double loan = 300;
 
            double netSalary = salary - (tax + medical + loan);
 
            Console.WriteLine("Net Salary: $" + netSalary);
 
            return netSalary;

        }

    }

}
 
namespace CallCenterDepartment
{
    class CallCenterCost
    {

        public double CalculateCallCost()
        {
            Console.WriteLine("\n--- Call Center Department ---");
            Console.Write("Number of calls: ");
            int calls = int.Parse(Console.ReadLine());
            Console.Write("Cost per call: ");
            int cost = int.Parse(Console.ReadLine());
            double total = calls * cost;
            Console.WriteLine("Call Center Cost: $" + total);
            return total;
        }
    }

}
 
namespace OtherDepartment
{
    class OtherCost
    {
        public double CalculateOtherCost()
        {
            Console.WriteLine("\n--- Other Costs ---");
            Console.Write("Electricity cost: ");
            double electricity = double.Parse(Console.ReadLine());
            Console.Write("Package cost: ");
            double package = double.Parse(Console.ReadLine());
            double total = electricity + package;
            Console.WriteLine("Other Costs: $" + total);
            return total;
        }
    }

}
 
class Program
{
    static void Main()
    {
        Console.WriteLine("===== TRON EXPRESS ANNUAL BUDGET SYSTEM =====");
        EmployeeDepartment.EmployeeCost emp = new EmployeeDepartment.EmployeeCost();
        double empCost = emp.CalculateEmployeeCost();
        CallCenterDepartment.CallCenterCost call = new CallCenterDepartment.CallCenterCost();
        double callCost = call.CalculateCallCost();
        OtherDepartment.OtherCost other = new OtherDepartment.OtherCost();
        double otherCost = other.CalculateOtherCost();
        double total = empCost + callCost + otherCost;
        Console.WriteLine("\n=========== FINAL REPORT ===========");
        Console.WriteLine("Employee Cost : $" + empCost);
        Console.WriteLine("Call Center Cost : $" + callCost);
        Console.WriteLine("Other Costs : $" + otherCost);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Total Budget : $" + total);
    }

}
 