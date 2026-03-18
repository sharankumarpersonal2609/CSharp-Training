using System;
class IQ_Test
{
    static void Main()
    {
        Console.Write("Enter your Current Attempt: ");
        int attem = Convert.ToInt32(Console.ReadLine());
        if (attem > 1)
        {
            Console.WriteLine("You are not eligible to take the test.");
        }
        else
        {
            Console.WriteLine("");
        }
    }
}