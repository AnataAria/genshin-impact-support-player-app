using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENSHIN_IMPACT_SP_APP.DB.DB_MODEL
{
    public class login_model
    {
        private String username;
        private String password;
        private byte job;
        public login_model()
        {

        }
        public login_model(string username, string password, byte job)
        {
            this.username = username;
            this.password = password;
            this.job = job;
        }
        public String userName
        {
            set { username = value; }
            get { return username; }
        }
        public String Password
        {
            set { password = value; }
            get { return password; }
        }
        public byte Job
        {
            set { job = value; }
            get { return job; }
        }
    }
}
