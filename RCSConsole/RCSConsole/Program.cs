using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = Reader.ReadCube();
            //Cube cube = LoadSolvedCube();
            Moves.RotationX(cube);
            Moves.RotationY(cube);
            Moves.R(cube);
            Moves.U(cube);
            Moves.oR(cube);
            Printer.PrintCube(cube);
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

            return cube;
        }

        private static Side CreateSolvedSideSide(Color sideColor)
        {
            Side side = new Side();

            for (int i = 0; i < 9; i++)
            {
                side.pieces[i] = new CubePiece(sideColor);
            }

            return side;
        }
    }
}
