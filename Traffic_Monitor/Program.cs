// using System;

// class Program
// {
//     static void Main()
//     {
//         string[] places = { "Downtown", "Highway", "Suburb" };
//         string[,] downtown = {
//             {"08AM", "120", "45", "40", "30"},
//             {"09AM", "150", "35", "55", "40"},
//             {"10AM", "180", "25", "65", "50"},
//             {"11AM", "200", "18", "75", "60"},
//             {"12PM", "220", "15", "80", "70"}};
//         string[,] highway = {
//             {"08AM", "300", "60", "30", "20"},
//             {"09AM", "320", "55", "35", "25"},
//             {"10AM", "350", "45", "40", "30"},
//             {"11AM", "370", "38", "50", "35"},
//             {"12PM", "400", "30", "60", "40"}};

//         string[,] suburb = {
//             {"08AM", "80", "50", "35", "15"},
//             {"09AM", "90", "45", "40", "20"},
//             {"10AM", "100", "42", "45", "25"},
//             {"11AM", "110", "35", "55", "30"},
//             {"12PM", "120", "28", "60", "35"}};

//         Console.WriteLine("---- TRAFFIC ANALYSIS ----");

//         AnalyzeTraffic(places[0], downtown);
//         AnalyzeTraffic(places[1], highway);
//         AnalyzeTraffic(places[2], suburb);

//         Console.WriteLine("\n---- ACCIDENT RECORDS ----");

//         string[][] accidents = new string[3][];

//         accidents[0] = new string[] {
//             "2020 - Minor - 2 Vehicles - Police",
//             "2021 - Major - 3 Vehicles - Ambulance",
//             "2022 - Minor - 1 Vehicle - None"  
//         };

//         accidents[1] = new string[] {
//             "2019 - Major - 5 Vehicles - Ambulance",
//             "2021 - Minor - 2 Vehicles - Police"
//         };

//         accidents[2] = new string[] {
//             "2018 - Minor - 1 Vehicle - None",
//             "2020 - Minor - 2 Vehicles - Police",
//             "2023 - Major - 4 Vehicles - Ambulance",
//             "2024 - Minor - 1 Vehicle - None"
//         };


//         for (int i = 0; i < accidents.Length; i++)
//         {
//             Console.WriteLine("\n" + places[i] + " Accidents:");

//             for (int j = 0; j < accidents[i].Length; j++)
//             {
//                 Console.WriteLine(accidents[i][j]);
//             }
//         }
//     }

//     static void AnalyzeTraffic(string place, string[,] data)
//     {
//         int heavy = 0,smooth=0, moderate=0;
//         for (int i = 0; i < data.GetLength(0); i++)
//         {
//             int speed = Convert.ToInt32(data[i, 2]);
//             int density = Convert.ToInt32(data[i, 3]);

//             if (speed > 40 && density < 50)
//             {
//                 smooth++;
//             }
//             else if (speed >= 20 && speed <= 40)
//             {
//                 moderate++;
//             }
//             else if (speed < 20 || density > 70)
//             {
//                 heavy++;
//             }
//         }
//         Console.WriteLine();
//         if (heavy >= 2)
//             Console.WriteLine(place + " has HEAVY TRAFFIC overall");
//         else if(heavy==1)
//             Console.WriteLine(place + " traffic is managable");
//         else
//             Console.WriteLine(place + " No traffic");
//     }
// }




class Employee
{
    public int Id;
    public string name;
    public string qualification;

    public Employee()
    {
        qualification = "B.E";
    }
}
class Program
{
    public static void Main(){
        Employee emp = new Employee();
        Console.WriteLine(emp.qualification);
    }
}