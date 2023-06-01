using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
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
        RotationX,
        RotationXp,
        RotationX2,
        RotationY,
        RotationYp,
        RotationY2,
        RotationZ,
        RotationZp,
        RotationZ2
    }

    static class MoveExtensions
    {
        public static string ToCustomString(this Move move)
        {
            switch (move)
            {
                case Move.Up:
                    return "U'";
                case Move.Uwp:
                    return "Uw'";
                case Move.Dp:
                    return "D'";
                case Move.Dwp:
                    return "Dw'";
                case Move.Rp:
                    return "R'";
                case Move.Rwp:
                    return "Rw'";
                case Move.Lp:
                    return "L'";
                case Move.Lwp:
                    return "Lw'";
                case Move.Fp:
                    return "F'";
                case Move.Fwp:
                    return "Fw'";
                case Move.Bp:
                    return "B'";
                case Move.Bwp:
                    return "Bw'";
                case Move.RotationX:
                    return "x";
                case Move.RotationXp:
                    return "x'";
                case Move.RotationX2:
                    return "x2";
                case Move.RotationY:
                    return "y";
                case Move.RotationYp:
                    return "y'";
                case Move.RotationY2:
                    return "y2";
                case Move.RotationZ:
                    return "z";
                case Move.RotationZp:
                    return "z'";
                case Move.RotationZ2:
                    return "z2";
                default:
                    return move.ToString();
            }
        }
    }
}
