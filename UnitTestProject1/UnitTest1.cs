using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repetition2018E;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Lav en testmetode, som  checker om der tilføjes et tal til listen myIntList

            //Arrange
            Collections c = new Collections();
            c.TestList();
            List<int> myIntList = c.MyIntList;
            int numbersBefore= myIntList.Count;
            //Act
            myIntList.Add(400);
            int numbersAfter = myIntList.Count;
            //Assert
            Assert.AreEqual(numbersBefore +1, numbersAfter);
        }


        [TestMethod]
        public void TestNegativeNumberInList()
        {
            //Lav en test metode, som checker om der der kastes en exception, NegativeNumberException, når metoden SumList kaldes, hvis listen indeholder et negativt tal
            //Arrange
            Collections c = new Collections();
            c.TestList();
            List<int> myIntList = c.MyIntList;

            //Act
            myIntList.Add(-33);
            //Assert
            Assert.ThrowsException<NegativeNumberExcpetion>(() =>
            {
                int sum= c.SumList();
            });

        }

        //Lav Testmetoder, som tester dine egne collections
    }
}
