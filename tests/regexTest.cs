using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
/**
 * @see https://msdn.microsoft.com/en-us/library/3y21t6y4(v=vs.110).aspx
 */
namespace tests
{
    [TestClass()]
    public class regexTest
    {
        [TestMethod()]
        [TestCategory("Regex")]
        public void dateTest()
        {
            string datetime = "2010-01-01";
            Regex rgx = new Regex(@"^[\d]{4}\-[\d]{2}\-[\d]{2}$");

            bool matched = rgx.IsMatch(datetime);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("Regex")]
        public void timeTest()
        {
            string datetime = "11:11:11";
            Regex rgx = new Regex(@"^[\d]{2}\:[\d]{2}\:[\d]{2}$");

            bool matched = rgx.IsMatch(datetime);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("Regex")]
        public void datetimeTest()
        {
            string datetime = "2010-01-01 11:11:11";
            Regex rgx = new Regex(@"^[\d]{4}\-[\d]{2}\-[\d]{2}\ [\d]{2}\:[\d]{2}\:[\d]{2}$");

            bool matched = rgx.IsMatch(datetime);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("Regex")]
        public void numbersTest()
        {
            string datetime = "0123456789";
            Regex rgx = new Regex(@"^[\d]{1,}$");

            bool matched = rgx.IsMatch(datetime);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("Regex")]
        public void wordTest()
        {
            string datetime = "quick";
            Regex rgx = new Regex(@"^[a-z]{1,}$");

            bool matched = rgx.IsMatch(datetime);

            Assert.IsTrue(matched);
        }

        [TestMethod()]
        [TestCategory("Regex")]
        public void wordFailTest()
        {
            string datetime = "Quick";
            Regex rgx = new Regex(@"^[a-z]{1,}$");

            bool matched = rgx.IsMatch(datetime);

            Assert.IsFalse(matched);
        }
    }
}