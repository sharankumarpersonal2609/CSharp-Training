using System;

class IQTest
{
    public static void Main()
    {
        Console.WriteLine("IQ TEST");
        Console.Write("Enter number of attempts: ");
        int attempt = Convert.ToInt32(Console.ReadLine());

        if (attempt > 1)
        {
            Console.WriteLine("You have already attempted the test.");
            return;
        }
        int choice;
        int totalScore = 0;
        bool apti = false, eng = false, maths = false, gk = false;
        do
        {
            Console.WriteLine("\n1. Aptitude");
            Console.WriteLine("2. English");
            Console.WriteLine("3. Math");
            Console.WriteLine("4. GK");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    if (!apti)
                    {
                        Console.Write("Aptitude Question: 45+7 = ? ");
                        int ans = Convert.ToInt32(Console.ReadLine());
                        if (ans == 52) totalScore += 10;
                        apti = true;
                    }
                    else Console.WriteLine("Already attempted the Aptitude.");
                    break;

                case 2:
                    if (!eng)
                    {
                        Console.Write("English Question: Synonym of 'above'? (1.top 2.bottom): ");
                        int ans = Convert.ToInt32(Console.ReadLine());
                        if (ans == 1) totalScore += 10;
                        eng = true;
                    }
                    else Console.WriteLine("Already attempted English.");
                    break;

                case 3:
                    if (!maths)
                    {
                        Console.Write("Math Question: 54 * 2 = ? ");
                        int ans = Convert.ToInt32(Console.ReadLine());
                        if (ans == 108) totalScore += 10;
                        maths = true;
                    }
                    else Console.WriteLine("Already attempted Math.");
                    break;

                case 4:
                    if (!gk)
                    {
                        Console.Write("GK Question: Thirukural was written by? ");
                        string ans = Console.ReadLine()?.ToLower();
                        if (ans == "thiruvalluvar") totalScore += 10;
                        gk = true;
                    }
                    else Console.WriteLine("Already attempted GK.");
                    break;

                case 5:
                    Console.WriteLine("Exiting test...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 5);

        int bonus = 0;
        if (totalScore == 20) bonus = 2;
        else if (totalScore == 30) bonus = 5;
        else if (totalScore == 40) bonus = 10;
        int finalScore = totalScore + bonus;
        Console.WriteLine("-------- RESULT --------");
        Console.WriteLine($"Total Score (out of 40): {totalScore}");
        Console.WriteLine($"Bonus Points: {bonus}");
        Console.WriteLine($"Final Score: {finalScore}");

        if (finalScore == 0)
            Console.WriteLine("You need to re-appear the test.");
        else if (finalScore == 10)
            Console.WriteLine("Your IQ level is below average.");
        else if (finalScore == 22)
            Console.WriteLine("Your IQ level is average.");
        else if (finalScore == 35)
            Console.WriteLine("You are intelligent.");
        else if (finalScore == 40)
            Console.WriteLine("You are a genius.");
        else
            Console.WriteLine("Good performance!");
    }
}