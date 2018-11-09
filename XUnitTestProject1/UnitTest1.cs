using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckifPermutationTrueExactcharacters()
        {
            String StringA = "ABC";
            String StringB = "CBA";

            Implementation I = new Implementation();

           var  output = I.CheckPermutation(StringA, StringB);

            Assert.True(output);
         
        }

        [Fact]
        public void CheckifPermutationFalseExactcharacters()
        {
            String StringA = "ABC";
            String StringB = "DVD";

            Implementation I = new Implementation();

            var output = I.CheckPermutation(StringA, StringB);

            Assert.False(output);

        }

        [Fact]
        public void CheckDifferentstringlength()
        {
            String StringA = "LOGQWERR";
            String StringB = "QWERGOL";

            Implementation I = new Implementation();

            var output = I.CheckPermutation(StringA, StringB);

            Assert.False(output);

        }
    }
}
