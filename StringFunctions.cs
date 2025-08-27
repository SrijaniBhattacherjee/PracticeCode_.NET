using System;

namespace StringsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LengthOfString("Angular");
            FirstAndLastCharacter("Hello World !");
            UpperLowerAndWhitespace("  C# Programming  ");
            ReverseAString("Helloo");
        }

        public static int LengthOfString(string a)
        {
            var result = a.Length;
            Console.WriteLine("Length of the string:" + result);
            return (result);
        }

        public static void FirstAndLastCharacter(string a)
        {
            var Frst = a[0];
            var Lst = a[a.Length - 1];
            Console.WriteLine("Frst letter of the string:" + Frst);
            Console.WriteLine("Last letter of the string:" + Lst);
        }
        public static void UpperLowerAndWhitespace(string a)
        {
            var upper = a.ToUpper();
            var lower = a.ToLower();
            var whitespace = a.Trim();

            Console.WriteLine("Upper of the string:" + upper);
            Console.WriteLine("Lower of the string:" + lower);
            Console.WriteLine("Trimmed string:" + whitespace);
        }
        public static void substring(string a)
        {
            var substring = a.Contains("C#");
            var res = a.Substring(7, 2);
            Console.WriteLine("Whether C# is present or not :" + substring);
            Console.WriteLine("substring value is :" + res);
        }

        public static void ReverseAString(string a)
        {

            var res = a.ToCharArray();
            char[] res1 = new char[res.Length];

            for (int i = 0; i <= res.Length - 1; i++)
            {
                res1[i] = res[res.Length - 1 - i];
                //res[res.Length - 1 - i] = res1[i];

            }

            Console.WriteLine(res1);
        }

    }
}
