using NUnit.Framework;

using SharpEcho.Recruiting.SpellChecker.Contracts;
using SharpEcho.Recruiting.SpellChecker.Core;
using System.Net;

namespace SharpEcho.Recruiting.SpellChecker.Tests
{
    [TestFixture]
    class DictionaryDotComSpellCheckerTests
    {
        private ISpellChecker SpellChecker;

        [OneTimeSetUp]
        public void TestFixureSetUp()
        {
            SpellChecker = new DictionaryDotComSpellChecker();
        }

        [Test]
        public void Check_That_SharpEcho_Is_Misspelled()
        {
            // implement this test
            string teststr = "SharpEcho";
            SpellChecker.Check(teststr);
        }

        [Test]
        public void Check_That_South_Is_Not_Misspelled()
        {
            // implement this test
            string teststr = "South";
            SpellChecker.Check(teststr);
        }
    }
}
