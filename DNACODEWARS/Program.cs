using System;

namespace DNACODEWARS
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Sass";
            Accum(s);
            Console.ReadLine();
        }

        public static String Accum(string simpleString)
        {
            var newString = "";

            for (int i = 0; i < simpleString.Length; i++)
            {
                var currentString = "";
                var currentCharacter = simpleString.Substring(i, 1);

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {
                        currentString += currentCharacter.ToUpper();
                    }
                    else
                    {
                        currentString += currentCharacter.ToLower();
                    }
                }

                newString += currentString + "-";

                if (i == (simpleString.Length - 1))
                {
                    newString = newString.Remove(newString.Length - 1, 1);
                }
            }

            Console.WriteLine(newString);
            return newString;
        }
    }
}
