using System;

namespace RCSv2
{
    class Program
    {
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

        private static void PrintPiece(Color pieceColor)
        {
            SetBGColor(pieceColor);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static void PrintSide(Color[] side, int startLeft, int startTop)
        {
            // Top border
            Console.SetCursorPosition(startLeft + 1, startTop);
            Console.Write("-----------");

            // First row
            Console.SetCursorPosition(startLeft, startTop + 1);
            Console.Write("| ");
            PrintPiece(side[0]);
            Console.Write(" | ");
            PrintPiece(side[1]);
            Console.Write(" | ");
            PrintPiece(side[2]);
            Console.Write(" |");

            // Between rows border
            Console.SetCursorPosition(startLeft + 1, startTop + 2);
            Console.Write("-----------");

            // Second row
            Console.SetCursorPosition(startLeft, startTop + 3);
            Console.Write("| ");
            PrintPiece(side[3]);
            Console.Write(" | ");
            PrintPiece(side[4]);
            Console.Write(" | ");
            PrintPiece(side[5]);
            Console.Write(" |");

            // Between rows border
            Console.SetCursorPosition(startLeft + 1, startTop + 4);
            Console.Write("-----------");

            // Third row
            Console.SetCursorPosition(startLeft, startTop + 5);
            Console.Write("| ");
            PrintPiece(side[6]);
            Console.Write(" | ");
            PrintPiece(side[7]);
            Console.Write(" | ");
            PrintPiece(side[8]);
            Console.Write(" |");

            // Bottom border
            Console.SetCursorPosition(startLeft + 1, startTop + 6);
            Console.Write("-----------");

            // Return cursor to start position
            Console.SetCursorPosition(startLeft, startTop);
        }

        private static void PrintCubeToConsole(PCube cube)
        {
            Color[] frontSide = cube.GetSideColors(Side.Front);
            Color[] rightSide = cube.GetSideColors(Side.Right);
            Color[] backSide = cube.GetSideColors(Side.Back);
            Color[] leftSide = cube.GetSideColors(Side.Left);
            Color[] upSide = cube.GetSideColors(Side.Up);
            Color[] downSide = cube.GetSideColors(Side.Down);

            // Print up
            PrintSide(upSide, 12, Console.CursorTop);

            // Print left
            PrintSide(leftSide, 0, Console.CursorTop + 6);

            // Print front
            PrintSide(frontSide, 12, Console.CursorTop);

            // Print right
            PrintSide(rightSide, 24, Console.CursorTop);

            // Print back
            PrintSide(backSide, 36, Console.CursorTop);

            // Print down
            PrintSide(downSide, 12, Console.CursorTop + 6);

            // Move cursor under the cube
            Console.SetCursorPosition(0, Console.CursorTop + 7);
        }

        static void Main(string[] args)
        {
            // Get solved cube
            PCube cube = new PCube();

            // Print cube into console (so we can check that it is really solved)
            PrintCubeToConsole(cube);
            Console.WriteLine();

            // Create some basic move
            Moves moves = new Moves(Move.R);

            // Add additional move
            moves.AddMove(Move.U);

            // Apply moves to the cube and print it into console
            cube.ApplyMoves(moves);
            PrintCubeToConsole(cube);
            Console.WriteLine();

            // Invert the moves
            moves.Invert();

            // Apply inverted moves to the cube (so it is again solved) and print it into console
            cube.ApplyMoves(moves);
            PrintCubeToConsole(cube);
        }
    }
}
