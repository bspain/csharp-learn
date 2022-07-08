using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.Strings
{
    public class RotationChecker
    {
        /* Question 1.8: Assume you have a method isSubstring which checks if one word is a
         * substring of another.  Given two strings, s1 and s2, write code to check if s2 is a 
         * rotation of s1 using only one call to isSubstring (e.g. 'waterbottle' is a rotation of
         * 'erbottlewat'
         * */

        public static bool IsRotationWithOneSubstringCall(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // s1.isSubstring(s2) is handled by s2E.contains(s1);
            string s2Ex = s2 + s2;
            return s2Ex.Contains(s1);
        }
    }
}
