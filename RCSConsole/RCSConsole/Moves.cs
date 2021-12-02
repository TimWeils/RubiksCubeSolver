using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Moves
    {
        public static void U(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yU(cube);
            }
            else if (cube.topC == Color.White)
            {
                yD(cube);
            }
            else if (cube.frontC == Color.Yellow || cube.frontC == Color.White)
            {
                yR(cube, Modulo.sIntMod(cube.topC - 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yR(cube, (int)cube.frontC);
            }
            else
            {
                yR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
        }

        private static void yU(Cube cube)
        {
            RotateSideClockwise(cube.sides[4]);

            CubePiece p1 = cube.sides[0].pieces[0];
            CubePiece p2 = cube.sides[0].pieces[1];
            CubePiece p3 = cube.sides[0].pieces[2];

            for (int i = 0; i <= 2; i++)
            {
                cube.sides[i].pieces[0] = cube.sides[i + 1].pieces[0];
                cube.sides[i].pieces[1] = cube.sides[i + 1].pieces[1];
                cube.sides[i].pieces[2] = cube.sides[i + 1].pieces[2];
            }

            cube.sides[3].pieces[0] = p1;
            cube.sides[3].pieces[1] = p2;
            cube.sides[3].pieces[2] = p3;
        }

        public static void oU(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yoU(cube);
            }
            else if (cube.topC == Color.White)
            {
                yoD(cube);
            }
            else if (cube.frontC == Color.Yellow || cube.frontC == Color.White)
            {
                yoR(cube, Modulo.sIntMod(cube.topC - 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yoR(cube, (int)cube.frontC);
            }
            else
            {
                yoR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
        }

        private static void yoU(Cube cube)
        {
            RotateSideCounterclockwise(cube.sides[4]);

            CubePiece p1 = cube.sides[0].pieces[0];
            CubePiece p2 = cube.sides[0].pieces[1];
            CubePiece p3 = cube.sides[0].pieces[2];

            for (int i = 3; i >= 1; i--)
            {
                cube.sides[(i + 1) % 4].pieces[0] = cube.sides[i].pieces[0];
                cube.sides[(i + 1) % 4].pieces[1] = cube.sides[i].pieces[1];
                cube.sides[(i + 1) % 4].pieces[2] = cube.sides[i].pieces[2];
            }

            cube.sides[1].pieces[0] = p1;
            cube.sides[1].pieces[1] = p2;
            cube.sides[1].pieces[2] = p3;
        }

        public static void D(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yD(cube);
            }
            else if (cube.topC == Color.White)
            {
                yU(cube);
            }
            else if (cube.frontC == Color.Yellow || cube.frontC == Color.White)
            {
                yR(cube, Modulo.sIntMod(cube.topC + 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
            else
            {
                yR(cube, (int)cube.frontC);
            }
        }

        private static void yD(Cube cube)
        {
            RotateSideClockwise(cube.sides[5]);

            CubePiece p1 = cube.sides[0].pieces[6];
            CubePiece p2 = cube.sides[0].pieces[7];
            CubePiece p3 = cube.sides[0].pieces[8];

            for (int i = 3; i >= 1; i--)
            {
                cube.sides[(i + 1) % 4].pieces[6] = cube.sides[i].pieces[6];
                cube.sides[(i + 1) % 4].pieces[7] = cube.sides[i].pieces[7];
                cube.sides[(i + 1) % 4].pieces[8] = cube.sides[i].pieces[8];
            }

            cube.sides[1].pieces[6] = p1;
            cube.sides[1].pieces[7] = p2;
            cube.sides[1].pieces[8] = p3;
        }

        public static void oD(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yoD(cube);
            }
            else if (cube.topC == Color.White)
            {
                yoU(cube);
            }
            else if (cube.frontC == Color.Yellow || cube.frontC == Color.White)
            {
                yoR(cube, Modulo.sIntMod(cube.topC + 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yoR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
            else
            {
                yoR(cube, (int)cube.frontC);
            }
        }

        private static void yoD(Cube cube)
        {
            RotateSideCounterclockwise(cube.sides[5]);

            CubePiece p1 = cube.sides[0].pieces[6];
            CubePiece p2 = cube.sides[0].pieces[7];
            CubePiece p3 = cube.sides[0].pieces[8];

            for (int i = 0; i <= 2; i++)
            {
                cube.sides[i].pieces[6] = cube.sides[i + 1].pieces[6];
                cube.sides[i].pieces[7] = cube.sides[i + 1].pieces[7];
                cube.sides[i].pieces[8] = cube.sides[i + 1].pieces[8];
            }

            cube.sides[3].pieces[6] = p1;
            cube.sides[3].pieces[7] = p2;
            cube.sides[3].pieces[8] = p3;
        } 

        public static void R(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yR(cube, (int)cube.frontC);
            }
            else if (cube.frontC == Color.Yellow)
            {
                yR(cube, Modulo.sIntMod(cube.topC + 2));
            }
            else if (cube.topC == Color.White)
            {
                yR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.frontC == Color.White)
            {
                yR(cube, (int)cube.topC);
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yD(cube);
            }
            else
            {
                yU(cube);
            }
        }

        private static void yR(Cube cube, int frontSide)
        {
            int backSide = (frontSide + 2) % 4;
            int rightSide = (frontSide + 1) % 4;

            RotateSideClockwise(cube.sides[rightSide]);

            int[] YCoordinates = Cube.GetYCoordinates((Color)frontSide);
            int[] WCoordinates = Cube.GetWCoordinates((Color)frontSide);

            CubePiece p1 = cube.sides[frontSide].pieces[2];
            CubePiece p2 = cube.sides[frontSide].pieces[5];
            CubePiece p3 = cube.sides[frontSide].pieces[8];

            cube.sides[frontSide].pieces[2] = cube.sides[5].pieces[WCoordinates[2]];
            cube.sides[frontSide].pieces[5] = cube.sides[5].pieces[WCoordinates[5]];
            cube.sides[frontSide].pieces[8] = cube.sides[5].pieces[WCoordinates[8]];

            cube.sides[5].pieces[WCoordinates[2]] = cube.sides[backSide].pieces[6];
            cube.sides[5].pieces[WCoordinates[5]] = cube.sides[backSide].pieces[3];
            cube.sides[5].pieces[WCoordinates[8]] = cube.sides[backSide].pieces[0];

            cube.sides[backSide].pieces[6] = cube.sides[4].pieces[YCoordinates[2]];
            cube.sides[backSide].pieces[3] = cube.sides[4].pieces[YCoordinates[5]];
            cube.sides[backSide].pieces[0] = cube.sides[4].pieces[YCoordinates[8]];

            cube.sides[4].pieces[YCoordinates[2]] = p1;
            cube.sides[4].pieces[YCoordinates[5]] = p2;
            cube.sides[4].pieces[YCoordinates[8]] = p3;
        }

        public static void oR(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yoR(cube, (int)cube.frontC);
            }
            else if (cube.frontC == Color.Yellow)
            {
                yoR(cube, Modulo.sIntMod(cube.topC + 2));
            }
            else if (cube.topC == Color.White)
            {
                yoR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.frontC == Color.White)
            {
                yoR(cube, (int)cube.topC);
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yoD(cube);
            }
            else
            {
                yoU(cube);
            }
        }

        private static void yoR(Cube cube, int frontSide)
        {
            int backSide = (frontSide + 2) % 4;
            int rightSide = (frontSide + 1) % 4;

            RotateSideCounterclockwise(cube.sides[rightSide]);

            int[] YCoordinates = Cube.GetYCoordinates((Color)frontSide);
            int[] WCoordinates = Cube.GetWCoordinates((Color)frontSide);

            CubePiece p1 = cube.sides[frontSide].pieces[2];
            CubePiece p2 = cube.sides[frontSide].pieces[5];
            CubePiece p3 = cube.sides[frontSide].pieces[8];

            cube.sides[frontSide].pieces[2] = cube.sides[4].pieces[YCoordinates[2]];
            cube.sides[frontSide].pieces[5] = cube.sides[4].pieces[YCoordinates[5]];
            cube.sides[frontSide].pieces[8] = cube.sides[4].pieces[YCoordinates[8]];

            cube.sides[4].pieces[YCoordinates[2]] = cube.sides[backSide].pieces[6];
            cube.sides[4].pieces[YCoordinates[5]] = cube.sides[backSide].pieces[3];
            cube.sides[4].pieces[YCoordinates[8]] = cube.sides[backSide].pieces[0];

            cube.sides[backSide].pieces[6] = cube.sides[5].pieces[WCoordinates[2]];
            cube.sides[backSide].pieces[3] = cube.sides[5].pieces[WCoordinates[5]];
            cube.sides[backSide].pieces[0] = cube.sides[5].pieces[WCoordinates[8]];

            cube.sides[5].pieces[WCoordinates[2]] = p1;
            cube.sides[5].pieces[WCoordinates[5]] = p2;
            cube.sides[5].pieces[WCoordinates[8]] = p3;
        }

        private static void RotateSideClockwise(Side side)
        {
            CubePiece p1 = side.pieces[0];
            CubePiece p2 = side.pieces[1];

            side.pieces[0] = side.pieces[6];
            side.pieces[6] = side.pieces[8];
            side.pieces[8] = side.pieces[2];
            side.pieces[2] = p1;

            side.pieces[1] = side.pieces[3];
            side.pieces[3] = side.pieces[7];
            side.pieces[7] = side.pieces[5];
            side.pieces[5] = p2;
        }

        private static void RotateSideCounterclockwise(Side side)
        {
            CubePiece p1 = side.pieces[0];
            CubePiece p2 = side.pieces[1];

            side.pieces[0] = side.pieces[2];
            side.pieces[2] = side.pieces[8];
            side.pieces[8] = side.pieces[6];
            side.pieces[6] = p1;

            side.pieces[1] = side.pieces[5];
            side.pieces[5] = side.pieces[7];
            side.pieces[7] = side.pieces[3];
            side.pieces[3] = p2;
        }

        public static void L(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.frontC == Color.Yellow)
            {
                yR(cube, (int)cube.topC);
            }
            else if (cube.topC == Color.White)
            {
                yR(cube, (int)cube.frontC);
            }
            else if (cube.frontC == Color.White)
            {
                yR(cube, Modulo.sIntMod(cube.topC + 2));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yU(cube);
            }
            else
            {
                yD(cube);
            }
        }

        public static void oL(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yoR(cube, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.frontC == Color.Yellow)
            {
                yoR(cube, (int)cube.topC);
            }
            else if (cube.topC == Color.White)
            {
                yoR(cube, (int)cube.frontC);
            }
            else if (cube.frontC == Color.White)
            {
                yoR(cube, Modulo.sIntMod(cube.topC + 2));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yoU(cube);
            }
            else
            {
                yoD(cube);
            }
        }

        public static void F(Cube cube)
        {
            if (cube.frontC == Color.Yellow)
            {
                yU(cube);
            }
            else if (cube.frontC == Color.White)
            {
                yD(cube);
            }
            else
            {
                yR(cube, Modulo.sIntMod(cube.frontC - 1));
            }
        }

        public static void oF(Cube cube)
        {
            if (cube.frontC == Color.Yellow)
            {
                yoU(cube);
            }
            else if (cube.frontC == Color.White)
            {
                yoD(cube);
            }
            else
            {
                yoR(cube, Modulo.sIntMod(cube.frontC - 1));
            }
        }

        public static void B(Cube cube)
        {
            if (cube.frontC == Color.Yellow)
            {
                yD(cube);
            }
            else if (cube.frontC == Color.White)
            {
                yU(cube);
            }
            else
            {
                yR(cube, Modulo.sIntMod(cube.frontC + 1));
            }
        }

        public static void oB(Cube cube)
        {
            if (cube.frontC == Color.Yellow)
            {
                yoD(cube);
            }
            else if (cube.frontC == Color.White)
            {
                yoU(cube);
            }
            else
            {
                yoR(cube, Modulo.sIntMod(cube.frontC + 1));
            }
        }

        public static void U2(Cube cube)
        {
            U(cube);
            U(cube);
        }

        public static void D2(Cube cube)
        {
            D(cube);
            D(cube);
        }

        public static void R2(Cube cube)
        {
            R(cube);
            R(cube);
        }

        public static void L2(Cube cube)
        {
            L(cube);
            L(cube);
        }

        public static void F2(Cube cube)
        {
            F(cube);
            F(cube);
        }

        public static void B2(Cube cube)
        {
            B(cube);
            B(cube);
        }

        public static void RotationX(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                cube.topC = cube.frontC;
                cube.frontC = Color.White;
            }
            else if (cube.topC == Color.White)
            {
                cube.topC = cube.frontC;
                cube.frontC = Color.Yellow;
            }
            else if (cube.frontC == Color.Yellow)
            {
                cube.frontC = Modulo.sColorMod(cube.topC + 2);
                cube.topC = Color.Yellow;
            }
            else if (cube.frontC == Color.White)
            {
                cube.frontC = Modulo.sColorMod(cube.topC + 2);
                cube.topC = Color.White;
            }
            else
            {
                Color c = cube.topC;
                cube.topC = cube.frontC;
                cube.frontC = Modulo.sColorMod(c + 2);
            }
        }

        public static void oRotationX(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                cube.topC = Modulo.sColorMod(cube.frontC + 2);
                cube.frontC = Color.Yellow;
            }
            else if (cube.topC == Color.White)
            {
                cube.topC = Modulo.sColorMod(cube.frontC + 2);
                cube.frontC = Color.White;
            }
            else if (cube.frontC == Color.Yellow)
            {
                cube.frontC = cube.topC;
                cube.topC = Color.White;
            }
            else if (cube.frontC == Color.White)
            {
                cube.frontC = cube.topC;
                cube.topC = Color.Yellow;
            }
            else
            {
                Color c = cube.topC;
                cube.topC = Modulo.sColorMod(cube.frontC + 2);
                cube.frontC = c;
            }
        }

        public static void RotationY(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC + 1);
            }
            else if (cube.topC == Color.White)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC - 1);
            }
            else if (cube.frontC == Color.Yellow)
            {
                cube.frontC = Modulo.sColorMod(cube.topC - 1);
            }
            else if (cube.frontC == Color.White)
            {
                cube.frontC = Modulo.sColorMod(cube.topC + 1);
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                cube.frontC = Color.White;
            }
            else
            {
                cube.frontC = Color.Yellow;
            }
        }

        public static void oRotationY(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC - 1);
            }
            else if (cube.topC == Color.White)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC + 1);
            }
            else if (cube.frontC == Color.Yellow)
            {
                cube.frontC = Modulo.sColorMod(cube.topC + 1);
            }
            else if (cube.frontC == Color.White)
            {
                cube.frontC = Modulo.sColorMod(cube.topC - 1);
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                cube.frontC = Color.Yellow;
            }
            else
            {
                cube.frontC = Color.White;
            }
        }

        public static void RotationZ(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                cube.topC = Modulo.sColorMod(cube.frontC - 1);
            }
            else if (cube.topC == Color.White)
            {
                cube.topC = Modulo.sColorMod(cube.frontC + 1);
            }
            else if (cube.frontC == Color.Yellow)
            {
                cube.topC = Modulo.sColorMod(cube.topC + 1);
            }
            else if (cube.frontC == Color.White)
            {
                cube.topC = Modulo.sColorMod(cube.topC - 1);
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                cube.topC = Color.Yellow;
            }
            else
            {
                cube.topC = Color.White;
            }
        }

        public static void oRotationZ(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                cube.topC = Modulo.sColorMod(cube.frontC + 1);
            }
            else if (cube.topC == Color.White)
            {
                cube.topC = Modulo.sColorMod(cube.frontC - 1);
            }
            else if (cube.frontC == Color.Yellow)
            {
                cube.topC = Modulo.sColorMod(cube.topC - 1);
            }
            else if (cube.frontC == Color.White)
            {
                cube.topC = Modulo.sColorMod(cube.topC + 1);
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                cube.topC = Color.White;
            }
            else
            {
                cube.topC = Color.Yellow;
            }
        }

        public static void RotationX2(Cube cube)
        {
            RotationX(cube);
            RotationX(cube);
        }

        public static void RotationY2(Cube cube)
        {
            RotationY(cube);
            RotationY(cube);
        }

        public static void RotationZ2(Cube cube)
        {
            RotationZ(cube);
            RotationZ(cube);
        }

        public static void Uw(Cube cube)
        {
            RotationY(cube);
            D(cube);
        }

        public static void oUw(Cube cube)
        {
            oRotationY(cube);
            oD(cube);
        }

        public static void Dw(Cube cube)
        {
            oRotationY(cube);
            U(cube);
        }

        public static void oDw(Cube cube)
        {
            RotationY(cube);
            oU(cube);
        }

        public static void Rw(Cube cube)
        {
            RotationX(cube);
            L(cube);
        }

        public static void oRw(Cube cube)
        {
            oRotationX(cube);
            oL(cube);
        }

        public static void Lw(Cube cube)
        {
            oRotationX(cube);
            R(cube);
        }

        public static void oLw(Cube cube)
        {
            RotationX(cube);
            oR(cube);
        }

        public static void Fw(Cube cube)
        {
            RotationZ(cube);
            B(cube);
        }

        public static void oFw(Cube cube)
        {
            oRotationZ(cube);
            oB(cube);
        }

        public static void Bw(Cube cube)
        {
            oRotationZ(cube);
            F(cube);
        }

        public static void oBw(Cube cube)
        {
            RotationZ(cube);
            oF(cube);
        }

        public static void Uw2(Cube cube)
        {
            Uw(cube);
            Uw(cube);
        }

        public static void Dw2(Cube cube)
        {
            Dw(cube);
            Dw(cube);
        }

        public static void Rw2(Cube cube)
        {
            Rw(cube);
            Rw(cube);
        }

        public static void Lw2(Cube cube)
        {
            Lw(cube);
            Lw(cube);
        }

        public static void Fw2(Cube cube)
        {
            Fw(cube);
            Fw(cube);
        }

        public static void Bw2(Cube cube)
        {
            Bw(cube);
            Bw(cube);
        }

        public static void M(Cube cube)
        {
            oRotationX(cube);
            oL(cube);
            R(cube);
        }

        public static void oM(Cube cube)
        {
            RotationX(cube);
            L(cube);
            oR(cube);
        }

        public static void E(Cube cube)
        {
            oRotationY(cube);
            U(cube);
            oD(cube);
        }

        public static void oE(Cube cube)
        {
            RotationY(cube);
            oU(cube);
            D(cube);
        }

        public static void S(Cube cube)
        {
            RotationZ(cube);
            oF(cube);
            B(cube);
        }

        public static void oS(Cube cube)
        {
            oRotationZ(cube);
            F(cube);
            oB(cube);
        }

        public static void M2(Cube cube)
        {
            M(cube);
            M(cube);
        }

        public static void E2(Cube cube)
        {
            E(cube);
            E(cube);
        }

        public static void S2(Cube cube)
        {
            S(cube);
            S(cube);
        }
    }
}
