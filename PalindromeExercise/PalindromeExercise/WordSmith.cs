using System;
using System.Linq;
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

            //DIFF OPTION
            //var reversed = "";
            //for (var i = str.Length - 1; i >=0; i--)
            //{
            //    reversed += str.ToLower()[i];
            //}
            //if(reversed == str.ToLower())
            //{
            //    return true;
            //}
            //return false;

            //REFACTOR PREVIOUS
            //return reversed == str.ToLower();

            //LINQ
            //return str.ToLower().SequenceEqual(str.ToLower().Reverse());

            //LINQ SENTENCES OPTION
            //return str.Replace(" ", "").ToLower().SequenceEqual(str.Replace(" ", "").ToLower().Reverse());
        }
    }
}

