using System;
using NUnit.Framework;



using SharpEcho.Recruiting.SpellChecker.Contracts;
using SharpEcho.Recruiting.SpellChecker.Core;

namespace SharpEcho.Recruiting.SpellChecker.Tests
{

    [TestFixture]
    class MnemonicSpellCheckerIBeforeETests
    {
        private ISpellChecker SpellChecker;

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            SpellChecker = new MnemonicSpellCheckerIBeforeE();
        }

        [Test]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Correctly()
        {
            /// Examples: believe, fierce, collie, die, friend, deceive, ceiling, receipt would be evaulated as spelled correctly
            /// heir, protein, science, seeing, their, and veil would be evaluated as spelled incorrectly.
            // implement this test
            SpellChecker.Check("Fierce");

        }

        [Test]
        public void Check_Word_That_Contains_I_Before_E_Is_Spelled_Incorrectly()
        {
            // implement this test
            SpellChecker.Check("decieve");
        }      
    }

  
}
