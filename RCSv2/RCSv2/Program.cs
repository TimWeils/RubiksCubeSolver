using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private static void BasicSolve(string fileName, Dictionary<Side, bool[]> solvedMask, Dictionary<Side, bool[]> unsolvedMask)
        {
            // Load moves from file
            Dictionary<Tuple<PCube, PCube>, Moves> moves_database = Reader.OpenAndProcessFile("../../../" + fileName + ".txt");
            Console.WriteLine(moves_database.Count + " moves were loaded");

            Console.WriteLine("Enter shuffle:");

            // Process line into moves
            Moves moves = new Moves();
            string[] splitted_line = Console.ReadLine().Replace("'", "p").Split(" ");
            foreach (string m in splitted_line)
            {
                Move move = Enum.Parse<Move>(m);
                moves.AddMove(move);
            }
            PCube cube = new PCube();
            cube.ApplyMoves(moves);

            PrintCubeToConsole(cube);

            // Find solution and solve the cube
            foreach (var (key, value) in moves_database)
            {
                Move? usedMove;
                Move[] interchangeableMoves = { Move.U, Move.Up, Move.U2 };
                if (cube.Compare(key.Item1, solvedMask) &&
                    cube.Compare(key.Item1, unsolvedMask, interchangeableMoves, out usedMove))
                {
                    Console.WriteLine("Found!");
                    if (usedMove.HasValue)
                    {
                        cube.ApplyMoves(new Moves(usedMove.Value));
                    }
                    cube.ApplyMoves(value);
                    break;
                }
            }

            PrintCubeToConsole(cube);

            /*/
            // Debug part
            Console.WriteLine("Unmess up the cube:");

            // Process line into moves
            moves = new Moves();
            splitted_line = Console.ReadLine().Replace("'", "p").Split(" ");
            foreach (string m in splitted_line)
            {
                Move move = Enum.Parse<Move>(m);
                moves.AddMove(move);
            }
            cube.ApplyMoves(moves);

            PrintCubeToConsole(cube);
            /**/
        }

        static void Main(string[] args)
        {
            /*/
            // Debug part
            Console.WriteLine("Mess up the cube:");

            // Process line into moves
            Moves moves = new Moves();
            string[] splitted_line = Console.ReadLine().Replace("'", "p").Split(" ");
            foreach (string m in splitted_line)
            {
                Move move = Enum.Parse<Move>(m);
                moves.AddMove(move);
            }
            PCube cube = new PCube();
            moves.Invert();
            cube.ApplyMoves(moves);

            PrintCubeToConsole(cube);
            /**/

            // Create masks so we can search for solution
            // In future masks will be created based on previous level solution
            // or derived directly from it
            // Derivation would be a bit problematic, since we would have to specify
            // if mask is the colors or the none color part => need of two functions

            /*/
            // OLL
            // Mask for already solved part
            Dictionary<Side, bool[]> solvedMask = new Dictionary<Side, bool[]>();
            bool[] sideMask = { false, false, false, true, true, true, true, true, true };
            bool[] upMask = { false, false, false, false, false, false, false, false, false };
            bool[] downMask = { true, true, true, true, true, true, true, true, true };
            solvedMask.Add(Side.Front, sideMask);
            solvedMask.Add(Side.Right, sideMask);
            solvedMask.Add(Side.Back, sideMask);
            solvedMask.Add(Side.Left, sideMask);
            solvedMask.Add(Side.Up, upMask);
            solvedMask.Add(Side.Down, downMask);

            // Mask for unsolved part
            Dictionary<Side, bool[]> unsolvedMask = new Dictionary<Side, bool[]>();
            sideMask = new bool[] { true, true, true, false, false, false, false, false, false };
            upMask = new bool[] { true, true, true, true, true, true, true, true, true }; ;
            downMask = new bool[] { false, false, false, false, false, false, false, false, false };
            unsolvedMask.Add(Side.Front, sideMask);
            unsolvedMask.Add(Side.Right, sideMask);
            unsolvedMask.Add(Side.Back, sideMask);
            unsolvedMask.Add(Side.Left, sideMask);
            unsolvedMask.Add(Side.Up, upMask);
            unsolvedMask.Add(Side.Down, downMask);

            BasicSolve("OLL", solvedMask, unsolvedMask);
            /**/

            /**/
            // PLL
            // Mask for already solved part
            Dictionary<Side, bool[]> solvedMask = new Dictionary<Side, bool[]>();
            bool[] sideMask = { false, false, false, true, true, true, true, true, true };
            bool[] upAndDownMask = { true, true, true, true, true, true, true, true, true };
            solvedMask.Add(Side.Front, sideMask);
            solvedMask.Add(Side.Right, sideMask);
            solvedMask.Add(Side.Back, sideMask);
            solvedMask.Add(Side.Left, sideMask);
            solvedMask.Add(Side.Up, upAndDownMask);
            solvedMask.Add(Side.Down, upAndDownMask);

            // Mask for unsolved part
            Dictionary<Side, bool[]> unsolvedMask = new Dictionary<Side, bool[]>();
            sideMask = new bool[] { true, true, true, false, false, false, false, false, false };
            upAndDownMask = new bool[] { false, false, false, false, false, false, false, false, false };
            unsolvedMask.Add(Side.Front, sideMask);
            unsolvedMask.Add(Side.Right, sideMask);
            unsolvedMask.Add(Side.Back, sideMask);
            unsolvedMask.Add(Side.Left, sideMask);
            unsolvedMask.Add(Side.Up, upAndDownMask);
            unsolvedMask.Add(Side.Down, upAndDownMask);

            BasicSolve("PLL", solvedMask, unsolvedMask);
            /**/
        }
    }
}
