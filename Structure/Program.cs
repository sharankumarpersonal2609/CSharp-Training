// using System.Runtime.Serialization;

// struct Student
// {
//     public int Id;
//     public string Name;
//     public int mark;

//     public void show()
//     {
//         Console.WriteLine("Student ID = "+Id);
//         Console.WriteLine("Student Name = "+Name);
//         Console.WriteLine("Student mark = "+mark);
//     }

//     public char grade()
//     {
//         if (mark >= 90)
//         {
//             return 'O';
//         }
//         else if(mark >= 70)
//         {
//             return 'A';
//         }
//         else if(mark >= 60)
//         {
//             return 'B';
//         }
//         else if(mark >= 40)
//         {
//             return 'C';
//         }
//         return 'U';

//     }
// }

// class Function
// {
//     static void Main()
//     {
//         Student s1;
//         s1.Id=001;
//         s1.Name="ABCD";
//         s1.mark=98;

//         s1.show();

//         Console.WriteLine("Student Grade is - "+s1.grade());
//     }
// } 



using System.Collections.Generic;
using System.Collections;
// public class Holiday
// {
//     public enum Weekdays
//     {
//         Monday,
//         Tuesday,
//         Wednesday,
//         Thursday,
//         Friday
//     }

//     public void weekdays(string name , Weekdays day)
//     {
//         Console.WriteLine(day);
//     }

//     static void Main()
//     {
//         Holiday holi = new Holiday();
//         holi.weekdays("Anyone", Holiday.Weekdays.Monday);
//     }
// }


// string[] items = {"abf","kdf","kbwf"};
// IEnumerator e = items.GetEnumerator();

// while (e.MoveNext())
// {
//     Console.WriteLine(e.Current);
// }



// using System;
// class Program
// {
//     static void Main()
//     {
//         int[,] arr = new int[4,5];
//         int num = 0;
//         for(int i = 0; i < 4; i++)
//         {
//             for(int j = 0; j < 5; j++)
//             {
//                 arr[i,j] = num;
//                 num++;
//             }
//         }
//         for(int i = 0; i < 4; i++)
//         {
//             for(int j = 0; j < 5; j++)
//             {
//                 Console.Write(arr[i,j]+" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }




// using System;
// class Program
// {
//     static void Main()
//     {
//         int[,] marks = new int[3,3];
//         for(int i = 0; i < 3; i++)
//         {
//             for(int j = 0; j < 3; j++)
//             {
//                 Console.Write("Enter the Student{0}'s subject{1} mark: ",i+1,j+1);
//                 marks[i,j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         for(int i = 0; i < 3; i++)
//         {
//             int sum=0;
//             double avg;
//             for(int j = 0; j < 3; j++)
//             {
//                 sum+=marks[i,j];
//             }
//             avg = sum/3.0;
//             Console.WriteLine();
//             Console.WriteLine("Student{0}'s Total marks is: {1}",i+1,sum);
//             Console.WriteLine("Student{0}'s Average marks is: {1}",i+1,avg);
//             Console.WriteLine();
//         }     
//     }
// }




//JAGGED ARRAY

using System;
class Program
{
    static void Main()
    {
        int[][] arr = new int[2][];
        arr[0]=new int[]{2,3,4,5,6};
        arr[1]=new int[]{2,3,4,5,6,7,8,9};
        for(int i = 0; i < 2; i++)
        {
            for(int j=0;j<arr[i].Length;j++)
            Console.Write(arr[i][j]);

            Console.WriteLine();
        }


    }
}