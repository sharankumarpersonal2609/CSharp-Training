using System;
using System.Security.Cryptography;
class Boolean
{
    static public void Main()
    {
        // Boolean datatype Practice

        // bool boolean = false;
        // if (boolean)
        // {
        //     Console.WriteLine("Hi from C Sharp");
        // }
        // else
        // {
        //     Console.WriteLine("None");
        // }


        // keep the number of months as a constant print the number of months

        // const int months = 12;
        // Console.WriteLine(months);





        // Convert Smaller datatype to larger datatype

        // double a = 10.097;
        // int f =(int)a;
        // Console.WriteLine(f);


        // String str ="123";
        // int a = Convert.ToInt32(str);
        // Console.WriteLine(a);
        // Console.ReadLine();

        String day = Console.ReadLine();
        if(day=="Saturday" || day == "Sunday")
        {
            Console.WriteLine("It's a weekend");
        }
        else
        {
            Console.WriteLine("No it is not");
        }
    }
}