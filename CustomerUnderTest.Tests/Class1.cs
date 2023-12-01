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
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {

            Assert.That(1 == 1);
        }


        [Test]
        public void TestAcceptData()
        { 
            //Arrange--Initialize
        Products p=new Products();
            p.ProductID = 1;
            p.ProductName = "Apples";
            p.Price = 10;

            //Act
            Products p1 = new Products();
            p1.AcceptData(1, "Apples", 10);
            //p1.Productid=1;
            //p1.PRoductname="Apples"
            // p1.Price = 10;

            //Assert
             ClassicAssert.AreEqual(p.ProductID, p1.ProductID);
            ClassicAssert.AreEqual(p.ProductName, p1.ProductName);
            ClassicAssert.AreEqual(p.Price, p1.Price);
            
            



        }


    }
}
