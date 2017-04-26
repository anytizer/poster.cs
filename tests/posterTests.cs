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
    public class posterTests
    {
        private string APIURL = "http://localhost:8080/api";

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
            string url = this.APIURL + "/post.php";
            string posted = p.post(url, m);

            Assert.IsTrue(posted.Contains("posted"));
        }

        [TestMethod()]
        [TestCategory("HTTP")]
        public void pingPongTest()
        {
            poster p = new poster();
            string url = this.APIURL + "/ping.php";
            string posted = p.post(url, null);

            Assert.IsTrue(posted.Contains("pong"));
        }

        [TestMethod()]
        [TestCategory("HTTP")]
        public void dateTest()
        {
            poster p = new poster();
            string url = this.APIURL + "/date.php";
            string response = p.post(url, null);

            Regex rgx = new Regex(@"^[\d]{4}\-[\d]{2}\-[\d]{2}$");
            bool matched = rgx.IsMatch(response);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("HTTP")]
        public void timeTest()
        {
            poster p = new poster();
            string url = this.APIURL + "/time.php";
            string response = p.post(url, null);

            Regex rgx = new Regex(@"^[\d]{2}\:[\d]{2}\:[\d]{2}$");
            bool matched = rgx.IsMatch(response);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("HTTP")]
        public void datetimeTest()
        {
            poster p = new poster();
            string url = this.APIURL + "/datetime.php";
            string response = p.post(url, null);

            Regex rgx = new Regex(@"^[\d]{4}\-[\d]{2}\-[\d]{2}\ [\d]{2}\:[\d]{2}\:[\d]{2}$");
            bool matched = rgx.IsMatch(response);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("HTTP")]
        public void asisItest()
        {
            string asis = "something as inpput";
            something s = new something() { content = asis };

            poster p = new poster();
            string url = this.APIURL + "/asis.php";
            string response = p.post(url, s);

            Assert.IsTrue(response.Contains(asis));
        }
    }
    internal class something
    {
        public string content;
    }
}