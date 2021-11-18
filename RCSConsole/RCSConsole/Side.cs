using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Side
    {
        public CubePiece[] pieces = new CubePiece[9];
        public CornerPiece[] cPieces = new CornerPiece[4];
        public SidePiece[] sPieces = new SidePiece[4];
        public CenterPiece cPiece;
    }
}
