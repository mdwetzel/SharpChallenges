using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringHelper;

namespace PalindromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void IsPalindromeShouldReturnTrueOnProperPalindrome()
        {
            Assert.IsTrue(Palindrome.IsPalindrome("bob"));
        }

        [TestMethod]
        public void IsPalindromeShouldReturnFalseOnMixedCase()
        {
            Assert.IsFalse(Palindrome.IsPalindrome("Bob"));
        }

        [TestMethod]
        public void IsPalindromeShouldReturnFalseOnNonPalindrome()
        {
            Assert.IsFalse(Palindrome.IsPalindrome("Robert"));
        }
    }
}
