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

        [TestMethod]
        public void InputsMatch_DoTheInputsMatch_False()
        {
            Game newGame = new Game();
            string input1 = "yes";
            string input2 = "no";
            bool doesMatch = newGame.InputsMatch(input1, input2);
            Assert.AreEqual(false, doesMatch);
        }

        [TestMethod]
        public void RockWins_DoesRockWin_True()
        {
          Game newGame = new Game();
          string input1 = "rock";
          string input2 = "scissors";
          bool doesRockWin = newGame.RockWins(input1, input2);
          Assert.AreEqual(true, doesRockWin);
        }

        [TestMethod]
        public void RockWins_DoesRockWin_False()
        {
          Game newGame = new Game();
          string input1 = "scissors";
          string input2 = "scissors";
          bool doesRockWin = newGame.RockWins(input1, input2);
          Assert.AreEqual(false, doesRockWin);
        }

        [TestMethod]
        public void ScissorsWins_DoesScissorsWin_True()
        {
          Game newGame = new Game();
          string input1 = "scissors";
          string input2 = "paper";
          bool doesScissorsWin = newGame.ScissorsWins(input1, input2);
          Assert.AreEqual(true, doesScissorsWin);
        }

        [TestMethod]
        public void ScissorsWins_DoesScissorsWin_False()
        {
          Game newGame = new Game();
          string input1 = "scissors";
          string input2 = "scissors";
          bool doesScissorsWin = newGame.ScissorsWins(input1, input2);
          Assert.AreEqual(false, doesScissorsWin);
        }

        [TestMethod]
        public void PaperWins_DoesPaperWin_True()
        {
          Game newGame = new Game();
          string input1 = "paper";
          string input2 = "rock";
          bool doesPaperWin = newGame.PaperWins(input1, input2);
          Assert.AreEqual(true, doesPaperWin);
        }
        [TestMethod]
        public void PaperWins_DoesPaperWin_False()
        {
          Game newGame = new Game();
          string input1 = "paper";
          string input2 = "paper";
          bool doesPaperWin = newGame.PaperWins(input1, input2);
          Assert.AreEqual(false, doesPaperWin);
        }
    }
}
