using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountingVowels;

namespace VowelTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountingVowels()
        {

            string input = "hello world";

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"e", 1 }, {"o", 2}
            };

            VowelCounter vowelCounter = new VowelCounter();

            var actualOutput = vowelCounter.Counter(input);

            CollectionAssert.AreEqual(expected, actualOutput);
        }

        [TestMethod]
        public void CountingVowelsWithCase()
        {
            string input = "HEllo WOrld";

            Dictionary<string, int> expected = new Dictionary<string, int>() {
                {"e", 1 }, {"o", 2}
            };

            VowelCounter vowelCounter = new VowelCounter();

            var actualOutput = vowelCounter.Counter(input);

            CollectionAssert.AreEqual(expected, actualOutput);
        }


        [TestMethod]
        public void CountingEspecialVowels()
        {
            string input = "HÉllo this Is WÓrld Test";

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"e", 2 }, {"o", 2}, {"i", 2}
            };

            VowelCounter vowelCounter = new VowelCounter();

            var actualOutput = vowelCounter.Counter(input);

            CollectionAssert.AreEqual(expected, actualOutput);
        }

    }
}
