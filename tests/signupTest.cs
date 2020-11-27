using business;
using business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            try
            {
                // non existing api gateway
                p.post("http://localhost/elsewhere/signup", s);
            }
            catch(Exception)
            {
                // must appear here
            }
        }
   }
}