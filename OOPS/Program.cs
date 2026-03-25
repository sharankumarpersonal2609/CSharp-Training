// using System;
// using System.Reflection.Metadata;
// using System.Runtime.InteropServices;
// class Vehicle
// {
//     public string type;
//     private string color;
//     public int year;
//     public Vehicle()
//     {
//         type = "Two Wheeler";
//         color = "Black";
//         year = 1980;
//     }
//     public Vehicle(string type, string color, int year)
//     {
//         this.type = type;
//         this.color = color;
//         this.year = year;
//     }

//     ~Vehicle()
//     {
//         Console.WriteLine("Objected Deleted Successfully....");
//     }
//     public void print()
//     {
//         Console.WriteLine(color);
//     }
//     protected void show()
//     {
//         Console.WriteLine("This is for bus...");
//     }
//     internal void showed()
//     {
//         Console.WriteLine("This is for internal...");
//     }
// }

// class Bus : Vehicle
// {
//     public void display(){
//         show();
//         showed();
//     }
// }

// class Program{
//     static void Main()
//     {
//         Vehicle bike = new Vehicle();
//         Vehicle car = new Vehicle("Four Wheeler","Red", 1995);
//         Console.WriteLine(bike.type);
//         // Console.WriteLine(bike.color);
//         bike.print();
//         Bus bus = new Bus();
//         bus.display();

//     }
// }



// class User
// {
//     public string role="";
//     public string name="", password="";

//     public static int quantity;
//     public static string prod="";

//     public void print()
//     {
//         Console.WriteLine("Product: "+prod+" Quanitity: "+quantity);
//     }

// }

// class Customer : User
// {
//     public Customer(string naam, string pass)
//     {
//         role = "User";
//         name = naam;
//         password=pass;
//     } 
//     public string order(string product, int quant)
//     {
//         if (quantity < quant)
//         {
//             Console.WriteLine("Role: "+role+" Name: "+name);
//             return "Not available";
//         }
//         Console.WriteLine("Role: "+role+" Name: "+name);
//         quantity-=quant;
//         return "Order Success..";
//     } 
// }

// class Admin : User
// {
//     public Admin(string naam, string pass)
//     {
//         role = "Admin";
//         name = naam;
//         password = pass;
//     } 
//     public string manage(string product, int quant)
//     {
//         prod = product;
//         quantity+=quant;
//         Console.WriteLine("Role: "+role+" Name: "+name);
//         return "Added the product...";
//     } 
// }
// class DuplicateCustomer : Customer
// {
//     public void display()
//     {
//         print();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Customer customer = new Customer("User1","Password");
//         Admin admin = new Admin("Admin1","AdPassword");
//         Console.WriteLine(admin.manage("Pen", 10));
//         Console.WriteLine(customer.order("Pen", 5));
//         admin.print();
//     }
// }


class Animal
{
    public void eat()
    {
        Console.WriteLine("Non-Vegeterian..");
    }
}
class Dog : Animal
{
    public void sound()
    {
        Console.WriteLine("Bark");
    }
    public void sound(string sd)
    {
        Console.WriteLine(sd);
    }
}
class Cat : Animal
{
    public void sound()
    {
        Console.WriteLine("Meow");
    }
}
class Program
{
    public static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        cat.sound();
        cat.eat();
        dog.sound();
        dog.sound("lol");
        dog.eat();
    }
}





   