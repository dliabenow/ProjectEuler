using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace DemoApplicationTest
{
    [TestClass]
    public class PermutedMultiples_UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void IsMatching_Exceeds_Max_Threshold_Throws_Exception_TestMethod()
        {
            uint value = PermutedMultiples.MaxThreshold + 1;
            PermutedMultiples.IsMatching(value);
        }

        [TestMethod]
        [ExpectedException(typeof (IndexOutOfRangeException))]
        public void IsMatching_Zero_Throws_IndexOutOfRangeException_TestMethod()
        {
            PermutedMultiples.IsMatching(0);
        }

        [TestMethod]
        public void IsMatching_Number_Thirty_Returns_False_TestMethod()
        {
            bool result = PermutedMultiples.IsMatching(30);

            Assert.AreEqual(result, false, "The expected false result was not received for the number 30.");
        }

        [TestMethod]
        public void IsMatching_Returns_125874_on_Execution_TestMethod()
        {
            const uint expectedResult = 125874;
            uint smallestMatchingInt = 0;

            for (uint i = 1; i < PermutedMultiples.MaxThreshold; i++)
            {
                if (PermutedMultiples.IsMatching(i))
                {
                    smallestMatchingInt = i;
                    break;
                }
            }

            Assert.AreEqual(expectedResult, smallestMatchingInt, "Did not generate the expected result '125874'");
        }

    }
}
