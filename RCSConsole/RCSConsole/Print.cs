using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Print
    {
        public static void PrintCube(Cube c)
        {
            for (int i = 0; i < c.sides.Count(); i++)
            {
                Console.Write("This is ");
                /*/
                SetFGColor(c.sides[i].cPiece.thisSideC);
                Console.Write(c.sides[i].cPiece.thisSideC);
                /**/
                SetFGColor(c.sides[i].pieces[5].Color);
                Console.Write(c.sides[i].pieces[5].Color);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" side of the cube:");
                PrintSide(c.sides[i]);
                Console.WriteLine();
            }
        }

        public static void PrintSide(Side s)
        {
            PrintPiece(s.pieces[0].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[1].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[2].Color);

            Console.WriteLine();
            Console.WriteLine("---------");

            PrintPiece(s.pieces[3].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[4].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[5].Color);

            Console.WriteLine();
            Console.WriteLine("---------");

            PrintPiece(s.pieces[6].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[7].Color);
            Console.Write(" | ");
            PrintPiece(s.pieces[8].Color);

            Console.WriteLine();

            /*/
            PrintPiece(s.cPieces[0].thisSideC);
            Console.Write(" | ");
            PrintPiece(s.sPieces[0].thisSideC);
            Console.Write(" | ");
            PrintPiece(s.cPieces[1].thisSideC);

            Console.WriteLine();
            Console.WriteLine("---------");

            PrintPiece(s.sPieces[1].thisSideC);
            Console.Write(" | ");
            PrintPiece(s.cPiece.thisSideC);
            Console.Write(" | ");
            PrintPiece(s.sPieces[2].thisSideC);

            Console.WriteLine();
            Console.WriteLine("---------");

            PrintPiece(s.cPieces[2].thisSideC);
            Console.Write(" | ");
            PrintPiece(s.sPieces[3].thisSideC);
            Console.Write(" | ");
            PrintPiece(s.cPieces[3].thisSideC);

            Console.WriteLine();
            /**/
        }

        private static void PrintPiece(Color pieceColor)
        {
            SetBGColor(pieceColor);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static void SetBGColor(Color c)
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

        private static void SetFGColor(Color c)
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
