using System;
class TRON
{
    static void Main()
    {
        Console.WriteLine("Enter the number of pacakages that employee: ");
        int pack = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of days that the employee worked: ");
        int days = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your shift day/night");
        string shift = Console.ReadLine()??"day";
        double salary = pack * 50;
        salary = salary + (days*75);
        if(shift == "night")
        {
            salary = (salary*0.10) + salary;
        }
        int tax = 2;
        salary = (salary*0.02) - salary;
        
    }
}