using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                case Color.None:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case Color.Solved:
                    Console.BackgroundColor = ConsoleColor.Cyan;
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

        private static void OpenCubeInBrowser(string cube, string movesToApply)
        {
            string pageHTML = @$"
<!DOCTYPE html>
<html>
    <head>
        <script src=""AnimCube3.js""></script>
        <style>
		    div {{
			    position: fixed;
			    top: 0;
			    left: 0;
			
			    width: 100%;
			    height: 100%;
		    }}
	    </style>
    </head>
    <body>
        <div>
            <script>
		        AnimCube3(`scale=3
			        &facelets={cube}
			        &movetext=2
			        &repeat=0
			        &edit=0
			        &hint=8
			        &buttonbar=1
			        &buttonheight=25
			        &textsize=20
			        &move={movesToApply}
		        `);
	        </script>
        </div>
    </body>
</html>
            ";
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            File.WriteAllText(path + "/web.html", pageHTML);
            var p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo(path + "/web.html")
            {
                UseShellExecute = true
            };
            p.Start();
        } 

        private static void BasicSolve(string fileName, Dictionary<Side, bool[]> solvedMask, Dictionary<Side, bool[]> unsolvedMask)
        {
            /*/
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
                        string stringMoves = EnumUtils.MoveToString(usedMove.Value);
                        stringMoves += value.ToString();
                        OpenCubeInBrowser(cube, stringMoves);
                        cube.ApplyMoves(new Moves(usedMove.Value));
                        cube.ApplyMoves(value);
                    }
                    else
                    {
                        string stringMoves = value.ToString();
                        OpenCubeInBrowser(cube, stringMoves);
                        cube.ApplyMoves(value);
                    }
                    break;
                }
            }

            PrintCubeToConsole(cube);

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

        static Moves FindSolution(PCube cube, PCube previousLevelMask, PCube currentLevelMask, List<Move> interchangeableMoves, Dictionary<PCube, Moves> movesDB)
        {
            PCube clone = new PCube(cube);
            clone.ApplyNoneMask(currentLevelMask);
            if (previousLevelMask != null)
            {
                clone.ApplySolvedMask(previousLevelMask);
            }
            PrintCubeToConsole(clone);
            foreach (var (key, value) in movesDB)
            {
                //PrintCubeToConsole(key);
                if (clone.SimpleCompare(key))
                {
                    return value;
                }
            }

            if (interchangeableMoves != null)
            {
                foreach (Move m in interchangeableMoves)
                {
                    PCube moveClone = new PCube(clone);
                    moveClone.ApplyMoves(new Moves(m));
                    PrintCubeToConsole(moveClone);
                    foreach (var (key, value) in movesDB)
                    {
                        //PrintCubeToConsole(key);
                        if (moveClone.SimpleCompare(key))
                        {
                            Moves result = new Moves(m);
                            result.AddMoves(value);
                            return result;
                        }
                    }
                }
            }

            return null;
        }

        static Dictionary<PCube, Moves> CreateDBForLevel(Dictionary<PCube, Moves> db, PCube previousLevelMask, PCube currentLevelMask, List<Dictionary<Side, Color>> recolors)
        {
            Dictionary<PCube, Moves> result = new Dictionary<PCube, Moves>();

            foreach (var (key, value) in db)
            {
                // Problem je ze solved maska nepocita s otocenim
                // Ale jinak funguje dobre
                PCube keyToModify = new PCube(key);
                keyToModify.ApplyNoneMask(currentLevelMask);
                if (previousLevelMask != null)
                {
                    keyToModify.ApplySolvedMask(previousLevelMask);
                }
                result.Add(keyToModify, value);

                if (recolors != null)
                {
                    foreach (var recolor in recolors)
                    {
                        keyToModify = new PCube(key);
                        keyToModify.RecolorCubeV2(recolor);
                        keyToModify.ApplyNoneMask(currentLevelMask);
                        if (previousLevelMask != null)
                        {
                            keyToModify.ApplySolvedMask(previousLevelMask);
                        }
                        result.Add(keyToModify, value);
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            /**/
            int[] cornersPermutation = new int[] { 30, 30, 30, 3, 30, 30, 6, 30, 30, 30, 10, 11, 30, 30, 14, 15, 30, 30, 30, 30, 20, 30, 22, 23 };
            int[] edgesPermutation = new int[] { 30, 30, 2, 3, 30, 5, 6, 30, 30, 9, 10, 11, 30, 13, 14, 15, 30, 30, 30, 30, 20, 21, 22, 23 };
            int[] centersPermutation = new int[] { 0, 1, 2, 3, 30, 5 };
            PCube FRF2LMask = new PCube(cornersPermutation, edgesPermutation, centersPermutation);

            cornersPermutation = new int[] { 30, 30, 2, 3, 30, 30, 6, 7, 30, 30, 10, 11, 30, 30, 14, 15, 30, 30, 30, 30, 20, 21, 22, 23 };
            edgesPermutation = new int[] { 30, 1, 2, 3, 30, 5, 6, 7, 30, 9, 10, 11, 30, 13, 14, 15, 30, 30, 30, 30, 20, 21, 22, 23 };
            centersPermutation = new int[] { 0, 1, 2, 3, 30, 5 };
            PCube F2LMask = new PCube(cornersPermutation, edgesPermutation, centersPermutation);

            cornersPermutation = new int[] { 30, 30, 2, 3, 30, 30, 6, 7, 30, 30, 10, 11, 30, 30, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            edgesPermutation = new int[] { 30, 1, 2, 3, 30, 5, 6, 7, 30, 9, 10, 11, 30, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            centersPermutation = new int[] { 0, 1, 2, 3, 4, 5 };
            PCube OLLMask = new PCube(cornersPermutation, edgesPermutation, centersPermutation);

            PCube PLLMask = new PCube();

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

            // Create PLL recolors
            List<Dictionary<Side, Color>> PLLRecolors = new List<Dictionary<Side, Color>>();
            PLLRecolors.Add(new Dictionary<Side, Color> { { Side.Front, Color.Red }, { Side.Right, Color.Green }, { Side.Back, Color.Orange }, { Side.Left, Color.Blue }, { Side.Up, Color.Yellow }, { Side.Down, Color.White } });
            PLLRecolors.Add(new Dictionary<Side, Color> { { Side.Front, Color.Blue }, { Side.Right, Color.Red }, { Side.Back, Color.Green }, { Side.Left, Color.Orange }, { Side.Up, Color.Yellow }, { Side.Down, Color.White } });
            PLLRecolors.Add(new Dictionary<Side, Color> { { Side.Front, Color.Orange }, { Side.Right, Color.Blue }, { Side.Back, Color.Red }, { Side.Left, Color.Green }, { Side.Up, Color.Yellow }, { Side.Down, Color.White } });
            PLLRecolors.Add(new Dictionary<Side, Color> { { Side.Front, Color.Green }, { Side.Right, Color.Orange }, { Side.Back, Color.Blue }, { Side.Left, Color.Red }, { Side.Up, Color.Yellow }, { Side.Down, Color.White } });

            // Create PLL interchangeable moves
            List<Move> InterchangeableMoves = new List<Move> { Move.U, Move.Up, Move.U2 };

            // Load moves from file
            Dictionary<PCube, Moves> movesDB = Reader.OpenAndProcessFile("../../../F2L.txt");
            foreach (var (key, value) in Reader.OpenAndProcessFile("../../../OLL.txt"))
            {
                movesDB.Add(key, value);
            }
            foreach (var (key, value) in Reader.OpenAndProcessFile("../../../PLL.txt"))
            {
                movesDB.Add(key, value);
            }
            Console.WriteLine(movesDB.Count + " moves were loaded");

            // Get moves DB for PLL
            Dictionary<PCube, Moves> PLLMovesDB = CreateDBForLevel(movesDB, OLLMask, PLLMask, PLLRecolors);

            // Get moves DB for OLL
            Dictionary<PCube, Moves> OLLMovesDB = CreateDBForLevel(movesDB, F2LMask, OLLMask, null);

            // Get moves DB for F2L
            Dictionary<PCube, Moves> F2LMovesDB = CreateDBForLevel(movesDB, FRF2LMask, F2LMask, null);

            // Try to find F2L solution
            Moves solution = FindSolution(cube, null, F2LMask, null, F2LMovesDB);

            if (solution == null)
            {
                // Try to find OLL solution
                solution = FindSolution(cube, F2LMask, OLLMask, InterchangeableMoves, OLLMovesDB);
            }

            if (solution == null)
            {
                // Try to find PLL solution
                solution = FindSolution(cube, OLLMask, PLLMask, InterchangeableMoves, PLLMovesDB);
            }

            if (solution != null)
            {
                PrintCubeToConsole(cube);
                Console.WriteLine("Solution found!");
                OpenCubeInBrowser(cube.ToACJSFacelets(), solution.ToString());
                cube.ApplyMoves(solution);
                PrintCubeToConsole(cube);
            }
            else
            {
                Console.WriteLine("Solution NOT found!");
            }
            /**/

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

            /*/
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
