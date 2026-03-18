using System;
class Super_Market
{
    static void Main()
    {
        bool choice = true;
        int bill = 0;
        while (choice)
        {
            int ans = 0;
            Console.WriteLine();
            Console.WriteLine("1. Rice - Rs. 10");
            Console.WriteLine("2. Wheat - Rs. 32");
            Console.WriteLine("3. Sugar - Rs. 54");
            Console.WriteLine("4. Chocolate - Rs. 12");
            Console.WriteLine("5. Chips - Rs. 42");
            Console.WriteLine("6. Tea Power - Rs. 56");
            Console.WriteLine("7. Coffee Powder - Rs. 67");
            Console.WriteLine("8. To Exit \n");
            Console.Write("Select the Product: ");
            int prod = Convert.ToInt32(Console.ReadLine());
            if(prod == 8)
            break;
            Console.Write("Enter the quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (prod)
            {
                case 1:
                    ans = 10*quantity;
                    bill+=ans;
                    break;
                case 2:
                    ans = 32*quantity;
                    bill+=ans;
                    break;
                case 3:
                    ans = 54*quantity;
                    bill+=ans;
                    break;
                case 4:
                    ans = 12*quantity;
                    bill+=ans;
                    break;
                case 5:
                    ans = 42*quantity;
                    bill+=ans;
                    break;
                case 6:
                    ans = 56*quantity;
                    bill+=ans;
                    break;
                case 7:
                    ans = 67*quantity;
                    bill+=ans;
                    break;
                default:
                    Console.WriteLine("Invalid Option...");
                    break;
            }
            Console.WriteLine("Your Current Total is Rs.{0}", bill);


        }
        Console.WriteLine("Your Total bill amount is Rs.{0}", bill);
    }
}
// You are building a super market billing system
// Customers should be able to 
//     1.Select items
//     2.Enter quantity
//     3.Get total bill
//     4.Continue shopping until they choose to stop.

// Requirements:
// Show menu(any items)
// Show menu using while loop
// Take user choice
// Use switch case to select item
// Ask quantity
// calculate price using if/logic
// add to total bill
// display final bill when user exits
 
 