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
                yR(cube, Modulo.sIntMod(cube.topC - 1), Modulo.sIntMod(cube.topC + 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else
            {
                yL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
        }

        private static void yU(Cube cube)
        {
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

            /*/
            CornerPiece tmpC1 = cube.sides[0].cPieces[0];
            SidePiece tmpS1 = cube.sides[0].sPieces[0];
            CornerPiece tmpC2 = cube.sides[0].cPieces[1];

            for (int i = 0; i <= 2; i++)
            {
                cube.sides[i].cPieces[0] = cube.sides[i + 1].cPieces[0];
                cube.sides[i].sPieces[0] = cube.sides[i + 1].sPieces[0];
                cube.sides[i].cPieces[1] = cube.sides[i + 1].cPieces[1];
            }

            cube.sides[3].cPieces[0] = tmpC1;
            cube.sides[3].sPieces[0] = tmpS1;
            cube.sides[3].cPieces[1] = tmpC2;
            /**/
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
                yoR(cube, Modulo.sIntMod(cube.topC - 1), Modulo.sIntMod(cube.topC + 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yoR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else
            {
                yoL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
        }

        private static void yoU(Cube cube)
        {
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
            cube.sides[1].pieces[0] = p2;
            cube.sides[1].pieces[1] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[0].cPieces[0];
            SidePiece tmpS1 = cube.sides[0].sPieces[0];
            CornerPiece tmpC2 = cube.sides[0].cPieces[1];

            for (int i = 3; i >= 1; i--)
            {
                cube.sides[(i + 1) % 4].cPieces[0] = cube.sides[i].cPieces[0];
                cube.sides[(i + 1) % 4].sPieces[0] = cube.sides[i].sPieces[0];
                cube.sides[(i + 1) % 4].cPieces[1] = cube.sides[i].cPieces[1];
            }

            cube.sides[1].cPieces[0] = tmpC1;
            cube.sides[1].sPieces[0] = tmpS1;
            cube.sides[1].cPieces[1] = tmpC2;
            /**/
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
                yL(cube, Modulo.sIntMod(cube.topC - 1), Modulo.sIntMod(cube.topC + 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else
            {
                yR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
        }

        private static void yD(Cube cube)
        {
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

            /*/
            CornerPiece tmpC1 = cube.sides[0].cPieces[2];
            SidePiece tmpS1 = cube.sides[0].sPieces[3];
            CornerPiece tmpC2 = cube.sides[0].cPieces[3];

            for (int i = 3; i >= 1; i--)
            {
                cube.sides[(i + 1) % 4].cPieces[2] = cube.sides[i].cPieces[2];
                cube.sides[(i + 1) % 4].sPieces[3] = cube.sides[i].sPieces[3];
                cube.sides[(i + 1) % 4].cPieces[3] = cube.sides[i].cPieces[3];
            }

            cube.sides[1].cPieces[2] = tmpC1;
            cube.sides[1].sPieces[3] = tmpS1;
            cube.sides[1].cPieces[3] = tmpC2;
            /**/
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
                yoL(cube, Modulo.sIntMod(cube.topC - 1), Modulo.sIntMod(cube.topC + 1));
            }
            // if Yellow is on the left side
            else if (cube.topC == Modulo.sColorMod(cube.frontC + 1))
            {
                yoL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else
            {
                yoR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
        }

        private static void yoD(Cube cube)
        {
            CubePiece p1 = cube.sides[0].pieces[6];
            CubePiece p2 = cube.sides[0].pieces[7];
            CubePiece p3 = cube.sides[0].pieces[8];

            for (int i = 0; i <= 2; i++)
            {
                cube.sides[i].pieces[6] = cube.sides[i + 1].pieces[6];
                cube.sides[i].pieces[7] = cube.sides[i + 1].pieces[7];
                cube.sides[i].pieces[8] = cube.sides[i + 1].pieces[8];
            }

            cube.sides[3].pieces[2] = p1;
            cube.sides[3].pieces[3] = p2;
            cube.sides[3].pieces[3] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[0].cPieces[2];
            SidePiece tmpS1 = cube.sides[0].sPieces[3];
            CornerPiece tmpC2 = cube.sides[0].cPieces[3];

            for (int i = 0; i <= 2; i++)
            {
                cube.sides[i].cPieces[2] = cube.sides[i + 1].cPieces[2];
                cube.sides[i].sPieces[3] = cube.sides[i + 1].sPieces[3];
                cube.sides[i].cPieces[3] = cube.sides[i + 1].cPieces[3];
            }

            cube.sides[3].cPieces[2] = tmpC1;
            cube.sides[3].sPieces[3] = tmpS1;
            cube.sides[3].cPieces[3] = tmpC2;
            /**/
        } 

        public static void R(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.topC == Color.White)
            {
                yL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
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

        private static void yR(Cube cube, int frontSide, int backSide)
        {
            CubePiece p1 = cube.sides[frontSide].pieces[2];
            CubePiece p2 = cube.sides[frontSide].pieces[5];
            CubePiece p3 = cube.sides[frontSide].pieces[8];

            cube.sides[frontSide].pieces[2] = cube.sides[5].pieces[2];
            cube.sides[frontSide].pieces[5] = cube.sides[5].pieces[5];
            cube.sides[frontSide].pieces[8] = cube.sides[5].pieces[8];

            cube.sides[5].pieces[2] = cube.sides[backSide].pieces[0];
            cube.sides[5].pieces[5] = cube.sides[backSide].pieces[3];
            cube.sides[5].pieces[8] = cube.sides[backSide].pieces[6];

            cube.sides[backSide].pieces[0] = cube.sides[4].pieces[2];
            cube.sides[backSide].pieces[3] = cube.sides[4].pieces[5];
            cube.sides[backSide].pieces[6] = cube.sides[4].pieces[8];

            cube.sides[4].pieces[2] = p1;
            cube.sides[4].pieces[5] = p2;
            cube.sides[4].pieces[8] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[frontSide].cPieces[1];
            SidePiece tmpS1 = cube.sides[frontSide].sPieces[2];
            CornerPiece tmpC2 = cube.sides[frontSide].cPieces[3];

            cube.sides[frontSide].cPieces[1] = cube.sides[5].cPieces[1];
            cube.sides[frontSide].sPieces[2] = cube.sides[5].sPieces[2];
            cube.sides[frontSide].cPieces[3] = cube.sides[5].cPieces[3];

            cube.sides[5].cPieces[1] = cube.sides[backSide].cPieces[0];
            cube.sides[5].sPieces[2] = cube.sides[backSide].sPieces[1];
            cube.sides[5].cPieces[3] = cube.sides[backSide].cPieces[2];

            cube.sides[backSide].cPieces[0] = cube.sides[4].cPieces[1];
            cube.sides[backSide].sPieces[1] = cube.sides[4].sPieces[2];
            cube.sides[backSide].cPieces[2] = cube.sides[4].cPieces[3];

            cube.sides[4].cPieces[1] = tmpC1;
            cube.sides[4].sPieces[2] = tmpS1;
            cube.sides[4].cPieces[3] = tmpC2;
            /**/
        }

        public static void oR(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yoR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.topC == Color.White)
            {
                yoL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
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

        private static void yoR(Cube cube, int frontSide, int backSide)
        {
            CubePiece p1 = cube.sides[frontSide].pieces[2];
            CubePiece p2 = cube.sides[frontSide].pieces[5];
            CubePiece p3 = cube.sides[frontSide].pieces[8];

            cube.sides[frontSide].pieces[2] = cube.sides[4].pieces[2];
            cube.sides[frontSide].pieces[5] = cube.sides[4].pieces[5];
            cube.sides[frontSide].pieces[8] = cube.sides[4].pieces[8];

            cube.sides[4].pieces[2] = cube.sides[backSide].pieces[0];
            cube.sides[4].pieces[5] = cube.sides[backSide].pieces[3];
            cube.sides[4].pieces[8] = cube.sides[backSide].pieces[6];

            cube.sides[backSide].pieces[0] = cube.sides[5].pieces[2];
            cube.sides[backSide].pieces[3] = cube.sides[5].pieces[5];
            cube.sides[backSide].pieces[6] = cube.sides[5].pieces[8];

            cube.sides[5].pieces[2] = p1;
            cube.sides[5].pieces[5] = p2;
            cube.sides[5].pieces[8] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[frontSide].cPieces[1];
            SidePiece tmpS1 = cube.sides[frontSide].sPieces[2];
            CornerPiece tmpC2 = cube.sides[frontSide].cPieces[3];

            cube.sides[frontSide].cPieces[1] = cube.sides[4].cPieces[1];
            cube.sides[frontSide].sPieces[2] = cube.sides[4].sPieces[2];
            cube.sides[frontSide].cPieces[3] = cube.sides[4].cPieces[3];

            cube.sides[4].cPieces[1] = cube.sides[backSide].cPieces[0];
            cube.sides[4].sPieces[2] = cube.sides[backSide].sPieces[1];
            cube.sides[4].cPieces[3] = cube.sides[backSide].cPieces[2];

            cube.sides[backSide].cPieces[0] = cube.sides[5].cPieces[1];
            cube.sides[backSide].sPieces[1] = cube.sides[5].sPieces[2];
            cube.sides[backSide].cPieces[2] = cube.sides[5].cPieces[3];

            cube.sides[5].cPieces[1] = tmpC1;
            cube.sides[5].sPieces[2] = tmpS1;
            cube.sides[5].cPieces[3] = tmpC2;
            /**/
        }

        public static void L(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.topC == Color.White)
            {
                yR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
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

        private static void yL(Cube cube, int frontSide, int backSide)
        {
            CubePiece p1 = cube.sides[frontSide].pieces[0];
            CubePiece p2 = cube.sides[frontSide].pieces[3];
            CubePiece p3 = cube.sides[frontSide].pieces[6];

            cube.sides[frontSide].pieces[0] = cube.sides[4].pieces[0];
            cube.sides[frontSide].pieces[3] = cube.sides[4].pieces[3];
            cube.sides[frontSide].pieces[6] = cube.sides[4].pieces[6];

            cube.sides[4].pieces[0] = cube.sides[backSide].pieces[2];
            cube.sides[4].pieces[3] = cube.sides[backSide].pieces[5];
            cube.sides[4].pieces[6] = cube.sides[backSide].pieces[8];

            cube.sides[backSide].pieces[2] = cube.sides[5].pieces[0];
            cube.sides[backSide].pieces[5] = cube.sides[5].pieces[3];
            cube.sides[backSide].pieces[8] = cube.sides[5].pieces[6];

            cube.sides[5].pieces[0] = p1;
            cube.sides[5].pieces[1] = p2;
            cube.sides[5].pieces[2] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[frontSide].cPieces[0];
            SidePiece tmpS1 = cube.sides[frontSide].sPieces[1];
            CornerPiece tmpC2 = cube.sides[frontSide].cPieces[2];

            cube.sides[frontSide].cPieces[0] = cube.sides[4].cPieces[0];
            cube.sides[frontSide].sPieces[1] = cube.sides[4].sPieces[1];
            cube.sides[frontSide].cPieces[2] = cube.sides[4].cPieces[2];

            cube.sides[4].cPieces[0] = cube.sides[backSide].cPieces[1];
            cube.sides[4].sPieces[1] = cube.sides[backSide].sPieces[2];
            cube.sides[4].cPieces[2] = cube.sides[backSide].cPieces[3];

            cube.sides[backSide].cPieces[1] = cube.sides[5].cPieces[0];
            cube.sides[backSide].sPieces[2] = cube.sides[5].sPieces[1];
            cube.sides[backSide].cPieces[3] = cube.sides[5].cPieces[2];

            cube.sides[5].cPieces[0] = tmpC1;
            cube.sides[5].sPieces[1] = tmpS1;
            cube.sides[5].cPieces[2] = tmpC2;
            /**/
        }

        public static void oL(Cube cube)
        {
            if (cube.topC == Color.Yellow)
            {
                yoL(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
            }
            else if (cube.topC == Color.White)
            {
                yoR(cube, (int)cube.frontC, Modulo.sIntMod(cube.frontC + 2));
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

        private static void yoL(Cube cube, int frontSide, int backSide)
        {
            CubePiece p1 = cube.sides[frontSide].pieces[0];
            CubePiece p2 = cube.sides[frontSide].pieces[3];
            CubePiece p3 = cube.sides[frontSide].pieces[6];

            cube.sides[frontSide].pieces[0] = cube.sides[5].pieces[0];
            cube.sides[frontSide].pieces[3] = cube.sides[5].pieces[3];
            cube.sides[frontSide].pieces[6] = cube.sides[5].pieces[6];

            cube.sides[5].pieces[0] = cube.sides[backSide].pieces[2];
            cube.sides[5].pieces[3] = cube.sides[backSide].pieces[5];
            cube.sides[5].pieces[6] = cube.sides[backSide].pieces[8];

            cube.sides[backSide].pieces[2] = cube.sides[4].pieces[0];
            cube.sides[backSide].pieces[5] = cube.sides[4].pieces[3];
            cube.sides[backSide].pieces[8] = cube.sides[4].pieces[6];

            cube.sides[4].pieces[0] = p1;
            cube.sides[4].pieces[3] = p2;
            cube.sides[4].pieces[6] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[frontSide].cPieces[0];
            SidePiece tmpS1 = cube.sides[frontSide].sPieces[1];
            CornerPiece tmpC2 = cube.sides[frontSide].cPieces[2];

            cube.sides[frontSide].cPieces[0] = cube.sides[5].cPieces[0];
            cube.sides[frontSide].sPieces[1] = cube.sides[5].sPieces[1];
            cube.sides[frontSide].cPieces[2] = cube.sides[5].cPieces[2];

            cube.sides[5].cPieces[0] = cube.sides[backSide].cPieces[1];
            cube.sides[5].sPieces[1] = cube.sides[backSide].sPieces[2];
            cube.sides[5].cPieces[2] = cube.sides[backSide].cPieces[3];

            cube.sides[backSide].cPieces[1] = cube.sides[4].cPieces[0];
            cube.sides[backSide].sPieces[2] = cube.sides[4].sPieces[1];
            cube.sides[backSide].cPieces[3] = cube.sides[4].cPieces[2];

            cube.sides[4].cPieces[0] = tmpC1;
            cube.sides[4].sPieces[1] = tmpS1;
            cube.sides[4].cPieces[2] = tmpC2;
            /**/
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
                //yF(cube, Modulo.sIntMod(cube.frontC - 1), Modulo.sIntMod(cube.frontC + 1));
                yR(cube, Modulo.sIntMod(cube.frontC - 1), Modulo.sIntMod(cube.frontC + 1));
            }
        }

        private static void yF(Cube cube, int leftSide, int rightSide)
        {
            CubePiece p1 = cube.sides[leftSide].pieces[2];
            CubePiece p2 = cube.sides[leftSide].pieces[5];
            CubePiece p3 = cube.sides[leftSide].pieces[8];

            cube.sides[leftSide].pieces[2] = cube.sides[5].pieces[0];
            cube.sides[leftSide].pieces[5] = cube.sides[5].pieces[1];
            cube.sides[leftSide].pieces[8] = cube.sides[5].pieces[2];

            cube.sides[5].pieces[0] = cube.sides[rightSide].pieces[0];
            cube.sides[5].pieces[1] = cube.sides[rightSide].pieces[3];
            cube.sides[5].pieces[2] = cube.sides[rightSide].pieces[6];

            cube.sides[rightSide].pieces[0] = cube.sides[4].pieces[6];
            cube.sides[rightSide].pieces[3] = cube.sides[4].pieces[7];
            cube.sides[rightSide].pieces[6] = cube.sides[4].pieces[8];

            cube.sides[4].pieces[6] = p1;
            cube.sides[4].pieces[7] = p2;
            cube.sides[4].pieces[8] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[leftSide].cPieces[1];
            SidePiece tmpS1 = cube.sides[leftSide].sPieces[2];
            CornerPiece tmpC2 = cube.sides[leftSide].cPieces[3];

            cube.sides[leftSide].cPieces[1] = cube.sides[5].cPieces[0];
            cube.sides[leftSide].sPieces[2] = cube.sides[5].sPieces[0];
            cube.sides[leftSide].cPieces[3] = cube.sides[5].cPieces[1];

            cube.sides[5].cPieces[0] = cube.sides[rightSide].cPieces[0];
            cube.sides[5].sPieces[0] = cube.sides[rightSide].sPieces[1];
            cube.sides[5].cPieces[1] = cube.sides[rightSide].cPieces[2];

            cube.sides[rightSide].cPieces[0] = cube.sides[4].cPieces[2];
            cube.sides[rightSide].sPieces[1] = cube.sides[4].sPieces[3];
            cube.sides[rightSide].cPieces[2] = cube.sides[4].cPieces[3];

            cube.sides[4].cPieces[2] = tmpC1;
            cube.sides[4].sPieces[3] = tmpS1;
            cube.sides[4].cPieces[3] = tmpC2;
            /**/
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
                yoF(cube, Modulo.sIntMod(cube.frontC - 1), Modulo.sIntMod(cube.frontC + 1));
            }
        }

        private static void yoF(Cube cube, int leftSide, int rightSide)
        {
            CubePiece p1 = cube.sides[leftSide].pieces[2];
            CubePiece p2 = cube.sides[leftSide].pieces[5];
            CubePiece p3 = cube.sides[leftSide].pieces[8];

            cube.sides[leftSide].pieces[2] = cube.sides[4].pieces[6];
            cube.sides[leftSide].pieces[5] = cube.sides[4].pieces[7];
            cube.sides[leftSide].pieces[8] = cube.sides[4].pieces[8];

            cube.sides[4].pieces[6] = cube.sides[rightSide].pieces[0];
            cube.sides[4].pieces[7] = cube.sides[rightSide].pieces[3];
            cube.sides[4].pieces[8] = cube.sides[rightSide].pieces[6];

            cube.sides[rightSide].pieces[0] = cube.sides[5].pieces[0];
            cube.sides[rightSide].pieces[3] = cube.sides[5].pieces[1];
            cube.sides[rightSide].pieces[6] = cube.sides[5].pieces[2];

            cube.sides[5].pieces[0] = p1;
            cube.sides[5].pieces[1] = p2;
            cube.sides[5].pieces[2] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[leftSide].cPieces[1];
            SidePiece tmpS1 = cube.sides[leftSide].sPieces[2];
            CornerPiece tmpC2 = cube.sides[leftSide].cPieces[3];

            cube.sides[leftSide].cPieces[1] = cube.sides[4].cPieces[2];
            cube.sides[leftSide].sPieces[2] = cube.sides[4].sPieces[3];
            cube.sides[leftSide].cPieces[3] = cube.sides[4].cPieces[3];

            cube.sides[4].cPieces[2] = cube.sides[rightSide].cPieces[0];
            cube.sides[4].sPieces[3] = cube.sides[rightSide].sPieces[1];
            cube.sides[4].cPieces[3] = cube.sides[rightSide].cPieces[2];

            cube.sides[rightSide].cPieces[0] = cube.sides[5].cPieces[0];
            cube.sides[rightSide].sPieces[1] = cube.sides[5].sPieces[0];
            cube.sides[rightSide].cPieces[2] = cube.sides[5].cPieces[1];

            cube.sides[5].cPieces[0] = tmpC1;
            cube.sides[5].sPieces[0] = tmpS1;
            cube.sides[5].cPieces[1] = tmpC2;
            /**/
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
                yB(cube, Modulo.sIntMod(cube.frontC - 1), Modulo.sIntMod(cube.frontC + 1));
            }
        }

        private static void yB(Cube cube, int leftSide, int rightSide)
        {
            CubePiece p1 = cube.sides[leftSide].pieces[0];
            CubePiece p2 = cube.sides[leftSide].pieces[3];
            CubePiece p3 = cube.sides[leftSide].pieces[6];

            cube.sides[leftSide].pieces[0] = cube.sides[4].pieces[0];
            cube.sides[leftSide].pieces[3] = cube.sides[4].pieces[1];
            cube.sides[leftSide].pieces[6] = cube.sides[4].pieces[2];

            cube.sides[4].pieces[0] = cube.sides[rightSide].pieces[2];
            cube.sides[4].pieces[1] = cube.sides[rightSide].pieces[5];
            cube.sides[4].pieces[2] = cube.sides[rightSide].pieces[8];

            cube.sides[rightSide].pieces[2] = cube.sides[5].pieces[6];
            cube.sides[rightSide].pieces[5] = cube.sides[5].pieces[7];
            cube.sides[rightSide].pieces[8] = cube.sides[5].pieces[8];

            cube.sides[5].pieces[6] = p1;
            cube.sides[5].pieces[7] = p2;
            cube.sides[5].pieces[8] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[leftSide].cPieces[0];
            SidePiece tmpS1 = cube.sides[leftSide].sPieces[1];
            CornerPiece tmpC2 = cube.sides[leftSide].cPieces[2];

            cube.sides[leftSide].cPieces[0] = cube.sides[4].cPieces[0];
            cube.sides[leftSide].sPieces[1] = cube.sides[4].sPieces[0];
            cube.sides[leftSide].cPieces[2] = cube.sides[4].cPieces[1];

            cube.sides[4].cPieces[0] = cube.sides[rightSide].cPieces[1];
            cube.sides[4].sPieces[0] = cube.sides[rightSide].sPieces[2];
            cube.sides[4].cPieces[1] = cube.sides[rightSide].cPieces[3];

            cube.sides[rightSide].cPieces[1] = cube.sides[5].cPieces[2];
            cube.sides[rightSide].sPieces[2] = cube.sides[5].sPieces[3];
            cube.sides[rightSide].cPieces[3] = cube.sides[5].cPieces[3];

            cube.sides[5].cPieces[2] = tmpC1;
            cube.sides[5].sPieces[3] = tmpS1;
            cube.sides[5].cPieces[3] = tmpC2;
            /**/
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
                yoB(cube, Modulo.sIntMod(cube.frontC - 1), Modulo.sIntMod(cube.frontC + 1));
            }
        }

        private static void yoB(Cube cube, int leftSide, int rightSide)
        {
            CubePiece p1 = cube.sides[leftSide].pieces[0];
            CubePiece p2 = cube.sides[leftSide].pieces[3];
            CubePiece p3 = cube.sides[leftSide].pieces[6];

            cube.sides[leftSide].pieces[0] = cube.sides[5].pieces[6];
            cube.sides[leftSide].pieces[3] = cube.sides[5].pieces[7];
            cube.sides[leftSide].pieces[6] = cube.sides[5].pieces[8];

            cube.sides[5].pieces[6] = cube.sides[rightSide].pieces[2];
            cube.sides[5].pieces[7] = cube.sides[rightSide].pieces[5];
            cube.sides[5].pieces[8] = cube.sides[rightSide].pieces[8];

            cube.sides[rightSide].pieces[2] = cube.sides[4].pieces[0];
            cube.sides[rightSide].pieces[5] = cube.sides[4].pieces[1];
            cube.sides[rightSide].pieces[8] = cube.sides[4].pieces[2];

            cube.sides[4].pieces[0] = p1;
            cube.sides[4].pieces[1] = p2;
            cube.sides[4].pieces[2] = p3;

            /*/
            CornerPiece tmpC1 = cube.sides[leftSide].cPieces[0];
            SidePiece tmpS1 = cube.sides[leftSide].sPieces[1];
            CornerPiece tmpC2 = cube.sides[leftSide].cPieces[2];

            cube.sides[leftSide].cPieces[0] = cube.sides[5].cPieces[2];
            cube.sides[leftSide].sPieces[1] = cube.sides[5].sPieces[3];
            cube.sides[leftSide].cPieces[2] = cube.sides[5].cPieces[3];

            cube.sides[5].cPieces[2] = cube.sides[rightSide].cPieces[1];
            cube.sides[5].sPieces[3] = cube.sides[rightSide].sPieces[2];
            cube.sides[5].cPieces[3] = cube.sides[rightSide].cPieces[3];

            cube.sides[rightSide].cPieces[1] = cube.sides[4].cPieces[0];
            cube.sides[rightSide].sPieces[2] = cube.sides[4].sPieces[0];
            cube.sides[rightSide].cPieces[3] = cube.sides[4].cPieces[1];

            cube.sides[4].cPieces[0] = tmpC1;
            cube.sides[4].sPieces[0] = tmpS1;
            cube.sides[4].cPieces[1] = tmpC2;
            /**/
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
            if (cube.topC == Color.Yellow || cube.frontC == Color.White)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC + 1);
            }
            else if (cube.topC == Color.White || cube.frontC == Color.Yellow)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC - 1);
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
            if (cube.topC == Color.Yellow || cube.frontC == Color.White)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC - 1);
            }
            else if (cube.topC == Color.White || cube.frontC == Color.Yellow)
            {
                cube.frontC = Modulo.sColorMod(cube.frontC + 1);
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
            if (cube.topC == Color.Yellow || cube.frontC == Color.White)
            {
                cube.topC = Modulo.sColorMod(cube.frontC - 1);
            }
            else if (cube.topC == Color.White || cube.frontC == Color.Yellow)
            {
                cube.topC = Modulo.sColorMod(cube.frontC + 1);
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
            if (cube.topC == Color.Yellow || cube.frontC == Color.White)
            {
                cube.topC = Modulo.sColorMod(cube.frontC + 1);
            }
            else if (cube.topC == Color.White || cube.frontC == Color.Yellow)
            {
                cube.topC = Modulo.sColorMod(cube.frontC - 1);
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
    }
}
