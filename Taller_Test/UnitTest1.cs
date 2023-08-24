using KStringLibrary;

namespace Taller_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abcc", 2, 2)]
        [InlineData("aabab", 3, 0)]
        public void Base_Test(string inputString, int K, int expected)
        {
            var result = KStringClass.GetCountDistinctSubstrings(inputString, K);
            Assert.Equal(expected, result);
        }
    }
}