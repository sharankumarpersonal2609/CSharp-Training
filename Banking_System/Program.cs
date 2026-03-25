using System;

class Bank
{
    public static void Main()
    {
        Console.Write("Enter the total number of accounts: ");
        int count = Convert.ToInt32(Console.ReadLine());
        double[] balance = new double[count];
        string[] names = new string[count];
        for(int i = 0; i < count; i++)
        {
            Console.Write("Enter the name: ");
            names[i]=Console.ReadLine();
            Console.Write("Enter the amount: ");
            balance[i] = Convert.ToDouble(Console.ReadLine());
        }
        double tot =0, highest=0;
        foreach(int num in balance)
        {
            tot+=num;
            if(num>highest)
            highest=num;
        }
        Console.WriteLine("The total bank balance is: "+tot);
        Console.WriteLine("The highest bank balance is: "+highest);

    }
}







