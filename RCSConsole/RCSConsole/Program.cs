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
                Console.Write(step.move.ToCustomString() + " ");
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
                Console.Write(step.move.ToCustomString() + " ");
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
                Console.Write(step.move.ToCustomString() + " ");
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
            /*/
            s = Algorithms.YellowCross(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Cross step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move.ToCustomString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            // Yellow Side
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            s = Algorithms.YellowSide(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Side step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move.ToCustomString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            // Yellow Corners
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            s = Algorithms.YellowCorners(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Corners step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move.ToCustomString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            // Yellow Edges
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            s = Algorithms.YellowEdges(cube);
            ApplySolution(cube, s);
            Console.WriteLine("Yellow Edges step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move.ToCustomString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            /**/

            /**/
            // 2L OLL
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            s = Algorithms.TLOLL(cube);
            ApplySolution(cube, s);
            Console.WriteLine("2L OLL step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move.ToCustomString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Printer.PrintCube(cube);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            // 2L PLL
            // !!WARNING!! This algorithm will work only if all previous steps were executed
            s = Algorithms.TLPLL(cube);
            ApplySolution(cube, s);
            Console.WriteLine("2L PLL step-by-step:");
            foreach (Step step in s.steps)
            {
                Console.Write(step.move.ToCustomString() + " ");
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
                    case Move.U:
                        Moves.U(cube);
                        break;
                    case Move.Up:
                        Moves.Up(cube);
                        break;
                    case Move.D:
                        Moves.D(cube);
                        break;
                    case Move.Dp:
                        Moves.Dp(cube);
                        break;
                    case Move.R:
                        Moves.R(cube);
                        break;
                    case Move.Rp:
                        Moves.Rp(cube);
                        break;
                    case Move.L:
                        Moves.L(cube);
                        break;
                    case Move.Lp:
                        Moves.Lp(cube);
                        break;
                    case Move.F:
                        Moves.F(cube);
                        break;
                    case Move.Fp:
                        Moves.Fp(cube);
                        break;
                    case Move.B:
                        Moves.B(cube);
                        break;
                    case Move.Bp:
                        Moves.Bp(cube);
                        break;
                    case Move.U2:
                        Moves.U2(cube);
                        break;
                    case Move.D2:
                        Moves.D2(cube);
                        break;
                    case Move.R2:
                        Moves.R2(cube);
                        break;
                    case Move.L2:
                        Moves.L2(cube);
                        break;
                    case Move.F2:
                        Moves.F2(cube);
                        break;
                    case Move.B2:
                        Moves.B2(cube);
                        break;
                    case Move.RotationX:
                        Moves.RotationX(cube);
                        break;
                    case Move.RotationXp:
                        Moves.RotationXp(cube);
                        break;
                    case Move.RotationY:
                        Moves.RotationY(cube);
                        break;
                    case Move.RotationYp:
                        Moves.RotationYp(cube);
                        break;
                    case Move.RotationZ:
                        Moves.RotationZ(cube);
                        break;
                    case Move.RotationZp:
                        Moves.RotationZp(cube);
                        break;
                    case Move.RotationX2:
                        Moves.RotationX2(cube);
                        break;
                    case Move.RotationY2:
                        Moves.RotationY2(cube);
                        break;
                    case Move.RotationZ2:
                        Moves.RotationZ2(cube);
                        break;
                    case Move.Uw:
                        Moves.Uw(cube);
                        break;
                    case Move.Uwp:
                        Moves.Uwp(cube);
                        break;
                    case Move.Dw:
                        Moves.Dw(cube);
                        break;
                    case Move.Dwp:
                        Moves.Dwp(cube);
                        break;
                    case Move.Rw:
                        Moves.Rw(cube);
                        break;
                    case Move.Rwp:
                        Moves.Rwp(cube);
                        break;
                    case Move.Lw:
                        Moves.Lw(cube);
                        break;
                    case Move.Lwp:
                        Moves.Lwp(cube);
                        break;
                    case Move.Fw:
                        Moves.Fw(cube);
                        break;
                    case Move.Fwp:
                        Moves.Fwp(cube);
                        break;
                    case Move.Bw:
                        Moves.Bw(cube);
                        break;
                    case Move.Bwp:
                        Moves.Bwp(cube);
                        break;
                    case Move.Uw2:
                        Moves.Uw2(cube);
                        break;
                    case Move.Dw2:
                        Moves.Dw2(cube);
                        break;
                    case Move.Rw2:
                        Moves.Rw2(cube);
                        break;
                    case Move.Lw2:
                        Moves.Lw2(cube);
                        break;
                    case Move.Fw2:
                        Moves.Fw2(cube);
                        break;
                    case Move.Bw2:
                        Moves.Bw2(cube);
                        break;
                    case Move.M:
                        Moves.M(cube);
                        break;
                    case Move.Mp:
                        Moves.Mp(cube);
                        break;
                    case Move.E:
                        Moves.E(cube);
                        break;
                    case Move.Ep:
                        Moves.Ep(cube);
                        break;
                    case Move.S:
                        Moves.S(cube);
                        break;
                    case Move.Sp:
                        Moves.Sp(cube);
                        break;
                    case Move.M2:
                        Moves.M2(cube);
                        break;
                    case Move.E2:
                        Moves.E2(cube);
                        break;
                    case Move.S2:
                        Moves.S2(cube);
                        break;
                }
            }
        }
    }
}
