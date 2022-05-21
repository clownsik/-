using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public static class PasswordChecker
    {
        public static int GetPasswordStrenght(string passsword)
        {
            int result = 0;

            if (Math.Max(passsword.Length, 7)>7)
            {
                result++;
            }

            
            return result;
        }
        public static int GetPasswordLower(string passsword)
        {
            int result = 0;
            foreach (char c in passsword)
            {
                if ("qwertyuiopasdfghjklzxcvbnm".Contains(c))
                {
                    result++;
                    break;
                }
            }
            return result;
        }

        public static int GetPasswordUpper(string passsword)
        {
            int result = 0;
            foreach (char c in passsword)
            {
                if ("QWERTYUIOPASDFGHJKLZXCVBNM".Contains(c))
                {
                    result++;
                    break;
                }
            }
            return result;
        }

        public static int GetPasswordNumber(string passsword)
        {
            int result = 0;
            foreach (char c in passsword)
            {
                if (Char.IsDigit(c))
                {
                    result++;
                    break;
                }
            }
            return result;
        }

        public static int GetPasswordSpecial(string passsword)
        {
            int result = 0;
            foreach (char c in passsword)
            {
                if ("!@#%&*$?/~".Contains(c))
                {
                    result++;
                    break;
                }
            }
            return result;
        }      
    }
}
