using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            string answer = new string(array);
            if (str == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
