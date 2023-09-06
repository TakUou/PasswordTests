using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passsword
{
    public class Pass
    {
        public int CheckPassword(string password)
        {
            int sum=0;
            if (password.Length > 7)
            {
                sum++;
            }
            foreach (char c in password)
            {
                if (Char.IsNumber(c))
                {
                    sum++;
                    break;
                }
            }
            foreach(char c in password)
            {
                if(Char.IsLower(c)) 
                { 
                    sum++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                {
                    sum++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (Char.IsPunctuation(c)||Char.IsSeparator(c)||Char.IsSymbol(c)|| c == '@' || c == '#' || c == '$' || c == '%' || c == '&' || c == '*' || c == '^')
                {
                    sum++;
                    break;
                }
            }
            return sum;
        }
    }
}
