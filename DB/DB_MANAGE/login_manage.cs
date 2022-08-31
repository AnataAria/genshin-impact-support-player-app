using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GENSHIN_IMPACT_SP_APP.DB.DB_MODEL;

namespace GENSHIN_IMPACT_SP_APP.DB.DB_MANAGE
{
    public class login_manage
    {
        login_model loginCache = new login_model();
        public void loadData(String userName, String passWord)
        {
            loginCache.userName = userName;
            loginCache.Password = passWord;
        }

        public Boolean checkUserPass()
        {
            Boolean flag = false;
            if(loginCache.userName == null || loginCache.Password == null)
            {
                flag = false;
            }
            {
                if (loginCache.userName.ToLower().Equals("anataarisa") && loginCache.Password.Equals("Vinh12345."))
                {
                    flag = true;
                }
            }
            return flag;
        }
        void clearData()
        {
            loginCache.userName = null;
            loginCache.Password = null;
        }
    }
}
