using System;


class Program
{
    static void Main()
    {
   
        char[,] Array = {
            { 'П', 'р', 'и', 'в', 'е' },
            { 'т', ' ', 'М', 'и', 'р' },
            { ' ', '!', ' ', ' ', ' ' }
        };
        
        string resultString = ArrayToString(Array);
        Console.WriteLine(resultString);
    }

    static string ArrayToString(char[,] Array)
    {
       string Result ="";
              
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Result+=Array[i, j];
            }
        }
        
        return Result;
    }
}
