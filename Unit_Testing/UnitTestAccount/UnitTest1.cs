using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountLibrary; 

namespace UnitTestAccount
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Narendra")]
        public void Test_WithdrawWithLimitExceededException()
        { 
            //arrange
            double startingBalance = 100;
            double withdrawAmount = 100;
            Account a = new Account("Joe", startingBalance);

            try
            {
                //act
                a.Withdraw(withdrawAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Account.LIMIT_EXCEEDED, "Wrong type of exception");
            }
        }

        //running tests on :H Drive does not work!!
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_WithdrawWithoutInsufficientFunds()
        {
            //arrange
            double startingBalance = 500;
            double withdrawAmount = 50;
            double expectedBalance = startingBalance - withdrawAmount;
            Account a = new Account("Sam", startingBalance);

            //act
            a.Withdraw(withdrawAmount);
 
        }
        [TestMethod]
        public void Test_WithdrawWithoutException()
        {
            //arrange
            double startingBalance = 500;
            double withdrawAmount = 50;
            double expectedBalance = startingBalance - withdrawAmount;
            Account a = new Account("Toni", startingBalance);

            //act
            a.Withdraw(withdrawAmount);

            //assert
            Assert.AreEqual(expectedBalance, a.Balance, 0.001, "Withdraw is not correct");
        }
    }
}
