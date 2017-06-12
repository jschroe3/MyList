using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;

namespace TestTest
{
    [TestClass]
    public class UnitTest1
    {
            

       [TestMethod]
        public void Add_Int_Count()
        {
            CustomList<int> list = new CustomList<int>();

            int number = 1;

            int expected = 1;

            //Act

            list.Add(number);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        //Arrange

        
        }
    }


