using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList.CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Int_Count()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Add_Int2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int number = 6;
            int expected = 6;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[5]);
        }
        [TestMethod]

        public void Add_Int_Initializer()
        {
            //Arrange
            int number = 1;
            int expected = 1;
         //Act
            CustomList<int> list = new CustomList<int>() { number };
         //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_Int_Initializer_Count()
        {
          //Arrange
            int number = 1;
            int expected = 1;
           //Act
            CustomList<int> list = new CustomList<int>() { number };
           //Assert
            Assert.AreEqual(expected, list.Count);
        }
   //Add and Remove Tests.

        [TestMethod]
        public void Add1()
         {
           //Arrange
             CustomList<int> list = new CustomList<int>();
             int number = 1;
             int expected = 1;
           //Act
             list.Add(number);
           //Assert
             Assert.AreEqual(expected, list[0]);
            }
       
            [TestMethod]
            public void Add2()
            {
           //Arrange
              CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
              int number = 5;
              int expected = 1;
           //Act
              list.Add(number);
           //Assert
              Assert.AreEqual(expected, list[0]);
            }
        [TestMethod]
        public void Add7()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add8()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 3;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add9()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 2;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
            public void Add3()
            {
           //Arrange
              CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
              int number = 5;
              int expected = 4;
           //Act
              list.Add(number);
           //Assert
              Assert.AreEqual(expected, list[3]);
            }
        [TestMethod]
        public void Add5()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 5;
            int expected = 4;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void Add6()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 5;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
            public void AddIndexTwoInitializerCount()
            {
           //Arrange
              int number1 = 1;
              int number2 = 2;
              int expected = 2;
           //Act
              CustomList<int> list = new CustomList<int>() { number1, number2 };
           //Assert
              Assert.AreEqual(expected, list.Count);
            }

            [TestMethod]
            public void AddIndexTwoInitializer2()
            {
            //Arrange
              int number1 = 1;
              int number2 = 2;
              int expected = 1;
            //Act
              CustomList<int> list = new CustomList<int>() { number1, number2 };
            //Assert
              Assert.AreEqual(expected, list[0]);
            }

        [TestMethod]
        public void DeleteCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1 };
            int number = 1;
            int expected = 0;
            //Act
              list.Remove(number);
            //Assert
              Assert.AreEqual(expected, list.Count);
            }
        [TestMethod]
        public void DeleteCount2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
            public void DeleteCount3()
            {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 3;
            //Act
            list.Remove(number);
            //Assert
             Assert.AreEqual(expected, list.Count);
            }
        [TestMethod]
        public void DeleteCount4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int number = 1;
            int expected = 4;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void DeleteCount5()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2 };
            int number = 1;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        
        [TestMethod]
        public void DeleteInt9()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 3;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt10()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt12()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 2;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt7()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 2;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt8()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 3;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        
        [TestMethod]
        public void DeleteInt6()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
            public void DeleteInt3()
            {
                //Arrange
                CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
                int number = 1;
                int expected = 4;
                //Act
                list.Remove(number);
                //Assert
                Assert.AreEqual(expected, list[2]);
            }
        [TestMethod]
        public void DeleteInt14()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 2;
            int expected = 4;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void DeleteInt4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 3;
            int expected = 4;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void DeleteInt15()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 3;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void DeleteInt48()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 3;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
            public void DeleteInt5()
            {
                //Arrange
                CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
                int number = 3;
                int expected = 1;
                //Act
                list.Remove(number);
                //Assert
                Assert.AreEqual(expected, list[0]);
          
            }
        [TestMethod]
        public void DeleteInt11()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 0;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt39()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 0;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt16()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt17()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt18()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt19()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt20()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt21()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt22()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt23()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt24()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt25()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt26()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt27()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt28()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt29()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt30()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt31()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt32()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt33()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt34()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt35()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt36()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt37()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt38()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt40()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 0;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt41()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 0;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt42()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 3;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void DeleteInt43()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 3;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void Add44()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            int expected = 1;
            //Act
            list.Add(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt44()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt45()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt46()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt47()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt62()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt49()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt50()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt51()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt52()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt53()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt54()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt55()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt56()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt57()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt58()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt59()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt60()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt63()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt64()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt65()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt66()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt67()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt68()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt69()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt70()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt71()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt72()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt73()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt74()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt75()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt76()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt77()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt78()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt79()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt80()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt81()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt82()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt83()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt84()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt85()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt86()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt87()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt88()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt89()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt90()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt91()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt92()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt93()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt94()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt95()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt96()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt97()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt98()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt99()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt100()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt101()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt102()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt103()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt104()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt105()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt106()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt107()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt108()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt109()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt110()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt111()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt112()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt113()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt114()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt115()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt116()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt117()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt118()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt119()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt120()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt121()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt122()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt123()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt124()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt125()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt126()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt127()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt128()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt129()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt130()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt131()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt132()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt133()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt134()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt135()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt136()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt137()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt138()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt139()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt140()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 4;
            int expected = 1;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void DeleteInt2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            int number = 1;
            int expected = 2;
            //Act
            list.Remove(number);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
             
        [TestMethod]
            public void Count_Int()
            {
            //Arrange
            CustomList<int> list = new CustomList<int>();
                list.Add(1);
                list.Add(1);
                list.Add(1);
                list.Add(1);
                list.Add(1);
                list.Add(1);
                list.Add(1);

            //Act
            int expected = 7;
            //Assert
            Assert.AreEqual(expected, list.Count);
            }

            [TestMethod]
            public void Count_String()
            {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "hi", "later", "peace out", "bye" };

            //Act
            int expected = 4;
            //Assert
            Assert.AreEqual(expected, list.Count);
            }

            ////This is the ToString Tests.

            [TestMethod]
            public void Override_ToString_String()
            {
                //Arrange
                CustomList<string> greetings = new CustomList<string>() { "hi", "later", "peace out", "bye" };
                string expected = "hi\nlater\npeace out\nbye\n";
                //Act
                string result = greetings.ToString();
                //Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void Override_ToString_Int()
            {
                //Arrange
                CustomList<int> numbers = new CustomList<int>() { 1, 3, 5, 3, 2, 5, 2 };
                string expected = "1\n3\n5\n3\n2\n5\n2\n";
                //Act
                string result = numbers.ToString();
                //Assert
                Assert.AreEqual(expected, result);
            }

            

       [TestMethod]
        public void Zip1()
            {
                //Arrange
                CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
                CustomList<int> evens = new CustomList<int>() { 2, 4, 6 };
                CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
                //Act
                CustomList<int> result = odds.ZipIt(evens);
                //Assert
                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(expected[i], result[i]);
                }
            }

        [TestMethod]
        public void Zip2()
        {
            //Arrange
            CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evens = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            //Act
            CustomList<int> result = odds.ZipIt(evens);
            //Assert
           for (int i = 0; i < expected.Count; i++)
           {
               Assert.AreEqual(expected[i], result[i]);
           }
        }

        [TestMethod]
        public void Zip3()
        {
            //Arrange
            CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evens = new CustomList<int>() { 1, 3, 5, 1, 3, 5, 1, 3, 5, 1, 3, 5 };
            CustomList<int> expected = new CustomList<int>() { 1, 1, 3, 3, 5, 5 };
            //Act
            CustomList<int> result = evens.ZipIt(odds);
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
            

            [TestMethod]
            public void OverLoad_Plus_Int()
            {
                //Arrange
                CustomList<int> firstList = new CustomList<int>() { 1, 3, 5 };
                CustomList<int> secondList = new CustomList<int>() { 2, 4, 6 };
                CustomList<int> expected = new CustomList<int>() { 1, 3, 5, 2, 4, 6 };
                //Act
                CustomList<int> result = firstList + secondList;
                //Assert
                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(expected[i], result[i]);
                }
            }
    }
}




            
            
    


