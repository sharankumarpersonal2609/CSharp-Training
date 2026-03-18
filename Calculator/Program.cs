using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter the First number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Select the Operation you want to do:\n+\n-\n*\n/");
        char ch = Convert.ToChar(Console.ReadLine());
        switch (ch)
        {
            case '+':
                int ans = num1+num2;
                Console.WriteLine(ans);
                break;
            case '-':
                int ans2 = num1-num2;
                Console.WriteLine(ans2);
                break;
            case '*':
                int ans3 = num1*num2;
                Console.WriteLine(ans3);
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by 0");
                    break;
                }
                int ans4 = num1/num2;
                Console.WriteLine(ans4);
                break;
            default:
                Console.WriteLine("Invalid Option..");
                break;

        }
    }
}