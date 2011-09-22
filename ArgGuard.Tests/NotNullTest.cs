using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArgGuard.Tests
{
    [TestClass]
    public class NotNullTest
    {
        [TestMethod]
        public void NoException_If_Object_IsNotNull()
        {
            object value = new object();
            Guard.NotNull(value, "value");
        }

        [TestMethod]
        public void ThrowArgumentNullException_If_Object_IsNull()
        {
            object value = null;
            try
            {
                Guard.NotNull(value, "value");
            }
            catch (ArgumentNullException error)
            {
                Assert.AreEqual("value", error.ParamName);
            }
        }
    }
}