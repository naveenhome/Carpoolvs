using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RPNCalc
{
    public class RPNTest
    {
        [Test]
        public void test2ValueAnd1Opt()
        {
            string expr = "3,2,+";
            RPNCalculator rpncalculator = new RPNCalculator();
            Assert.AreEqual(5, rpncalculator.calculate(expr));
        }
        [Test]
        public void test2ValueAnd1OptCrossCheck()
        {
            string expr = "3,5,+";
            RPNCalculator rpncalculator = new RPNCalculator();
            Assert.AreEqual(8, rpncalculator.calculate(expr));
        }
        [Test]
        public void test2ValueOnly()
        {
            string expr = "3,5";
            RPNCalculator rpncalculator = new RPNCalculator();
            try
            {

                int result = rpncalculator.calculate(expr);
                Assert.Fail();
            }catch(Exception ex)
            {
                Assert.AreEqual("Incorrect input", ex.Message);

            }
        }
        [Test]
        public void testEmpty()
        {
            string expr = " ";
            RPNCalculator rpncalculator = new RPNCalculator();
            try
            {

                int result = rpncalculator.calculate(expr);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Expession is empty", ex.Message);

            }
        }
    }
}
