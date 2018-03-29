using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Bingo
{
    class SelectedNumbersList
    {
        bool[] usedArray = new bool[75];

            


        /// recordCalledNumber() changes the boolean value to true if the number has been called.
        ///  
        /// 
        public void recordCalledNumber(int n)
        {
            usedArray[n] = true;
        }

        /// isUnique checks the cell corresponding to n for true in usedArray
        /// if the cell is true, the number is not unique
        /// if the cell is false, the number is unique
        public bool isUnique(int n)
        {
            if (usedArray[n] == true)
                return true;
            else
                return false;

        }

        /// reset() sets all values of usedArray to false
        /// -used when getting the random numbers when initializing the board and when keeping track
        /// of numbers called
        public void reset()
        {
            for (i = 0; i < usedArray.Length; i++)
            {
                usedArray[i] = false;
            }
        }
    }
}

