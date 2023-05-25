using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RomanLibrary;

namespace RomanStringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Тест который должен вернуть значение true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result, string.Format($"Ожидается для {word}': true; В действительности: {result}"));
            }
        }


        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "государство" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
           string.Format($"Ожидается для {word}: true; в действительности получаем: {result}"));
            }
        }


        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string[] words = { string.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result,
                string.Format($"Ожидается для {word}: true; в действительности получаем: {result}"));
            }
        }

    }
}
