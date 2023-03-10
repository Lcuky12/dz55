using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int characterCount = 1;
            char userInputySbool;
            string numberLines;
            string characters = "";

            Console.Write(" Введите имя ");
            userName = Console.ReadLine();
            Console.Write(" Введите символ ");
            userInputySbool = Convert.ToChar(Console.Read());

            numberLines = userInputySbool + userName + userInputySbool;

            for (int i = 0; i <= userName.Length + characterCount; i++)
            {
                characters += userInputySbool;
            }

            Console.WriteLine(characters);
            Console.WriteLine(numberLines);
            Console.WriteLine(characters);
        }    
    }
}