using System;
class Avalanche
{
    static void Main()
    {
        string[,] Sun_valley = {{"01", "10AM", "30", "60", "15", "180"},
                            {"02", "11AM", "28", "65", "20", "200"},
                            {"03", "12PM", "25", "70", "25", "220"},
                            {"04", "01PM", "20", "75", "30", "250"},
                            {"05", "02PM", "18", "80", "35", "270"}};

        string[,] panhandle = {{"01", "10AM", "35", "55", "10", "150"},
                            {"02", "11AM", "33", "58", "12", "170"},
                            {"03", "12PM", "32", "60", "15", "190"},
                            {"04", "01PM", "30", "62", "18", "210"},
                            {"05", "02PM", "28", "65", "20", "230"}};

        string[,] mcCall = {{"01", "10AM", "22", "75", "30", "260"},
                            {"02", "11AM", "20", "78", "35", "270"},
                            {"03", "12PM", "18", "80", "40", "280"},
                            {"04", "01PM", "15", "82", "45", "290"},
                            {"05", "02PM", "12", "85", "50", "300"}};


        check(Sun_valley);
    }

    public static void check(string[,] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            int temp = Convert.ToInt32(arr[i,2]);
            int humidity = Convert.ToInt32(arr[i,3]);
            int windSpeed = Convert.ToInt32(arr[i,5]);

            if(temp>25 && humidity<70 && windSpeed < 70)
            {
                
            }
        }
    }
}