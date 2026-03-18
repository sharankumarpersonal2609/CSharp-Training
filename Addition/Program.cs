using System;
class Addition
{
    static public void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int add = a+b+c;
        Console.WriteLine("The addition of thee numbers is "+add);
    }
}