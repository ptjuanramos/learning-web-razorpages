using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Learning.Razor.Helpers
{
    public class ValidationHelper
    {
        public static bool IsEmailValid(String email)
        {
            if(email == null)
            {
                return false;
            }

            string validEmailRegex = @"([0-9A-Za-z])*.\@.([a-zA-Z0-9])*.(.).([a-zA-Z]{2,4})";
            return Regex.IsMatch(email, validEmailRegex);
        }
    }
}
