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
                    return new int[] { 2, 5, 8, 2, 4, 7, 0, 3, 6 };
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
                    return new int[] { 2, 5, 8, 2, 4, 7, 0, 3, 6 };
                case Color.Orange:
                    return new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 };
                case Color.Blue:
                    return new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 };
                default:
                    return new int[] { };
            }
        }
    }
}
