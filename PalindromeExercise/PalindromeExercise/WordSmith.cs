using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            //throw new NotImplementedException();

            char[] c = str.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(str);
        }
    }
}

