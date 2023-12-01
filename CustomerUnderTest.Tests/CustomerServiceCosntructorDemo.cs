using CustomerLibrary;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUnderTest.Tests
{
    [TestFixture(CustType.Premium)]
    public class CustomerServiceCosntructorDemo
    {
        private CustType testCustType;
        public CustomerServiceCosntructorDemo(CustType customerType)
        {
            this.testCustType = customerType;
        }
        [TestCase]
        public void TestMethod()
        {


            ClassicAssert.IsTrue(testCustType == CustType.Basic);
        }
    }
}
