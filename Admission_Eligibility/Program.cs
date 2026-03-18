using System;
class Admission
{
    static public void Main()
    {
        Console.Write("Enter the marks: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter true if you are from sportsquota else false: ");
        bool sportsquota = Convert.ToBoolean(Console.ReadLine());
        if (mark > 85 || sportsquota)
        {
            Console.WriteLine("Eligible for scolarship");
        }
        else
        {
            Console.WriteLine("Not eligible for scholarship");
        }
    }
}