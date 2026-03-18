using System;
class ATM_Validation
{
    static public void Main()
    {
        // int pin = 4321;
        // int count =0;
        // while(count <3){
        //     Console.Write("Enter your PIN: ");
        //     int upin = Convert.ToInt32(Console.ReadLine());
        //     if (pin == upin)
        //     {
        //         while(count<3)
        //         Console.WriteLine("Press 1 to Withdraw");
        //         Console.WriteLine("Press 2 to Check balance");
        //         Console.WriteLine("Press 3 to deposit");
        //         Console.WriteLine("Press 4 to cancel");
        //         Console.WriteLine();
        //         Console.WriteLine("Enter the option: ");
        //         int option = Convert.ToInt32(Console.ReadLine());
        //         if(option == 1)
        //         {
        //             Console.WriteLine("Withdraw Successful...");
        //         }
        //         else if(option == 2)
        //         {
        //             Console.WriteLine("Your balance is ₹10000");
        //         }
        //         else if (option == 3)
        //         {
        //             Console.WriteLine("Deposit Successful..");
        //         }
        //         else if (option == 4)
        //         {
        //             Console.WriteLine("Exited..");
        //         }
        //         else
        //         {
        //             Console.WriteLine("Invalid option, Exited...");
        //         }

        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid PIN number..");
        //         count+=1;
        //         if (count == 3)
        //         {
        //             Console.WriteLine("Account Locked...");
        //         }
        //     }
        // }
        int pin = 4321;
        Console.Write("Enter your PIN number: ");
        int upin = Convert.ToInt32(Console.ReadLine());
        if(pin == upin)
        {
            Console.WriteLine("Press 1 to Withdraw");
            Console.WriteLine("Press 2 to Check balance");
            Console.WriteLine("Press 3 to deposit");
            Console.WriteLine("Press 4 to cancel");
            Console.WriteLine();
            Console.WriteLine("Enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Withdraw Successful...");
                    break;
                case 2:
                    Console.WriteLine("Your balance is Rs.10000");
                    break;
                case 3:
                    Console.WriteLine("Deposit Successful...");
                    break;
                case 4:
                    Console.WriteLine("Exited...");
                    break;
                default:
                    Console.WriteLine("Invalid Option..");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid PIN number..");
        }
        

    }
}