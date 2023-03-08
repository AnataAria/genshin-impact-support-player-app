using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENSHIN_IMPACT_SP_APP.Model
{
    internal class User
    {
        private String id;
        private String firstname;
        private String lastname;
        private String email;
        private String phonenumber;
        public User()
        {
            this.id = "";
            this.firstname = "";
            this.lastname = "";
            this.email = "";
            this.phonenumber = "";
        }
        public User(String id, String firstname, String lastname, String email, String phonenumber)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phonenumber=phonenumber;
        }

        public String ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public String FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public String LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public String Phonenumber
        {
            get { return this.phonenumber;}
            set { this.phonenumber = value; }
        }
    }
}
