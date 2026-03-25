// using System;
// using System.Globalization;
// class Mark
// {
//     public static void Main()
//     {
//         Console.Write("Enter the total number of Subject: ");
//         int count = Convert.ToInt32(Console.ReadLine());
//         int[] marks = new int[count];
//         char[] grade = new char[count];
//         for(int j = 0; j < count; j++)
//         {
//             Console.WriteLine("Enter the Subject{0}'s mark: ");
//             marks[j] = Convert.ToInt32(Console.ReadLine());
//         }
//         int tot=0, avg=0, highest=marks[0], lowest=marks[0], pass=0;

//         int i=0;
//         foreach(int num in marks)
//         {
//             if (num < lowest)
//             {
//                 lowest=num;
//             }
//             if (num > highest)
//             {
//                 highest = num;
//             }
//             if (num > 40)
//             {
//                 pass++;
//             }

//             if (num < 40)
//             {
//                 grade[i] = 'U';
//             }
//             else if (num < 60)
//             {
//                 grade[i] = 'C';
//             }
//             else if (num < 70)
//             {
//                 grade[i] = 'B';
//             }
//             else if (num < 80)
//             {
//                 grade[i] = 'A';
//             }
//             else
//             {
//                 grade[i]='O';
//             }
//             i++;
//             tot+=num;
//         }
//         avg = tot/count;

//         for(int j=0;j<count;j++)
//         Console.WriteLine("Mark: {0}, Grade: {1}", marks[j],grade[j]);
//         Console.WriteLine("The total marks of student is: "+ tot);
//         Console.WriteLine("The average marks of student is: "+avg);
//         Console.WriteLine("The highest marks of student is: "+ highest);
//         Console.WriteLine("The lowest marks of student is: "+ lowest);
//         Console.WriteLine("The total number of passed student is: "+ pass);

//     }
// }










using System;
 
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("-----------STUDENT MARKS SYSTEM------------");
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] names = new string[n];
        int[] marks = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter name of student {i + 1}: ");
            names[i] = Console.ReadLine();
            Console.Write($"Enter marks of {names[i]}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        int total = 0;
        int highest = marks[0];
        int lowest = marks[0];
        int average = 0;
        int passMarks = 40;
        int passCount = 0;
        string highestName = names[0];
        string lowestName = names[0];
        for (int i = 0; i < n; i++)
        {
            total += marks[i];
            if (marks[i] > highest)
            {
                highest = marks[i];
                highestName = names[i];
            }
            if (marks[i] < lowest)
            {
                lowest = marks[i];
                lowestName = names[i];
            }
            if (marks[i] >= passMarks)
            {
                passCount++;
            }
        }
        average = total / n;
        Console.WriteLine($"\nTotal Marks: {total}");
        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine($"Highest Marks: {highest} by {highestName}");
        Console.WriteLine($"Lowest Marks: {lowest} by {lowestName}");
        Console.WriteLine($"Number of students passed: {passCount}");
        Console.WriteLine("\nGrades:");
        for (int i = 0; i < n; i++)
        {
            string grade;
            if (marks[i] >= 90)
            {
                grade = "O";
            }
            else if (marks[i] >= 80)
            {
                grade = "A+";
            }
            else if (marks[i] >= 70)
            {
                grade = "A";
            }
            else if (marks[i] >= 60)
            {
                grade = "B+";
            }
            else if (marks[i] >= passMarks)
            {
                grade = "B";
            }
            else
            {
                grade = "U";
            }
            Console.WriteLine($"{names[i]}: {grade}");
        }
        Console.WriteLine("\nMarks in Ascending Order:");
        Array.Sort(marks);
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }
        Console.WriteLine("\nMarks in decesnding Order:");
        Array.Reverse(marks);
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }
        Console.Write("\nEnter a mark to find its position: ");
        int markToFind = Convert.ToInt32(Console.ReadLine());
        int position = Array.IndexOf(marks, markToFind);
        if (position != -1)
        {
            Console.WriteLine($"Mark {markToFind} is found at position {position}");
        }
        else
        {
            Console.WriteLine($"Mark {markToFind} is not found.");
        }
        bool hasFailed = Array.Exists(marks, mark => mark < 35);
        if (hasFailed)
        {
            Console.WriteLine("There are students who scored below 35.");
        }
        else
        {
            Console.WriteLine("No student scored below 35.");
        }
 
        Console.WriteLine("\nMarks greater than or equal to 35:");
        int[] passingMarks = Array.FindAll(marks, mark => mark >= 35);
        foreach (int mark in passingMarks)
        {
            Console.WriteLine(mark);
        }
    }
 
}