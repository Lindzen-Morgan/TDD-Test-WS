using System;

namespace WordLib
{
    public class WordChecker
    {
        public static bool IsPalindrome(string word)
        {
            // Check if the word is a palindrome
            string reversed = new string(word.Reverse().ToArray());
            return word == reversed;
        }

    }
}
