using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Printer
    {
        public static void PrintCube(Cube c)
        {
            int[] sides = SidesOrder(c.topC, c.frontC);
            int[][] pieces = PiecesOrder(c.topC, c.frontC);

            Console.WriteLine("Cube is in this position:");
            Console.Write("Top: ");
            SetFGColor(c.topC);
            Console.WriteLine(c.topC);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Front: ");
            SetFGColor(c.frontC);
            Console.WriteLine(c.frontC);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            for (int i = 0; i < sides.Length; i++)
            {
                Console.Write("This is ");
                SetFGColor(c.sides[sides[i]].pieces[4].Color);
                Console.Write(c.sides[sides[i]].pieces[4].Color);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" side of the cube:");
                PrintSide(c.sides[sides[i]], pieces[i]);
                Console.WriteLine();
            }
        }

        private static int[] SidesOrder(Color topC, Color frontC)
        {
            if (frontC == Color.Yellow)
            {
                return new int[] { 4, Modulo.sIntMod(topC - 1), 5, Modulo.sIntMod(topC + 1), (int)topC, Modulo.sIntMod(topC + 2) };
            }
            else if (frontC == Color.White)
            {
                return new int[] { 5, Modulo.sIntMod(topC + 1), 4, Modulo.sIntMod(topC - 1), (int)topC, Modulo.sIntMod(topC + 2) };
            }
            else if (topC == Color.Yellow)
            {
                return new int[] { (int)frontC, Modulo.sIntMod(frontC + 1), Modulo.sIntMod(frontC + 2), Modulo.sIntMod(frontC + 3), 4, 5 };
            }
            else if (topC == Color.White)
            {
                return new int[] { (int)frontC, Modulo.sIntMod(frontC + 3), Modulo.sIntMod(frontC + 2), Modulo.sIntMod(frontC + 1), 5, 4 };
            }
            // if Yellow is on the left side
            else if (topC == Modulo.sColorMod(frontC + 1))
            {
                return new int[] { (int)frontC, 5, Modulo.sIntMod(frontC + 2), 4, (int)topC, Modulo.sIntMod(topC + 2) };
            }
            else
            {
                return new int[] { (int)frontC, 4, Modulo.sIntMod(frontC + 2), 5, (int)topC, Modulo.sIntMod(topC + 2) };
            }
        }

        private static int[][] PiecesOrder(Color topC, Color frontC)
        {
            if (frontC == Color.Yellow)
            {
                return new int[][] {
                    Cube.GetYCoordinates(Modulo.sColorMod(topC + 2)),
                    new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 },
                    Cube.GetWCoordinates(topC),
                    new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 },
                    new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                    new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }
                };
            }
            else if (frontC == Color.White)
            {
                return new int[][] {
                   Cube.GetWCoordinates(topC),
                   new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 },
                   Cube.GetYCoordinates(Modulo.sColorMod(topC + 2)),
                   new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 },
                   new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                   new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 }
                };
            }
            else if (topC == Color.Yellow)
            {
                return new int[][] {
                   new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                   new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                   new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                   new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                   Cube.GetYCoordinates(frontC),
                   Cube.GetWCoordinates(frontC)
                };
            }
            else if (topC == Color.White)
            {
                return new int[][] {
                   new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                   new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                   new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                   new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                   Cube.GetWCoordinates(Modulo.sColorMod(frontC + 2)),
                   Cube.GetYCoordinates(Modulo.sColorMod(frontC + 2))
                };
            }
            // if Yellow is on the left side
            else if (topC == Modulo.sColorMod(frontC + 1))
            {
                return new int[][] {
                   new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 },
                   Cube.GetWCoordinates(topC),
                   new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 },
                   Cube.GetYCoordinates(Modulo.sColorMod(topC + 2)),
                   new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 },
                   new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 }
                };
            }
            else
            {
                return new int[][] {
                    new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 },
                    Cube.GetYCoordinates(topC + 2),
                    new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 },
                    Cube.GetWCoordinates(Modulo.sColorMod(topC)),
                    new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 },
                    new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 }
                };
            }
        }

        public static void PrintSide(Side s, int[] piecesIndex)
        {
            PrintPiece(s.pieces[piecesIndex[0]].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[piecesIndex[1]].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[piecesIndex[2]].Color);

            Console.WriteLine();
            Console.WriteLine("---------");

            PrintPiece(s.pieces[piecesIndex[3]].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[piecesIndex[4]].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[piecesIndex[5]].Color);

            Console.WriteLine();
            Console.WriteLine("---------");

            PrintPiece(s.pieces[piecesIndex[6]].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[piecesIndex[7]].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[piecesIndex[8]].Color);

            Console.WriteLine();
        }

        private static void PrintPiece(Color pieceColor)
        {
            SetBGColor(pieceColor);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void SetBGColor(Color c)
        {
            switch (c)
            {
                case Color.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case Color.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case Color.Orange:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case Color.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case Color.White:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case Color.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
            }
        }

        public static void SetFGColor(Color c)
        {
            switch (c)
            {
                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.Orange:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
        }
    }
}
