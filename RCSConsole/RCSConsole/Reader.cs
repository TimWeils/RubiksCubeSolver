using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Reader
    {
        public static Cube ReadCube()
        {
            Console.WriteLine("Enter colors of individual pieces in this order:");
            Console.WriteLine();
            Console.WriteLine("1 | 2 | 3");
            Console.WriteLine("---------");
            Console.WriteLine("4 | 5 | 6");
            Console.WriteLine("---------");
            Console.WriteLine("7 | 8 | 9");
            Console.WriteLine();

            Console.WriteLine("Use following notation:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red -> R or r");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green -> G or g");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Orange -> 0 or o");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue -> B or b");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow -> Y or y");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("White -> W or w");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            Color[] colors = {
                Color.Red,
                Color.Green,
                Color.Orange,
                Color.Blue,
                Color.Yellow,
                Color.White
            };

            char[][] charCube = new char[6][];

            for(int i = 0; i < colors.Length; i++)
            {
                if (i < 4)
                {
                    Console.WriteLine("Make sure that the cube is in this position:");
                    Console.Write("Top: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Yellow");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Front: ");
                    Printer.SetFGColor(colors[i]);
                    Console.WriteLine(colors[i]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
                else if (i == 4)
                {
                    Console.WriteLine("Make sure that the cube is in this position:");
                    Console.Write("Top: ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Orange");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Front: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Yellow");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Make sure that the cube is in this position:");
                    Console.Write("Top: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Red");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Front: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("White");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }

                Console.Write("Enter colors of ");
                Printer.SetFGColor(colors[i]);
                Console.Write(colors[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" side:");
                charCube[i] = Console.ReadLine().ToCharArray();
                Console.WriteLine();
            }

            Cube cube = new Cube();

            cube.topC = Color.Yellow;
            cube.frontC = Color.Red;

            for (int i = 0; i < cube.sides.Length; i++)
            {
                Side side = new Side();
                for (int j = 0; j < 9; j++)
                {
                    switch (charCube[i][j])
                    {
                        case 'R':
                        case 'r':
                            side.pieces[j] = new CubePiece(Color.Red);
                            break;
                        case 'G':
                        case 'g':
                            side.pieces[j] = new CubePiece(Color.Green);
                            break;
                        case 'O':
                        case 'o':
                            side.pieces[j] = new CubePiece(Color.Orange);
                            break;
                        case 'B':
                        case 'b':
                            side.pieces[j] = new CubePiece(Color.Blue);
                            break;
                        case 'Y':
                        case 'y':
                            side.pieces[j] = new CubePiece(Color.Yellow);
                            break;
                        case 'W':
                        case 'w':
                            side.pieces[j] = new CubePiece(Color.White);
                            break;
                    }
                }
                cube.sides[i] = side;
            }
            return cube;
        }
    }
}
