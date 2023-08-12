using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSv2
{
    enum Color
    {
        Red,
        Green,
        Orange,
        Blue,
        Yellow,
        White
    }

    enum Side
    {
        Front,
        Right,
        Back,
        Left,
        Up,
        Down
    }

    enum Move
    {
        U,
        Up,
        U2,
        Uw,
        Uwp,
        Uw2,
        D,
        Dp,
        D2,
        Dw,
        Dwp,
        Dw2,
        R,
        Rp,
        R2,
        Rw,
        Rwp,
        Rw2,
        L,
        Lp,
        L2,
        Lw,
        Lwp,
        Lw2,
        F,
        Fp,
        F2,
        Fw,
        Fwp,
        Fw2,
        B,
        Bp,
        B2,
        Bw,
        Bwp,
        Bw2,
        M,
        Mp,
        M2,
        E,
        Ep,
        E2,
        S,
        Sp,
        S2,
        X,
        Xp,
        X2,
        Y,
        Yp,
        Y2,
        Z,
        Zp,
        Z2
    }

    static class EnumUtils
    {
        static public Move GetOppositeMove(Move move)
        {
            string moveString = move.ToString();
            if (moveString.Contains("p"))
            {
                return Enum.Parse<Move>(moveString.Substring(0, moveString.Length - 1));
            }
            else if (moveString.Contains("2"))
            {
                return move;
            }
            else
            {
                return Enum.Parse<Move>(moveString + "p");
            }
        }
    }
}
