using System;
class Sample {
    static public void Main()
    {
        Console.Write("Enter the digit: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {

            Console.WriteLine("It a even number");
        }
        else
        {
            Console.WriteLine("It's an odd number");
        }
       

    }

}
