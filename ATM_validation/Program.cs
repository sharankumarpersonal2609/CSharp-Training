using System;
 
class Program
{
    static void Main(string[] args)
    {
        string name = "";
        int age = 0;
        string address = "";
 
        double balance = 0;
        int transactions = 0;
 
        int choice;
        do
        {
            Console.WriteLine("\n MAIN MENU ");
            Console.WriteLine("1. open Account");
            Console.WriteLine("2. account (Perform Transactions)");
            Console.WriteLine("3. quit (Exit)");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
 
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
 
                    Console.Write("Enter Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
 
                    Console.Write("Enter Address: ");
                    address = Console.ReadLine();
 
                    Console.Write("Enter Initial Balance: ");
                    balance = Convert.ToDouble(Console.ReadLine());
 
                    Console.WriteLine("Account Created Successfully!");
                    break;
 
                case 2:
                    if (name == "")
                    {
                        Console.WriteLine("Please open an account first!");
                        break;
                    }
 
                    string option;
                    do
                    {
                        Console.WriteLine("\n TRANSACTION MENU ");
                        Console.WriteLine("deposit");
                        Console.WriteLine("withdraw");
                        Console.WriteLine("show");
                        Console.WriteLine("changename");
                        Console.WriteLine("quit");
                        Console.Write("Enter option: ");
                        option = Console.ReadLine().ToLower();
 
                        switch (option)
                        {
                            case "deposit":
                                Console.Write("Enter amount to deposit: ");
                                double depositAmount = Convert.ToDouble(Console.ReadLine());
 
                                balance += depositAmount;
                                transactions++;
 
                                Console.WriteLine("Deposited Successfully!");
                                break;
 
                            case "withdraw":
                                Console.Write("Enter amount to withdraw: ");
                                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
 
                                if (withdrawAmount <= balance)
                                {
                                    balance -= withdrawAmount;
                                    transactions++;
                                    Console.WriteLine("Withdrawal Successful!");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Balance!");
                                }
                                break;
 
                            case "changename":
                                Console.Write("Enter new name: ");
                                name = Console.ReadLine();
                                Console.WriteLine("Name Updated!");
                                break;
 
                            case "show":
                                Console.WriteLine("\n ACCOUNT DETAILS ");
                                Console.WriteLine("Name: " + name);
                                Console.WriteLine("Balance: ₹" + balance);
                                Console.WriteLine("Transactions: " + transactions);
                                break;
 
                            case "quit":
                                Console.WriteLine("Exiting Transaction Menu...");
                                break;
 
                            default:
                                Console.WriteLine("Invalid Option");
                                break;
                        }
 
                    } while (option != "quit");
 
                    break;
 
                case 3:
                    Console.WriteLine("Exiting Application...");
                    break;
 
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
 
        } while (choice != 3);
    }
}
 