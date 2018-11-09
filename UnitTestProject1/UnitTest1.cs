using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckifPermutationTrueExactcharacters()
        {
            String StringA = "";
            String StringB = "";
              
            Implementation I = new Implementation();

            output = I.CheckPermutation(StringA, StringB);

            Assert.AreEqual(false, output);
        }

      //  [TestMethod]
        public void CheckifPermutationFalseExactcharacters()
        {
            Assert.AreEqual(false, output);
        }


      //  [TestMethod]
        public void CheckifPermutationFalseNotExactcharacters()
        {
            Assert.AreEqual(false, output);
        }
    }
}
