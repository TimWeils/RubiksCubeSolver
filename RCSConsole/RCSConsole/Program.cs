using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Program
    {
        // Reminder
        // Pri rotacich se neotaci casti na rotujici stene
        // Napriklad:
        // yU nerotuje barvy na Y stene okolo stredu
        // yR nerotuje barvy na R stene okolo stredu
        static void Main(string[] args)
        {
            Cube cube = LoadSolvedCube();
            Moves.R(cube);
            Moves.U(cube);
            Moves.oR(cube);
            Print.PrintCube(cube);
            Console.ReadLine();
        }

        private static Cube LoadSolvedCube()
        {
            Cube cube = new Cube();

            cube.topC = Color.Yellow;
            cube.frontC = Color.Red;

            cube.sides[0] = CreateSolvedSideSide(Color.Red);
            cube.sides[1] = CreateSolvedSideSide(Color.Green);
            cube.sides[2] = CreateSolvedSideSide(Color.Orange);
            cube.sides[3] = CreateSolvedSideSide(Color.Blue);
            cube.sides[4] = CreateSolvedSideSide(Color.Yellow);
            cube.sides[5] = CreateSolvedSideSide(Color.White);

            /*/
            // Red side
            cube.sides[0] = CreateSolvedSideSide(Color.Red);

            // Green side
            cube.sides[1] = CreateSolvedSideSide(Color.Green);

            // Orange side
            cube.sides[2] = CreateSolvedSideSide(Color.Orange);

            // Blue side
            cube.sides[3] = CreateSolvedSideSide(Color.Blue);

            // Yellow side
            CornerPiece yCorner0 = new CornerPiece(Color.Yellow, Color.Orange, Color.Blue);
            CornerPiece yCorner1 = new CornerPiece(Color.Yellow, Color.Green, Color.Orange);
            CornerPiece yCorner2 = new CornerPiece(Color.Yellow, Color.Red, Color.Green);
            CornerPiece yCorner3 = new CornerPiece(Color.Yellow, Color.Blue, Color.Red);

            SidePiece ySide0 = new SidePiece(Color.Yellow, Color.Orange);
            SidePiece ySide1 = new SidePiece(Color.Yellow, Color.Blue);
            SidePiece ySide2 = new SidePiece(Color.Yellow, Color.Green);
            SidePiece ySide3 = new SidePiece(Color.Yellow, Color.Red);

            CenterPiece yCenter = new CenterPiece(Color.Yellow);

            Side ySide = new Side();
            ySide.cPieces[0] = yCorner0;
            ySide.cPieces[1] = yCorner1;
            ySide.cPieces[2] = yCorner2;
            ySide.cPieces[3] = yCorner3;
            
            ySide.sPieces[0] = ySide0;
            ySide.sPieces[1] = ySide1;
            ySide.sPieces[2] = ySide2;
            ySide.sPieces[3] = ySide3;
            
            ySide.cPiece = yCenter;

            cube.sides[4] = ySide;

            // White side
            CornerPiece wCorner0 = new CornerPiece(Color.White, Color.Red, Color.Blue);
            CornerPiece wCorner1 = new CornerPiece(Color.White, Color.Green, Color.Red);
            CornerPiece wCorner2 = new CornerPiece(Color.White, Color.Orange, Color.Green);
            CornerPiece wCorner3 = new CornerPiece(Color.White, Color.Blue, Color.Orange);

            SidePiece wSide0 = new SidePiece(Color.White, Color.Red);
            SidePiece wSide1 = new SidePiece(Color.White, Color.Blue);
            SidePiece wSide2 = new SidePiece(Color.White, Color.Green);
            SidePiece wSide3 = new SidePiece(Color.White, Color.Orange);

            CenterPiece wCenter = new CenterPiece(Color.White);

            Side wSide = new Side();
            wSide.cPieces[0] = wCorner0;
            wSide.cPieces[1] = wCorner1;
            wSide.cPieces[2] = wCorner2;
            wSide.cPieces[3] = wCorner3;

            wSide.sPieces[0] = wSide0;
            wSide.sPieces[1] = wSide1;
            wSide.sPieces[2] = wSide2;
            wSide.sPieces[3] = wSide3;

            wSide.cPiece = wCenter;

            cube.sides[5] = wSide;
            /**/

            return cube;
        }

        private static Side CreateSolvedSideSide(Color sideColor)
        {
            Side side = new Side();

            for (int i = 0; i < 9; i++)
            {
                side.pieces[i] = new CubePiece(sideColor);
            }

            /*/
            Color leftSideC = Modulo.sColorMod(sideColor - 1);
            Color rightSideC = Modulo.sColorMod(sideColor + 1);

            CornerPiece corner0 = new CornerPiece(sideColor, Color.Yellow, leftSideC);
            CornerPiece corner1 = new CornerPiece(sideColor, rightSideC, Color.Yellow);
            CornerPiece corner2 = new CornerPiece(sideColor, Color.White, rightSideC);
            CornerPiece corner3 = new CornerPiece(sideColor, leftSideC, Color.White);

            SidePiece side0 = new SidePiece(sideColor, Color.Yellow);
            SidePiece side1 = new SidePiece(sideColor, leftSideC);
            SidePiece side2 = new SidePiece(sideColor, rightSideC);
            SidePiece side3 = new SidePiece(sideColor, Color.White);

            CenterPiece center = new CenterPiece(sideColor);

            Side side = new Side();
            side.cPieces[0] = corner0;
            side.cPieces[1] = corner1;
            side.cPieces[2] = corner2;
            side.cPieces[3] = corner3;

            side.sPieces[0] = side0;
            side.sPieces[1] = side1;
            side.sPieces[2] = side2;
            side.sPieces[3] = side3;

            side.cPiece = center;
            /**/

            return side;
        }
    }
}
