using System.Diagnostics;
using System.Reflection.Metadata;

namespace Char_and_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //1.ValidatePassword(string password) - methodunuz olur, parameter olaraq qebul etdiyi stringin uzunlugu minimum
            //8, böyük hərflə başlamalı, tərkibində minimum 1 rəqəm olmalı və minimum 1 karakter
            //    (hərf və ya rəqəm olmayan: misal ?, !, @) olmalıdır.Bu hallar ödənirsə true, ödənmirsə false qaytarmalıdır.

            Console.WriteLine("Parol daxil edin: ");

            string password = Console.ReadLine();
            bool check = ValidatePassword(password);

            Console.WriteLine(check);
            #endregion

            Console.WriteLine("=====================================");

            //2.String`in Replace(), Substring(),Trim() methodlarını custom şəkildə yazmaq.
            //Yəni sizin custom yazdığınız methodlarla stringin methodları eyni işi görməlidir.


            string text = "   Hello world";
            Console.WriteLine(CustomReplace(text,"world","ravan"));
            Console.WriteLine(CustomSubstring(text, 3, 5));
            Console.WriteLine(CustomTrim(text));
        }

        static string CustomReplace(string input, string replace, string newValue)
        {
            string result = "";
            int i = 0;

            while (i <= input.Length - replace.Length)
            {
                if (input.Substring(i, replace.Length) == replace)
                {
                    result += newValue;
                    i += replace.Length;
                }
                else
                {
                    result += input[i];
                    i++;
                }
            }
            result += input.Substring(i);
            return result;
        }

        static string CustomSubstring (string input,int replace , int newValue)
        {
            string result = "";

            for (int i = 0; i< newValue; i++)
            {
                result += input[replace + i];
            }
            return result;
        }

        static string CustomTrim (string input)
        {
            return input.Trim();
        }
       

        #region Task1 
        static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            if (char.IsUpper(password[0]))
            {
                return true;
            }

            bool isDigit = false;
            foreach (char chr in password)
            {
                if (char.IsDigit(chr))
                {
                    isDigit = true;
                    break;
                }
            }
            return isDigit = false;

            bool isLetterOrDigit = false;   

            foreach (char chr in password)
            {
                if (char.IsLetterOrDigit(chr))
                {
                    isLetterOrDigit = true;
                    break;
                }
            }
            return isLetterOrDigit = false;

            return  true;  
        }

        #endregion

    }
}
