using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrengthCheckApp
{
    internal class PasswordStrengthCheck
    {
        public int PasswordStrength(string password)
        {
            int count = 0;
            if (LengthCheck(password) == 0)
            {
                return count;
            }
            else 
            {
                count = LetterCheck(password) + DigitCheck(password) + SymbolCheck(password) + 1;
                return count;
            }
            
        }

        private int LengthCheck(string password)
        {
            if(password.Length >= 6)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private int LetterCheck(string password)
        {
            if (password.Any(char.IsLetter))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private int DigitCheck(string password)
        {
            if (password.Any(char.IsDigit))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int SymbolCheck(string password)
        {
            string symbol = @"|!#$%&/()=?»«@£§€{}.-;~`'<>_,";
            foreach (var item in symbol)
            {
                if (password.Contains(item))
                {
                    return 1;
                }  
            }
            return 0;
        }
    }
}
