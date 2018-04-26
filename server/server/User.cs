using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace server
{
    [DataContract]
    public class User
    {
        private string username;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}