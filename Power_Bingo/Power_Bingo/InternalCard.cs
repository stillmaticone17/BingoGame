using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Bingo
{
    public class InternalCard
    {
        /// <summary>
        /// 
        /// </summary>
        class InternalCard
        {
            int[] row = new int[5] { 0, 0, 1, 0, 0 };
            int[] column = new int[5] { 0, 0, 1, 0, 0 };

            int forwardDiagonal = 1;
            int backwardDiagonal = 1;

            /// isWinner() checks the individual arrays for BINGO
            public int isWinner(int rowID, int colID)
            {
                // code to check rows
                if (row[rowID] == 5)
                {
                    return 1;
                }

                // code to check columns
                if (col[colID] == 5)
                {
                    return 1;
                }

                // code to check forward diagonal
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

            public void recordCalledNumber(int rowID, int colID)
            {
                colID[colID]++;
                row[rowID]++;

                if (rowID == colID)
                {
                    backwardDiagonal++;
                }

                //forward Diagonal
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
}

