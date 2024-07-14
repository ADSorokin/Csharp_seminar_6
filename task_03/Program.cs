using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Введите строку полиндром: ");
        string polindromStr =ReadStr(); 
          
        if (IsPalindromeString(polindromStr))
            Console.WriteLine("Строка " + polindromStr + " - палиндром!");
        else
            Console.WriteLine("Строка " + polindromStr + " - не палиндром!");
      
    }
    static string ReadStr(){
        string? str = Console.ReadLine();
        str = str.Replace(" ", "").ToLower();
    return str;
    }
    static bool IsPalindromeString(string str)
    {
        
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1]) return false;     
        }
    return true;
    }
}
