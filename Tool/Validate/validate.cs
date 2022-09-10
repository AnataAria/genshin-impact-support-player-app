using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GENSHIN_IMPACT_SP_APP.Tool.Validate
{
    internal class validate
    {
        public validate()
        {

        }

        public bool username_validate(String username)
        {
            bool flag = true;
            if (username.Length == 0) flag = false;
            else
            {
                if (!username.StartsWith("[!-.]") && !username.StartsWith("[:-@]"))
                {
                    if (username.Length <= 8) flag = false;
                }
                else
                {
                    flag= false;
                }
            }
            return flag;
        }

        public bool password_validate(String password)
        {
            String matcher = "[! t # $ % & ' * + ‑ / ";
            Match match = Regex.Match(password, matcher);
            bool flag = true;
            if (password.Length == 0 && password.Length <= 8) flag = false;
            else
            {
                if (match.Success)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public bool email_validate(String email)
        {
            bool flag = false;
            Match match = Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (match.Success)
            {
                flag = true;
            }
            return flag;

        }
    }
}
