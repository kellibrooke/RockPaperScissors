using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void InputsMatch_DoTheInputsMatch_True()
        {
            Game newGame = new Game();
            string input1 = "yes";
            string input2 = "yes";
            bool doesMatch = newGame.InputsMatch(input1, input2);
            Assert.AreEqual(true, doesMatch);
        }
    }
}
