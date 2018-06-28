/*
Rock v. Scissors = Rock wins
Rock v. Paper = Paper wins
Paper v. Scissors = Scissors wins
*/

using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Game
    {
        private string _input1;
        private string _input2;

        public bool InputsMatch(string input1, string input2)
        {
            if (input1 == input2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
