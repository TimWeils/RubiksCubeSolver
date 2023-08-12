using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RCSv2
{
    static class Reader
    {
        static public Dictionary<Tuple<PCube, PCube>, Moves> OpenAndProcessFile(string fileName)
        {
            // Not final data structure!
            Dictionary<Tuple<PCube, PCube>, Moves> movesDatabase = new Dictionary<Tuple<PCube, PCube>, Moves>();

            StreamReader file = File.OpenText(fileName);
            while (!file.EndOfStream)
            {
                ProcessMoves(file.ReadLine(), movesDatabase);
            }

            return movesDatabase;
        }

        static void ProcessMoves(string movesLine, Dictionary<Tuple<PCube, PCube>, Moves> movesDatabase)
        {
            // Process line into moves
            Moves moves = new Moves();
            string[] splitted_line = movesLine.Split(" ");
            foreach (string m in splitted_line) {
                try
                {
                    Move move = Enum.Parse<Move>(m);
                    moves.AddMove(move);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            // Calculate cube position from moves
            moves.Invert();
            // TODO Get hash of complete cube
            PCube cube = new PCube();
            // TODO Get hash of "start cube"
            // i.e. cube which will be solved by applying listed moves
            cube.ApplyMoves(moves);
            // Invert moves back into original sequence before saving
            moves.Invert();
            // Save moves to some table which is like [[start_cube, end_cube], moves]
            movesDatabase.Add(new Tuple<PCube, PCube>(cube, new PCube()), moves);
        }
    }
}
