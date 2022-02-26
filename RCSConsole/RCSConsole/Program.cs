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

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Solution s;

            // White Cross
            /**/
            s = Algorithms.DaisyWhiteCross(cube);
            ApplySolution(cube, s);
            Console.WriteLine("White Cross step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

            // White Corners
            /**/
            s = Algorithms.WhiteCorners(cube);
            ApplySolution(cube, s);
            Console.WriteLine("White Corners step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

            // Middle Edges
            // !!WARNING!! This algorithm will work only if White Cross is already solved
            /**/
            s = Algorithms.MiddleEdges(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Middle Edges step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

            // Yellow Cross
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            /**/
            s = Algorithms.YellowCross(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Cross step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

            // Yellow Side
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            /**/
            s = Algorithms.YellowSide(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Side step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

            // Yellow Corners
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            /**/
            s = Algorithms.YellowCorners(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Corners step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

            // Yellow Edges
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            /**/
            s = Algorithms.YellowEdges(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Edges step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

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

        private static void ApplySolution(Cube cube, Solution s)
        {
            foreach (Step step in s.steps)
            {
                switch (step.move)
                {
                    case "U":
                        Moves.U(cube);
                        break;
                    case "U'":
                        Moves.oU(cube);
                        break;
                    case "D":
                        Moves.D(cube);
                        break;
                    case "D'":
                        Moves.oD(cube);
                        break;
                    case "R":
                        Moves.R(cube);
                        break;
                    case "R'":
                        Moves.oR(cube);
                        break;
                    case "L":
                        Moves.L(cube);
                        break;
                    case "L'":
                        Moves.oL(cube);
                        break;
                    case "F":
                        Moves.F(cube);
                        break;
                    case "F'":
                        Moves.oF(cube);
                        break;
                    case "B":
                        Moves.B(cube);
                        break;
                    case "B'":
                        Moves.oB(cube);
                        break;
                    case "U2":
                        Moves.U2(cube);
                        break;
                    case "D2":
                        Moves.D2(cube);
                        break;
                    case "R2":
                        Moves.R2(cube);
                        break;
                    case "L2":
                        Moves.L2(cube);
                        break;
                    case "F2":
                        Moves.F2(cube);
                        break;
                    case "B2":
                        Moves.B2(cube);
                        break;
                    case "x":
                        Moves.RotationX(cube);
                        break;
                    case "x'":
                        Moves.oRotationX(cube);
                        break;
                    case "y":
                        Moves.RotationY(cube);
                        break;
                    case "y'":
                        Moves.oRotationY(cube);
                        break;
                    case "z":
                        Moves.RotationZ(cube);
                        break;
                    case "z'":
                        Moves.oRotationZ(cube);
                        break;
                    case "x2":
                        Moves.RotationX2(cube);
                        break;
                    case "y2":
                        Moves.RotationY2(cube);
                        break;
                    case "z2":
                        Moves.RotationZ2(cube);
                        break;
                    case "Uw":
                        Moves.Uw(cube);
                        break;
                    case "Uw'":
                        Moves.oUw(cube);
                        break;
                    case "Dw":
                        Moves.Dw(cube);
                        break;
                    case "Dw'":
                        Moves.oDw(cube);
                        break;
                    case "Rw":
                        Moves.Rw(cube);
                        break;
                    case "Rw'":
                        Moves.oRw(cube);
                        break;
                    case "Lw":
                        Moves.Lw(cube);
                        break;
                    case "Lw'":
                        Moves.oLw(cube);
                        break;
                    case "Fw":
                        Moves.Fw(cube);
                        break;
                    case "Fw'":
                        Moves.oFw(cube);
                        break;
                    case "Bw":
                        Moves.Bw(cube);
                        break;
                    case "Bw'":
                        Moves.oBw(cube);
                        break;
                    case "Uw2":
                        Moves.Uw2(cube);
                        break;
                    case "Dw2":
                        Moves.Dw2(cube);
                        break;
                    case "Rw2":
                        Moves.Rw2(cube);
                        break;
                    case "Lw2":
                        Moves.Lw2(cube);
                        break;
                    case "Fw2":
                        Moves.Fw2(cube);
                        break;
                    case "Bw2":
                        Moves.Bw2(cube);
                        break;
                    case "M":
                        Moves.M(cube);
                        break;
                    case "M'":
                        Moves.oM(cube);
                        break;
                    case "E":
                        Moves.E(cube);
                        break;
                    case "E'":
                        Moves.oE(cube);
                        break;
                    case "S":
                        Moves.S(cube);
                        break;
                    case "S'":
                        Moves.oS(cube);
                        break;
                    case "M2":
                        Moves.M2(cube);
                        break;
                    case "E2":
                        Moves.E2(cube);
                        break;
                    case "S2":
                        Moves.S2(cube);
                        break;
                }
            }
        }
    }
}
