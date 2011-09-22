using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArgGuard.Tests
{
    [TestClass]
    public class NotNullOrEmptyTest
    {
        [TestMethod]
        public void NoException_If_String_IsNotNull()
        {
            string value = "abc";
            Guard.NotNullOrEmpty(value, "value");
        }

        [TestMethod]
        public void ThrowArgumentNullException_If_String_IsNull()
        {
            string value = null;
            try
            {
                Guard.NotNullOrEmpty(value, "value");
            }
            catch (ArgumentNullException error)
            {
                Assert.AreEqual("value", error.ParamName);
            }
        }

        [TestMethod]
        public void ThrowArgumentException_If_String_IsEmpty()
        {
            string value = string.Empty;
            try
            {
                Guard.NotNullOrEmpty(value, "value");
            }
            catch (ArgumentException error)
            {
                Assert.AreEqual("value", error.ParamName);
            }
        }
    }
}
