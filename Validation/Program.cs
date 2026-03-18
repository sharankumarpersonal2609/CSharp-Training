using System;
class Validation
{
    static public void Main(){
        // string uname = "User1";
        // string upassword = "User1Password";

        // Console.Write("Enter the User Name: ");
        // string name = Console.ReadLine()??"";
        // Console.Write("Enter the Password: ");
        // string password = Console.ReadLine()?? "";

        // if(uname==name && password == upassword)
        // {
        //     Console.WriteLine("Succesully Loged in...");
        // }
        // else if (uname==name)
        // {
        //     Console.WriteLine("Invalid Password");
        // }
        // else if(password == upassword)
        // {
        //     Console.WriteLine("Invalid UserName");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid UserName and Password");
        // }

        // string uname = "user1";
        // string upassword = "password";
        // Console.Write("Enter the UserName: ");
        // string name = Console.ReadLine()??"";
        // if (uname == name)
        // {
        //     Console.Write("Enter the Password: ");
        //     string password = Console.ReadLine()??"";
        //     if (password == upassword)
        //     {
        //         Console.WriteLine("Login success..");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid Password..");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Invalid UserName..");
        // }


        Console.WriteLine("Enter the Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }

    }
}