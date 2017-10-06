using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueCharacters;

namespace TestOfUniqueCharacters
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestWithSimpleString()
        {
            var input = "kiscica";
            List<char> expectedList = new List<char> {'k', 's', 'a'};
            Assert.AreEqual(expectedList, MainProgram.UniqueCharacter(input));
        }

        [Test]
        public void TestWithEmptyString()
        {
            var input = string.Empty;
            List<char> expectedList = new List<char>();
            Assert.AreEqual(expectedList, MainProgram.UniqueCharacter(input));
        }

        [Test]
        public void TestWithNoUNiqueCharacters()
        {
            var input = "mama";
            List<char> expectedList = new List<char>();
            Assert.AreEqual(expectedList, MainProgram.UniqueCharacter(input));
        }

        [Test]
        public void TestWithUppercaseCharacters()
        {
            var input = "Cica";
            List<char> expectedList = new List<char> { 'i', 'a' };
            Assert.AreEqual(expectedList, MainProgram.UniqueCharacter(input));
        }
    }
}
