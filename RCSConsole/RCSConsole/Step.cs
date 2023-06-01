using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Step
    {
        public Move move;
        public string text;

        public Step(Move move)
        {
            this.move = move;
        }
    }
}
