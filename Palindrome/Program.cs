using System;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg} -> {IsPalindrome(arg)}");
            }
        }

        private static bool IsPalindrome(string s)
        {
            bool _IsPalindrome(string s)
            {
                if (s.Length <= 1)
                {
                    return true;
                }

                return s[0] == s[s.Length - 1]
                    && _IsPalindrome(s.Substring(1, s.Length - 2));
            }

            if (s == null)
            {
                throw new ArgumentNullException("s");
            }

            if (s.Length < 2)
            {
                return true;
            }

            return _IsPalindrome(s);
        }
    }
}
