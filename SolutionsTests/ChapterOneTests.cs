using CTCISolutions;
using NUnit.Framework;

namespace SolutionsTests
{
    public class Tests
    {
        private ChapterOne _testHelper;
        public Tests()
        {
            _testHelper = new ChapterOne();
        }

        [SetUp]
        public void Setup()
        {
            
        }

        #region Is Permutation Tests
        [Test]
        public void IsPermutation_EqualStrings_IsTrue()
        {
            bool result = _testHelper.CheckPermutation("abc", "abc");
            Assert.True(result);
        }

        [Test]
        public void IsPermutation_SimplePermutations_IsTrue()
        {
            bool result = _testHelper.CheckPermutation("abcd", "adcb");
            Assert.True(result);
        }

        [Test]
        public void IsPermutation_ReversedStrings_IsTrue()
        {
            bool result = _testHelper.CheckPermutation("abc", "cba");
            Assert.True(result);
        }

        [Test]
        public void IsPermutation_SimpleDifferenceDifferentLengths_IsFalse()
        {
            bool result = _testHelper.CheckPermutation("abcb", "cba");
            Assert.False(result);
        }

        [Test]
        public void IsPermutation_SimpleDifferenceSameLengths_IsFalse()
        {
            bool result = _testHelper.CheckPermutation("abbc", "abcc");
            Assert.False(result);
        }
        #endregion

        #region Is Unique Tests
        [Test]
        public void IsUniqueBasicTrueCase()
        {
            bool result = _testHelper.IsUniqueBasic("abc");
            Assert.True(result);
        }

        [Test]
        public void IsUniqueBasicFalseCase()
        {
            bool result = _testHelper.IsUniqueBasic("abcda");
            Assert.False(result);
        }

        [Test]
        public void IsUniqueBetterTrueCase()
        {
            bool result = _testHelper.IsUniqueBetter("abc");
            Assert.True(result);
        }

        [Test]
        public void IsUniqueBetterFalseCase()
        {
            bool result = _testHelper.IsUniqueBetter("abcda");
            Assert.False(result);
        }
        #endregion

        #region String Compression Tests
        [Test]
        public void CompressionTest()
        {
            string result = _testHelper.compressString("aabbbcccd");
            Assert.AreEqual("a2b3c3d1", result);
        }

        [Theory]
        [TestCase("a", "a")]
        [TestCase("aa", "aa")]
        [TestCase("aab", "aab")]
        public void CompressionLongerCompression(string input, string expected)
        {
            string result = _testHelper.compressString(input);

            Assert.AreEqual(input, result);
        }
        #endregion

        #region URLify Tests
        [Test]
        public void URLify_BasicSentence()
        {
            string result = _testHelper.URLifyStringInitial("this is a string");
            Assert.AreEqual("this%20is%20a%20string", result);
        }

        [Test]
        public void URLify_HasEndPadding()
        {
            string result = _testHelper.URLifyStringInitial("this is a string     ");
            Assert.AreEqual("this%20is%20a%20string", result);
        }

        [Test]
        public void URLifyInPlace_BasicSentence()
        {
            string testInput = "this is a string      ";
            string result = _testHelper.URLifyStringInPlace(testInput.ToCharArray(), 16);

            Assert.AreEqual("this%20is%20a%20string", result);
        }
        #endregion
    }
}