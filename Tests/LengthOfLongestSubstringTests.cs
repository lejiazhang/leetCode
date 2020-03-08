using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class LengthOfLongestSubstringTests
    {
        [Test]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        public void should_return_logest_str_index_in_given_string(string s, int expectedLength)
        {
            // Act
            var actualLength = Solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(actualLength, expectedLength);
        }
    }
}
