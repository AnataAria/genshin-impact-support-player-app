using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENSHIN_IMPACT_SP_APP.Model
{
    internal class Account
    {
        private String id;
        private String username;
        private String password;
        public int role;

        public Account()
        {
            this.id = "";
            this.username = "";
            this.password= "";
            this.role = 0;
        }
        public Account(string id, string username, string password, int role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public String ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public int Role
        {
            get { return this.role; }
            set { this.role = value;}
        }
    }
}
