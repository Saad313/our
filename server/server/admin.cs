using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace server
{
    [DataContract]
    public class admin
    {
        private string adminname;

        [DataMember]
        public string Adminname
        {
            get { return adminname; }
            set { adminname = value; }
        }
        private string adminpass;

        [DataMember]
        public string Adminpass
        {
            get { return adminpass; }
            set { adminpass = value; }
        }
    }
}