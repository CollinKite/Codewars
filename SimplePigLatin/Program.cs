using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace SimplePigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Hello World !"));
        }

        public static string PigIt(string str)
        {
            try
            {
                string[] words = str.Split(" ");
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length == 1)
                    {
                        if (Regex.IsMatch(words[i], "^[a-zA-Z]$"))
                        {
                            words[i] = str + "ay";
                        }
                    }
                    else
                    {
                        char lastLetter = words[i].Last();
                        char letter = words[i][0];
                        if (Regex.IsMatch(lastLetter.ToString(), "^[a-zA-Z]$"))
                            words[i] = words[i].Substring(1) + letter + "ay";
                        else
                        {
                            words[i] = words[i].Substring(1, words[i].Length - 2) + letter + "ay" + lastLetter;
                        }
                    }
                }
                return String.Join(" ", words);
            }
            catch( Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}