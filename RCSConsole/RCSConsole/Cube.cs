using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Cube
    {
        public Side[] sides = new Side[6];
        public Color topC;
        public Color frontC;

        public Cube Clone()
        {
            Cube clone = new Cube();
            clone.topC = this.topC;
            clone.frontC = this.frontC;
            for (int i = 0; i < 6; i++)
            {
                clone.sides[i] = new Side();
                for (int j = 0; j < 9; j++)
                {
                    clone.sides[i].pieces[j] = new CubePiece(this.sides[i].pieces[j].Color);
                }
            }
            return clone;
        }

        // Return unified coordinates of the yellow side for each color side
        public static int[] GetYCoordinates(Color frontSide)
        {
            switch (frontSide)
            {
                case Color.Red:
                    return new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
                case Color.Green:
                    return new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 };
                case Color.Orange:
                    return new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 };
                case Color.Blue:
                    return new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 };
                default:
                    return new int[] { };
            }
        }

        // Return unified coordinates of the white side for each color side
        public static int[] GetWCoordinates(Color frontSide)
        {
            switch (frontSide)
            {
                case Color.Red:
                    return new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
                case Color.Green:
                    return new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 };
                case Color.Orange:
                    return new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 };
                case Color.Blue:
                    return new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 };
                default:
                    return new int[] { };
            }
        }

        // Return position of the left edge for the given edge position
        public static int GetLeftEdgePosition(int position)
        {
            switch (position)
            {
                case 1:
                    return 5;
                case 3:
                    return 1;
                case 5:
                    return 7;
                case 7:
                    return 3;
                default:
                    return -1;
            }
        }

        // Return position of the right edge for the given edge position
        public static int GetRightEdgePosition(int position)
        {
            switch (position)
            {
                case 1:
                    return 3;
                case 3:
                    return 7;
                case 5:
                    return 1;
                case 7:
                    return 5;
                default:
                    return -1;
            }
        }

        // Return position of the opposite edge for the given edge position
        public static int GetOppositeEdgePosition(int position)
        {
            switch (position)
            {
                case 1:
                    return 7;
                case 3:
                    return 5;
                case 5:
                    return 3;
                case 7:
                    return 1;
                default:
                    return -1;
            }
        }
    }
}
