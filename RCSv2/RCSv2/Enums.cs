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
        White,
        None,
        Solved
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

        static public string MoveToString(Move move)
        {
            switch (move)
            {
                case Move.Up:
                case Move.Dp:
                case Move.Rp:
                case Move.Lp:
                case Move.Fp:
                case Move.Bp:
                case Move.Mp:
                case Move.Ep:
                case Move.Sp:
                case Move.Xp:
                case Move.Yp:
                case Move.Zp:
                    return move.ToString().Replace("p", "'");
                case Move.Uw:
                case Move.Uwp:
                case Move.Uw2:
                    return move.ToString().Replace("Uw", "u").Replace("p", "'");
                case Move.Dw:
                case Move.Dwp:
                case Move.Dw2:
                    return move.ToString().Replace("Dw", "d").Replace("p", "'");
                case Move.Rw:
                case Move.Rwp:
                case Move.Rw2:
                    return move.ToString().Replace("Rw", "r").Replace("p", "'");
                case Move.Lw:
                case Move.Lwp:
                case Move.Lw2:
                    return move.ToString().Replace("Lw", "l").Replace("p", "'");
                case Move.Fw:
                case Move.Fwp:
                case Move.Fw2:
                    return move.ToString().Replace("Fw", "f").Replace("p", "'");
                case Move.Bw:
                case Move.Bwp:
                case Move.Bw2:
                    return move.ToString().Replace("Bw", "b").Replace("p", "'");
                default:
                    return move.ToString();
            }
        }

        static public string ColorToACJSColor(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    return "r";
                case Color.Green:
                    return "g";
                case Color.Orange:
                    return "o";
                case Color.Blue:
                    return "b";
                case Color.Yellow:
                    return "y";
                case Color.White:
                    return "w";
                default:
                    return "d";
            }
        }
    }
}
