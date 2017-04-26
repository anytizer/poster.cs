using business;
using business1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    [TestClass()]
    public class posterTests
    {
        [TestMethod()]
        [TestCategory("HTTP")]
        public void postTest()
        {
            /**
             * Create envelope
             */
            member m = new member()
            {
                name = "Full Name",
                user = new user()
                {
                    id = Guid.NewGuid(),
                    username = "username",
                    password = new password()
                    {
                        algorithm = "rithm",
                        hash = "256h"
                    }
                }
            };

            poster p = new poster();
            string url = "http://localhost:8080/post.php";
            string posted = p.post(url, m);

            Assert.IsTrue(posted.Contains("posted"));
        }

        [TestMethod()]
        [TestCategory("HTTP")]
        public void pingPongTest()
        {
            poster p = new poster();
            string url = "http://localhost:8080/ping.php";
            string posted = p.post(url, null);

            Assert.IsTrue(posted.Contains("pong"));
        }
    }
}