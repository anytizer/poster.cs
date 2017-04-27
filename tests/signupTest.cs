using business;
using business1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tests
{
    [TestClass()]
    public class signupTest
    {
        [TestMethod()]
        [TestCategory("User")]
        public void signup()
        {
            // gather data
            // get url to post
            signup s = new signup();
            s.email = "test@example.com";

            poster p = new poster();
            p.post("http://localhost/elsewhere/signup", s);
        }
   }
}