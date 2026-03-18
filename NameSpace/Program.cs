// using System;
// namespace Demo1{
//     class Demo
//     {
//         public void print(){
//             Console.WriteLine("First Name Space");
//         }
//     }
// }
// namespace Demo2{
//     class Demo
//     {
//         public void print(){
//             Console.WriteLine("Second Name Space");
//         }
//     }
// }
// class Name
// {
//     public static void Main()
//     {
//         Demo1.Demo obj1 = new Demo1.Demo();
//         Demo2.Demo obj2 = new Demo2.Demo();
//         obj1.print();
//         obj2.print();
//     }
// }





using System;

namespace CurrentAccount
{
    class Account
    {
        public void print()
        {
            Console.WriteLine("Current Account");
        }
        public void balance()
        {
            Console.WriteLine("Your Current Account balance is Rs.30000");
        }
    }
    
}
namespace SavingsAccount
{
    class Account
    {
        public void print()
        {
            Console.WriteLine("Savings Account");
        }
        public void balance()
        {
            Console.WriteLine("Your savings account balance is Rs.10000");
        }
    }
    
}
namespace LoanAccount
{
    class Account
    {
        public void print()
        {
            Console.WriteLine("Loan Account");
        }
        public void loan()
        {
            Console.WriteLine("You have loan balance of Rs.20000");
        }
    } 
}

class Account
{
    static void Main()
    {
        SavingsAccount.Account obj1 = new SavingsAccount.Account();
        LoanAccount.Account obj2 = new LoanAccount.Account();
        CurrentAccount.Account obj3 = new CurrentAccount.Account();
        obj1.print();
        obj2.print();
        obj3.print();
    }
}