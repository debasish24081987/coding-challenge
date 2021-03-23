using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string : ");
            string text = Console.ReadLine();
            Console.Write("Reverse String : ");
            Console.WriteLine(Reverse(text));
        }

        public static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }

            var myArr = s.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }
    }
}
