using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Bingo
{
    /// Purpose: to maintain the state of the Bingo card as the game is played
    /// also used to test for a winning bingo card
    class InternalCardClass
    {
        // initializing the internal board arrays which will allow us to check for Bingo
        // - all values are initialized as false except for the middle of both arrays for the 'free space'
        int[] row = new int[5] { 0, 0, 1, 0, 0 };
        int[] column = new int[5] { 0, 0, 1, 0, 0 };

        int forwardDiagonal = 1;
        int backwardDiagonal = 1;

        /// isWinner() checks the individual arrays for BINGO
        /// for each bingo is found, a 1 is returned
        /// if no bingo is found, a 0 is returned
        public int isWinner(int rowID, int colID)
        {
            // code to check if any rows have all of their cells filled
            if (row[rowID] == 5)
            {
                return 1;
            }

            // code to check if any columns have all of their cells filled
            if (column[colID] == 5)
            {
                return 1;
            }

            // code to check if all cells of the forward diagonal have been filled
            if (forwardDiagonal == 5)
            {
                return 1;
            }

            // code for back diagonal
            if (backwardDiagonal == 5)
            {
                return 1;
            }
            // if no bingo found, return 0
            return 0;
        }

        /// recordCalledNumber() uses the user-pressed button location as params rowID and colID  
        /// to find the correct cell of the correct array and mark it to true.
        /// <param name="rowID"></param>
        /// <param name="colID"></param>
        public void recordCalledNumber(int rowID, int colID)
        {
            column[colID]++;
            row[rowID]++;

            // code for the back diagonal - if the IDs are equal, it is part of the downward-sloping 'back' diagonal
            if (rowID == colID)
            {
                backwardDiagonal++;
            }

            // code for the forward Diagonal
            if (rowID == 0 && colID == 4)
            {
                forwardDiagonal++;
            }
            if (rowID == 1 && colID == 3)
            {
                forwardDiagonal++;
            }
            if (rowID == 3 && colID == 1)
            {
                forwardDiagonal++;
            }
            if (rowID == 4 && colID == 0)
            {
                forwardDiagonal++;
            }
        }
    }
}

