using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class SidePiece : CubePiece
    {
        public Color thisSideC;
        public Color otherSideC;

        public SidePiece()
        {

        }

        public SidePiece(Color thisSideC, Color otherSideC)
        {
            this.thisSideC = thisSideC;
            this.otherSideC = otherSideC;
        }
    }
}
