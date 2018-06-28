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
        public void InputsMatch_DoTheInputsMatch_StringDraw()
        {
            Game newGame = new Game();
            string input1 = "yes";
            string input2 = "yes";
            string doesMatch = newGame.InputsMatch(input1, input2);
            Assert.AreEqual("draw", doesMatch);
        }

        [TestMethod]
        public void InputsMatch_DoTheInputsMatch_EmptyString()
        {
            Game newGame = new Game();
            string input1 = "yes";
            string input2 = "no";
            string drawOrNot = newGame.InputsMatch(input1, input2);
            Assert.AreEqual(String.Empty, drawOrNot);
        }

        [TestMethod]
        public void RockWins_DoesRockWin_StringRock()
        {
          Game newGame = new Game();
          string input1 = "rock";
          string input2 = "scissors";
          string whoWins = newGame.RockWins(input1, input2);
          Assert.AreEqual("rock", whoWins);
        }

        [TestMethod]
        public void RockWins_DoesRockWin_EmptyString()
        {
          Game newGame = new Game();
          string input1 = "scissors";
          string input2 = "scissors";
          string whoWins = newGame.RockWins(input1, input2);
          Assert.AreEqual(String.Empty, whoWins);
        }

        [TestMethod]
        public void ScissorsWins_DoesScissorsWin_StringScissors()
        {
          Game newGame = new Game();
          string input1 = "scissors";
          string input2 = "paper";
          string whoWins = newGame.ScissorsWins(input1, input2);
          Assert.AreEqual("scissors", whoWins);
        }

        [TestMethod]
        public void ScissorsWins_DoesScissorsWin_EmptyString()
        {
          Game newGame = new Game();
          string input1 = "scissors";
          string input2 = "scissors";
          string whoWins = newGame.ScissorsWins(input1, input2);
          Assert.AreEqual(String.Empty, whoWins);
        }

        [TestMethod]
        public void PaperWins_DoesPaperWin_StringPaper()
        {
          Game newGame = new Game();
          string input1 = "paper";
          string input2 = "rock";
          string whoWins = newGame.PaperWins(input1, input2);
          Assert.AreEqual("paper", whoWins);
        }
        [TestMethod]
        public void PaperWins_DoesPaperWin_EmptyString()
        {
          Game newGame = new Game();
          string input1 = "paper";
          string input2 = "paper";
          string whoWins = newGame.PaperWins(input1, input2);
          Assert.AreEqual(String.Empty, whoWins);
        }

        [TestMethod]
        public void FindWinner_FindOutIfDraw_String()
        {
            Game newGame = new Game();
            string input1 = "paper";
            string input2 = "paper";
            string whoIsWinner = newGame.FindWinner(input1, input2);
            Assert.AreEqual("draw", whoIsWinner);
        }

        [TestMethod]
        public void FindWinner_FindOutIfRockWins_String()
        {
          Game newGame = new Game();
          string input1 = "rock";
          string input2 = "scissors";
          string whoIsWinner = newGame.FindWinner(input1, input2);
          Assert.AreEqual("rock", whoIsWinner);
        }

        [TestMethod]
        public void FindWinner_FindOutIfScissorsWins_String()
        {
          Game newGame = new Game();
          string input1 = "scissors";
          string input2 = "paper";
          string whoIsWinner = newGame.FindWinner(input1, input2);
          Assert.AreEqual("scissors", whoIsWinner);
        }

        [TestMethod]
        public void FindWinner_FindOutIfPaperWins_String()
        {
          Game newGame = new Game();
          string input1 = "paper";
          string input2 = "rock";
          string whoIsWinner = newGame.FindWinner(input1, input2);
          Assert.AreEqual("paper", whoIsWinner);
        }

        [TestMethod]
        public void FindWinner_FindOutIfYouTypedJibberish_String()
        {
          Game newGame = new Game();
          string input1 = "dfaskj";
          string input2 = "scissors";
          string whoIsWinner = newGame.FindWinner(input1, input2);
          Assert.AreEqual("Don't be like Elly", whoIsWinner);
        }

    }
}
