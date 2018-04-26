using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server
{
    public class postDL
    {
        public static List<Post> postlist = new List<Post>();
        public void posting(Post p) 
        {
            postlist.Add(p);
        }
    }
}