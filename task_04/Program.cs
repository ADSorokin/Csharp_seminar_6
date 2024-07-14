using System;
using System.Security.Claims;
using System.Text;
using System.Text.Unicode;


class Program
{
    static void Main(){

        Console.Write("Введите предложение на англиском языке: ");
        string mySentence = ReadStr();
        string strResult = ReverseSentence(mySentence);
        Console.WriteLine("Исходное предложение: " + mySentence);
        Console.WriteLine("Результат: " + strResult);
    }

    
    static string ReadStr(){
        string? str = Console.ReadLine()!;
    return str;
    }

    static string ReverseSentence(string str){

        string[] newStr = str.Split(' ');
        Array.Reverse(newStr);
        return string.Join(" ", newStr);
    }
}
