using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class CornerPiece : CubePiece
    {
        public Color thisSideC;
        public Color upSideC;
        public Color leftSideC;

        public CornerPiece()
        {

        }

        public CornerPiece(Color thisSideC, Color upSideC, Color leftSideC)
        {
            this.thisSideC = thisSideC;
            this.upSideC = upSideC;
            this.leftSideC = leftSideC;
        }
    }
}
