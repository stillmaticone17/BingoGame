using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Bingo
{
    class Player
    {
        String name;

        public String displayName()
        {
            return name;
        }
        public void addName(String name)
        {
            name = this.name;
        }
    }
}
