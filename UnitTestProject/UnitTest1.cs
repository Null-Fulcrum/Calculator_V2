using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp2;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSumm32and23res55()
        {
            double num_1 = 32;
            double num_2 = 23;
            double ex = 55;

            double res = Calculation.Summ(num_1,num_2);
            Assert.AreEqual(ex,res);
        }
        [TestMethod]
        public  void TestMethodSumm11and56res67()
        {
            double num_1 = 11;
            double num_2 = 56;
            double ex = 67;

            double res = Calculation.Summ(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodSumm51and77res128()
        {
            double num_1 = 51;
            double num_2 = 77;
            double ex = 128;

            double res = Calculation.Summ(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodDivision10and5res2()
        {
            double num_1 = 10;
            double num_2 = 5;
            double ex = 2;

            double res = Calculation.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodDivision35and7res5()
        {
            double num_1 = 35;
            double num_2 = 7;
            double ex = 5;

            double res = Calculation.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodDivision100and10res10()
        {
            double num_1 = 100;
            double num_2 = 10;
            double ex = 10;

            double res = Calculation.Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodReminderDivision11and5res1()
        {
            double num_1 = 11;
            double num_2 = 5;
            double ex = 1;

            double res = Calculation.Remainder_Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodReminderDivision12and7res5()
        {
            double num_1 = 12;
            double num_2 = 7;
            double ex = 5;

            double res = Calculation.Remainder_Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodReminderDivision40and17res6()
        {
            double num_1 = 40;
            double num_2 = 17;
            double ex = 6;

            double res = Calculation.Remainder_Division(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodSubtraction12and7res5()
        {
            double num_1 = 12;
            double num_2 = 7;
            double ex = 5;

            double res = Calculation.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodSubtraction22and5res17()
        {
            double num_1 = 22;
            double num_2 = 5;
            double ex = 17;

            double res = Calculation.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodSubtraction69and43res26()
        {
            double num_1 = 69;
            double num_2 = 43;
            double ex = 26;

            double res = Calculation.Subtraction(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public  void TestMethodMultiplication3and30res90()
        {
            double num_1 = 3;
            double num_2 = 30;
            double ex = 90;

            double res = Calculation.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodMultiplication15and8res120()
        {
            double num_1 = 15;
            double num_2 = 8;
            double ex = 120;

            double res = Calculation.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public  void TestMethodMultiplication6and6res36()
        {
            double num_1 = 6;
            double num_2 = 6;
            double ex = 36;

            double res = Calculation.Multiplication(num_1, num_2);
            Assert.AreEqual(ex, res);
        }
    }
}
