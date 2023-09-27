using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSv2
{
    class PCube
    {
        private int[] cornersPermutation;
        private int[] edgesPermutation;
        private int[] centersPermutation;

        // Constructor
        public PCube()
        {
            this.cornersPermutation = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            this.edgesPermutation = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            this.centersPermutation = new int[] { 0, 1, 2, 3, 4, 5 };
        }

        public PCube(int[] cornersPermutation, int[] edgesPermutation, int[] centersPermutation)
        {
            this.cornersPermutation = cornersPermutation;
            this.edgesPermutation = edgesPermutation;
            this.centersPermutation = centersPermutation;
        }

        private void IdentifyEdge(Color mainColor, Color otherColor, out int main, out int other)
        {
            main = 24;
            other = 24;

            switch (mainColor)
            {
                case Color.Red:
                    switch (otherColor)
                    {
                        case Color.Yellow:
                            main = 0;
                            other = 18;
                            break;
                        case Color.Green:
                            main = 1;
                            other = 7;
                            break;
                        case Color.White:
                            main = 2;
                            other = 20;
                            break;
                        case Color.Blue:
                            main = 3;
                            other = 13;
                            break;
                    }
                    break;
                case Color.Green:
                    switch (otherColor)
                    {
                        case Color.Yellow:
                            main = 4;
                            other = 17;
                            break;
                        case Color.Orange:
                            main = 5;
                            other = 11;
                            break;
                        case Color.White:
                            main = 6;
                            other = 21;
                            break;
                        case Color.Red:
                            main = 7;
                            other = 1;
                            break;
                    }
                    break;
                case Color.Orange:
                    switch (otherColor)
                    {
                        case Color.Yellow:
                            main = 8;
                            other = 16;
                            break;
                        case Color.Blue:
                            main = 9;
                            other = 15;
                            break;
                        case Color.White:
                            main = 10;
                            other = 22;
                            break;
                        case Color.Green:
                            main = 11;
                            other = 5;
                            break;
                    }
                    break;
                case Color.Blue:
                    switch (otherColor)
                    {
                        case Color.Yellow:
                            main = 12;
                            other = 19;
                            break;
                        case Color.Red:
                            main = 13;
                            other = 3;
                            break;
                        case Color.White:
                            main = 14;
                            other = 23;
                            break;
                        case Color.Orange:
                            main = 15;
                            other = 9;
                            break;
                    }
                    break;
                case Color.Yellow:
                    switch (otherColor)
                    {
                        case Color.Orange:
                            main = 16;
                            other = 8;
                            break;
                        case Color.Green:
                            main = 17;
                            other = 4;
                            break;
                        case Color.Red:
                            main = 18;
                            other = 0;
                            break;
                        case Color.Blue:
                            main = 19;
                            other = 12;
                            break;
                    }
                    break;
                case Color.White:
                    switch (otherColor)
                    {
                        case Color.Red:
                            main = 20;
                            other = 2;
                            break;
                        case Color.Green:
                            main = 21;
                            other = 6;
                            break;
                        case Color.Orange:
                            main = 22;
                            other = 10;
                            break;
                        case Color.Blue:
                            main = 23;
                            other = 14;
                            break;
                    }
                    break;
            }
        }

        private void IdentifyCorner(Color mainColor, Color horizontalColor, Color verticalColor, out int main, out int horizontal, out int vertical)
        {
            main = 24;
            horizontal = 24;
            vertical = 24;

            switch (mainColor)
            {
                case Color.Red:
                    switch (horizontalColor)
                    {
                        case Color.Yellow:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 1;
                                    horizontal = 18;
                                    vertical = 4;
                                    break;
                                case Color.Blue:
                                    main = 0;
                                    horizontal = 19;
                                    vertical = 13;
                                    break;
                            }
                            break;
                        case Color.Green:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main = 1;
                                    horizontal = 4;
                                    vertical = 18;
                                    break;
                                case Color.White:
                                    main = 0;
                                    horizontal = 0;
                                    vertical = 0;
                                    break;
                            }
                            break;
                        case Color.White:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 2;
                                    horizontal = 21;
                                    vertical = 7;
                                    break;
                                case Color.Blue:
                                    main = 3;
                                    horizontal = 20;
                                    vertical = 14;
                                    break;
                            }
                            break;
                        case Color.Blue:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main =  0;
                                    horizontal = 13;
                                    vertical = 19;
                                    break;
                                case Color.White:
                                    main = 3;
                                    horizontal = 14;
                                    vertical = 20;
                                    break;
                            }
                            break;
                    }
                    break;
                case Color.Green:
                    switch (horizontalColor)
                    {
                        case Color.Yellow:
                            switch (verticalColor)
                            {
                                case Color.Red:
                                    main = 4;
                                    horizontal = 18;
                                    vertical = 1;
                                    break;
                                case Color.Orange:
                                    main = 5;
                                    horizontal = 17;
                                    vertical = 8;
                                    break;
                            }
                            break;
                        case Color.Orange:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main = 5;
                                    horizontal = 8;
                                    vertical = 17;
                                    break;
                                case Color.White:
                                    main = 6;
                                    horizontal = 11;
                                    vertical = 22;
                                    break;
                            }
                            break;
                        case Color.White:
                            switch (verticalColor)
                            {
                                case Color.Orange:
                                    main = 6;
                                    horizontal = 22;
                                    vertical = 11;
                                    break;
                                case Color.Red:
                                    main = 7;
                                    horizontal = 21;
                                    vertical = 2;
                                    break;
                            }
                            break;
                        case Color.Red:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main = 4;
                                    horizontal = 1;
                                    vertical = 18;
                                    break;
                                case Color.White:
                                    main = 7;
                                    horizontal = 2;
                                    vertical = 21;
                                    break;
                            }
                            break;
                    }
                    break;
                case Color.Orange:
                    switch (horizontalColor)
                    {
                        case Color.Yellow:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 8;
                                    horizontal = 17;
                                    vertical = 5;
                                    break;
                                case Color.Blue:
                                    main = 9;
                                    horizontal = 16;
                                    vertical = 12;
                                    break;
                            }
                            break;
                        case Color.Green:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main = 8;
                                    horizontal = 5;
                                    vertical = 17;
                                    break;
                                case Color.White:
                                    main = 11;
                                    horizontal = 6;
                                    vertical = 22;
                                    break;
                            }
                            break;
                        case Color.White:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 11;
                                    horizontal = 22;
                                    vertical = 6;
                                    break;
                                case Color.Blue:
                                    main = 10;
                                    horizontal = 23;
                                    vertical = 15;
                                    break;
                            }
                            break;
                        case Color.Blue:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main = 9;
                                    horizontal = 12;
                                    vertical = 16;
                                    break;
                                case Color.White:
                                    main = 10;
                                    horizontal = 15;
                                    vertical = 23;
                                    break;
                            }
                            break;
                    }
                    break;
                case Color.Blue:
                    switch (horizontalColor)
                    {
                        case Color.Yellow:
                            switch (verticalColor)
                            {
                                case Color.Red:
                                    main = 13;
                                    horizontal = 19;
                                    vertical = 0;
                                    break;
                                case Color.Orange:
                                    main = 12;
                                    horizontal = 16;
                                    vertical = 9;
                                    break;
                            }
                            break;
                        case Color.Red:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main = 13;
                                    horizontal = 0;
                                    vertical = 19;
                                    break;
                                case Color.White:
                                    main = 14;
                                    horizontal = 3;
                                    vertical = 20;
                                    break;
                            }
                            break;
                        case Color.White:
                            switch (verticalColor)
                            {
                                case Color.Red:
                                    main = 14;
                                    horizontal = 20;
                                    vertical = 3;
                                    break;
                                case Color.Orange:
                                    main = 15;
                                    horizontal = 23;
                                    vertical = 10;
                                    break;
                            }
                            break;
                        case Color.Orange:
                            switch (verticalColor)
                            {
                                case Color.Yellow:
                                    main = 12;
                                    horizontal = 9;
                                    vertical = 16;
                                    break;
                                case Color.White:
                                    main = 15;
                                    horizontal = 10;
                                    vertical = 23;
                                    break;
                            }
                            break;
                    }
                    break;
                case Color.Yellow:
                    switch (horizontalColor)
                    {
                        case Color.Orange:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 17;
                                    horizontal = 8;
                                    vertical = 5;
                                    break;
                                case Color.Blue:
                                    main = 16;
                                    horizontal = 9;
                                    vertical = 12;
                                    break;
                            }
                            break;
                        case Color.Green:
                            switch (verticalColor)
                            {
                                case Color.Orange:
                                    main = 17;
                                    horizontal = 5;
                                    vertical = 8;
                                    break;
                                case Color.Red:
                                    main = 18;
                                    horizontal = 4;
                                    vertical = 1;
                                    break;
                            }
                            break;
                        case Color.Red:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 18;
                                    horizontal = 1;
                                    vertical = 4;
                                    break;
                                case Color.Blue:
                                    main = 19;
                                    horizontal = 0;
                                    vertical = 13;
                                    break;
                            }
                            break;
                        case Color.Blue:
                            switch (verticalColor)
                            {
                                case Color.Orange:
                                    main = 16;
                                    horizontal = 12;
                                    vertical = 9;
                                    break;
                                case Color.Red:
                                    main = 19;
                                    horizontal = 13;
                                    vertical = 0;
                                    break;
                            }
                            break;
                    }
                    break;
                case Color.White:
                    switch (horizontalColor)
                    {
                        case Color.Red:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 21;
                                    horizontal = 2;
                                    vertical = 7;
                                    break;
                                case Color.Blue:
                                    main = 20;
                                    horizontal = 3;
                                    vertical = 14;
                                    break;
                            }
                            break;
                        case Color.Green:
                            switch (verticalColor)
                            {
                                case Color.Red:
                                    main = 21;
                                    horizontal = 7;
                                    vertical = 2;
                                    break;
                                case Color.Orange:
                                    main = 22;
                                    horizontal = 6;
                                    vertical = 11;
                                    break;
                            }
                            break;
                        case Color.Orange:
                            switch (verticalColor)
                            {
                                case Color.Green:
                                    main = 22;
                                    horizontal = 11;
                                    vertical = 6;
                                    break;
                                case Color.Blue:
                                    main = 23;
                                    horizontal = 10;
                                    vertical = 15;
                                    break;
                            }
                            break;
                        case Color.Blue:
                            switch (verticalColor)
                            {
                                case Color.Red:
                                    main = 20;
                                    horizontal = 14;
                                    vertical = 3;
                                    break;
                                case Color.Orange:
                                    main = 23;
                                    horizontal = 15;
                                    vertical = 10;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        public PCube(Dictionary<Side, Color[]> sides)
        {
            this.cornersPermutation = new int[24];
            this.edgesPermutation = new int[24];
            this.centersPermutation = new int[6];

            // Front corners
            IdentifyCorner(sides[Side.Front][0], sides[Side.Up][6], sides[Side.Left][2], out this.cornersPermutation[0], out this.cornersPermutation[19], out this.cornersPermutation[13]);
            IdentifyCorner(sides[Side.Front][2], sides[Side.Up][8], sides[Side.Right][0], out this.cornersPermutation[1], out this.cornersPermutation[18], out this.cornersPermutation[4]);
            IdentifyCorner(sides[Side.Front][6], sides[Side.Down][0], sides[Side.Left][8], out this.cornersPermutation[3], out this.cornersPermutation[20], out this.cornersPermutation[14]);
            IdentifyCorner(sides[Side.Front][8], sides[Side.Down][2], sides[Side.Right][6], out this.cornersPermutation[2], out this.cornersPermutation[21], out this.cornersPermutation[7]);

            // Back corners
            IdentifyCorner(sides[Side.Back][0], sides[Side.Up][2], sides[Side.Right][2], out this.cornersPermutation[8], out this.cornersPermutation[17], out this.cornersPermutation[5]);
            IdentifyCorner(sides[Side.Back][2], sides[Side.Up][0], sides[Side.Left][0], out this.cornersPermutation[9], out this.cornersPermutation[16], out this.cornersPermutation[12]);
            IdentifyCorner(sides[Side.Back][6], sides[Side.Down][8], sides[Side.Right][8], out this.cornersPermutation[11], out this.cornersPermutation[22], out this.cornersPermutation[6]);
            IdentifyCorner(sides[Side.Back][8], sides[Side.Down][6], sides[Side.Left][6], out this.cornersPermutation[10], out this.cornersPermutation[23], out this.cornersPermutation[15]);

            // Front edges
            IdentifyEdge(sides[Side.Front][1], sides[Side.Up][7], out this.edgesPermutation[0], out this.edgesPermutation[18]);
            IdentifyEdge(sides[Side.Front][3], sides[Side.Left][5], out this.edgesPermutation[3], out this.edgesPermutation[13]);
            IdentifyEdge(sides[Side.Front][5], sides[Side.Right][3], out this.edgesPermutation[1], out this.edgesPermutation[7]);
            IdentifyEdge(sides[Side.Front][7], sides[Side.Down][1], out this.edgesPermutation[2], out this.edgesPermutation[20]);

            // Middle edges
            IdentifyEdge(sides[Side.Up][3], sides[Side.Left][1], out this.edgesPermutation[19], out this.edgesPermutation[12]);
            IdentifyEdge(sides[Side.Up][5], sides[Side.Right][1], out this.edgesPermutation[17], out this.edgesPermutation[4]);
            IdentifyEdge(sides[Side.Down][3], sides[Side.Left][7], out this.edgesPermutation[23], out this.edgesPermutation[14]);
            IdentifyEdge(sides[Side.Down][5], sides[Side.Right][7], out this.edgesPermutation[21], out this.edgesPermutation[6]);

            // Back edges
            IdentifyEdge(sides[Side.Back][1], sides[Side.Up][1], out this.edgesPermutation[8], out this.edgesPermutation[16]);
            IdentifyEdge(sides[Side.Back][3], sides[Side.Right][5], out this.edgesPermutation[11], out this.edgesPermutation[5]);
            IdentifyEdge(sides[Side.Back][5], sides[Side.Left][3], out this.edgesPermutation[9], out this.edgesPermutation[15]);
            IdentifyEdge(sides[Side.Back][7], sides[Side.Down][7], out this.edgesPermutation[10], out this.edgesPermutation[22]);

            // Centers
            for (int i = 0; i < this.centersPermutation.Length; i++)
            {
                this.centersPermutation[i] = (int)sides[(Side)i][4];
            }
        }

        // Copy constructor
        public PCube(PCube other)
        {
            this.cornersPermutation = new int[other.cornersPermutation.Length];
            Array.Copy(other.cornersPermutation, this.cornersPermutation, other.cornersPermutation.Length);
            this.edgesPermutation = new int[other.edgesPermutation.Length];
            Array.Copy(other.edgesPermutation, this.edgesPermutation, other.edgesPermutation.Length);
            this.centersPermutation = new int[other.centersPermutation.Length];
            Array.Copy(other.centersPermutation, this.centersPermutation, other.centersPermutation.Length);
        }

        private static void ApplyMoves(Dictionary<int, int> moves, int[] permutation)
        {
            int[] oldPermutation = (int[])permutation.Clone();

            foreach (KeyValuePair<int, int> move in moves)
            {
                permutation[move.Value] = oldPermutation[move.Key];
            }
        }

        public void ApplyMoves(Moves moves)
        {
            ApplyMoves(moves.CornerMoves, this.cornersPermutation);
            ApplyMoves(moves.EdgeMoves, this.edgesPermutation);
            ApplyMoves(moves.CenterMoves, this.centersPermutation);
        }

        private static Color CornerToColor(int corner)
        {
            if (((0 <= corner) && (corner <= 3)) || corner == 24)
            {
                return Color.Red;
            }
            else if (((4 <= corner) && (corner <= 7)) || corner == 25)
            {
                return Color.Green;
            }
            else if (((8 <= corner) && (corner <= 11)) || corner == 26)
            {
                return Color.Orange;
            }
            else if (((12 <= corner) && (corner <= 15)) || corner == 27)
            {
                return Color.Blue;
            }
            else if (((16 <= corner) && (corner <= 19)) || corner == 28)
            {
                return Color.Yellow;
            }
            else if (((20 <= corner) && (corner <= 23)) || corner == 29)
            {
                return Color.White;
            }
            else if (corner == 30)
            {
                return Color.None;
            }
            else if (corner == 31)
            {
                return Color.Solved;
            }
            return Color.Red;
        }

        private static Color EdgeToColor(int edge)
        {
            if (((0 <= edge) && (edge <= 3)) || edge == 24)
            {
                return Color.Red;
            }
            else if (((4 <= edge) && (edge <= 7)) || edge == 25)
            {
                return Color.Green;
            }
            else if (((8 <= edge) && (edge <= 11)) || edge == 26)
            {
                return Color.Orange;
            }
            else if (((12 <= edge) && (edge <= 15)) || edge == 27)
            {
                return Color.Blue;
            }
            else if (((16 <= edge) && (edge <= 19)) || edge == 28)
            {
                return Color.Yellow;
            }
            else if (((20 <= edge) && (edge <= 23)) || edge == 29)
            {
                return Color.White;
            }
            else if (edge == 30)
            {
                return Color.None;
            }
            else if (edge == 31)
            {
                return Color.Solved;
            }
            return Color.Red;
        }

        private static Color CenterToColor(int center)
        {
            if (center == 30)
            {
                return Color.None;
            }
            else if (center == 31)
            {
                return Color.Solved;
            }
            else
            {
                return (Color)center;
            }
        }

        public Color[] GetSideColors(Side side)
        {
            switch (side)
            {
                case Side.Front:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[0]),
                        EdgeToColor(edgesPermutation[0]),
                        CornerToColor(cornersPermutation[1]),
                        EdgeToColor(edgesPermutation[3]),
                        CenterToColor(centersPermutation[0]),
                        EdgeToColor(edgesPermutation[1]),
                        CornerToColor(cornersPermutation[3]),
                        EdgeToColor(edgesPermutation[2]),
                        CornerToColor(cornersPermutation[2])
                    };
                case Side.Right:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[4]),
                        EdgeToColor(edgesPermutation[4]),
                        CornerToColor(cornersPermutation[5]),
                        EdgeToColor(edgesPermutation[7]),
                        CenterToColor(centersPermutation[1]),
                        EdgeToColor(edgesPermutation[5]),
                        CornerToColor(cornersPermutation[7]),
                        EdgeToColor(edgesPermutation[6]),
                        CornerToColor(cornersPermutation[6])
                    };
                case Side.Back:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[8]),
                        EdgeToColor(edgesPermutation[8]),
                        CornerToColor(cornersPermutation[9]),
                        EdgeToColor(edgesPermutation[11]),
                        CenterToColor(centersPermutation[2]),
                        EdgeToColor(edgesPermutation[9]),
                        CornerToColor(cornersPermutation[11]),
                        EdgeToColor(edgesPermutation[10]),
                        CornerToColor(cornersPermutation[10])
                    };
                case Side.Left:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[12]),
                        EdgeToColor(edgesPermutation[12]),
                        CornerToColor(cornersPermutation[13]),
                        EdgeToColor(edgesPermutation[15]),
                        CenterToColor(centersPermutation[3]),
                        EdgeToColor(edgesPermutation[13]),
                        CornerToColor(cornersPermutation[15]),
                        EdgeToColor(edgesPermutation[14]),
                        CornerToColor(cornersPermutation[14])
                    };
                case Side.Up:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[16]),
                        EdgeToColor(edgesPermutation[16]),
                        CornerToColor(cornersPermutation[17]),
                        EdgeToColor(edgesPermutation[19]),
                        CenterToColor(centersPermutation[4]),
                        EdgeToColor(edgesPermutation[17]),
                        CornerToColor(cornersPermutation[19]),
                        EdgeToColor(edgesPermutation[18]),
                        CornerToColor(cornersPermutation[18])
                    };
                case Side.Down:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[20]),
                        EdgeToColor(edgesPermutation[20]),
                        CornerToColor(cornersPermutation[21]),
                        EdgeToColor(edgesPermutation[23]),
                        CenterToColor(centersPermutation[5]),
                        EdgeToColor(edgesPermutation[21]),
                        CornerToColor(cornersPermutation[23]),
                        EdgeToColor(edgesPermutation[22]),
                        CornerToColor(cornersPermutation[22])
                    };
                default:
                    throw new Exception("Invalid side!");
            }
        }

        private List<int> IdentifyCornerPiece(int piece_number)
        {
            switch (piece_number)
            {
                case 0:
                case 13:
                case 19:
                    return new List<int> { 0, 13, 19 };
                case 1:
                case 4:
                case 18:
                    return new List<int> { 1, 4, 18 };
                case 2:
                case 7:
                case 21:
                    return new List<int> { 2, 7, 21 };
                case 3:
                case 14:
                case 20:
                    return new List<int> { 3, 14, 20 };
                case 5:
                case 8:
                case 17:
                    return new List<int> { 5, 8, 17 };
                case 6:
                case 11:
                case 22:
                    return new List<int> { 6, 11, 22 };
                case 9:
                case 12:
                case 16:
                    return new List<int> { 9, 12, 16 };
                case 10:
                case 15:
                case 23:
                    return new List<int> { 10, 15, 23 };
                default:
                    return null;
            }
        }

        private List<int> IdentifyEdgePiece(int piece_number)
        {
            switch (piece_number)
            {
                case 0:
                case 18:
                    return new List<int> { 0, 18 };
                case 1:
                case 7:
                    return new List<int> { 1, 7 };
                case 2:
                case 20:
                    return new List<int> { 2, 20 };
                case 3:
                case 13:
                    return new List<int> { 3, 13 };
                case 4:
                case 17:
                    return new List<int> { 4, 17 };
                case 5:
                case 11:
                    return new List<int> { 5, 11 };
                case 6:
                case 21:
                    return new List<int> { 6, 21 };
                case 8:
                case 16:
                    return new List<int> { 8, 16 };
                case 9:
                case 15:
                    return new List<int> { 9, 15 };
                case 10:
                case 22:
                    return new List<int> { 10, 22 };
                case 12:
                case 19:
                    return new List<int> { 12, 19 };
                case 14:
                case 23:
                    return new List<int> { 14, 23 };
                default:
                    return null;
            }
        }

        private int FaceToNeutral(int face)
        {
            if (face <= 3)
            {
                return 24;
            }
            else if (face <= 7)
            {
                return 25;
            }
            else if (face <= 11)
            {
                return 26;
            }
            else if (face <= 15)
            {
                return 27;
            }
            else if (face <= 19)
            {
                return 28;
            }
            else
            {
                return 29;
            }
        }

        private void SideToACJSFacelets(StringBuilder sb, Side side, int[] mapping)
        {
            Color[] sideColors = GetSideColors(side);

            foreach (int i in mapping)
            {
                sb.Append(EnumUtils.ColorToACJSColor(sideColors[i]));
            }
        }

        public string ToACJSFacelets()
        {
            StringBuilder sb = new StringBuilder();

            int[] upMapping = { 6, 7, 8, 3, 4, 5, 0, 1, 2 };
            int[] leftMapping = { 2, 1, 0, 5, 4, 3, 8, 7, 6 };
            int[] restMapping = { 0, 3, 6, 1, 4, 7, 2, 5, 8 };
            SideToACJSFacelets(sb, Side.Up, upMapping);
            SideToACJSFacelets(sb, Side.Down, restMapping);
            SideToACJSFacelets(sb, Side.Front, restMapping);
            SideToACJSFacelets(sb, Side.Back, restMapping);
            SideToACJSFacelets(sb, Side.Left, leftMapping);
            SideToACJSFacelets(sb, Side.Right, restMapping);

            return sb.ToString();
        }

        public void ApplyNoneMask(PCube mask)
        {
            for (int i = 0; i < cornersPermutation.Length; i++)
            {
                if (cornersPermutation[i] <= 23 && !mask.cornersPermutation.Contains(cornersPermutation[i]))
                {
                    foreach (int piece_index in IdentifyCornerPiece(i))
                    {
                        if (!mask.cornersPermutation.Contains(cornersPermutation[piece_index]))
                        {
                            cornersPermutation[piece_index] = 30;
                        }
                        else
                        {
                            cornersPermutation[piece_index] = FaceToNeutral(cornersPermutation[piece_index]);
                        }
                    }
                }
            }

            for (int i = 0; i < edgesPermutation.Length; i++)
            {
                if (edgesPermutation[i] <= 23 && !mask.edgesPermutation.Contains(edgesPermutation[i]))
                {
                    foreach (int piece_index in IdentifyEdgePiece(i))
                    {
                        if (!mask.edgesPermutation.Contains(edgesPermutation[piece_index]))
                        {
                            edgesPermutation[piece_index] = 30;
                        }
                        else
                        {
                            edgesPermutation[piece_index] = FaceToNeutral(edgesPermutation[piece_index]);
                        }
                    }
                }
            }

            for (int i = 0; i < centersPermutation.Length; i++)
            {
                if (centersPermutation[i] <= 23 && !mask.centersPermutation.Contains(centersPermutation[i]))
                {
                    centersPermutation[i] = 30;
                }
            }
        }

        public void ApplySolvedMask(PCube mask)
        {
            for (int i = 0; i < cornersPermutation.Length; i++)
            {
                if (cornersPermutation[i] <= 23 && mask.cornersPermutation.Contains(cornersPermutation[i]))
                {
                    cornersPermutation[i] = 31;
                }
            }

            for (int i = 0; i < edgesPermutation.Length; i++)
            {
                if (edgesPermutation[i] <= 23 && mask.edgesPermutation.Contains(edgesPermutation[i]))
                {
                    edgesPermutation[i] = 31;
                }
            }

            for (int i = 0; i < centersPermutation.Length; i++)
            {
                if (centersPermutation[i] <= 23 && mask.centersPermutation.Contains(centersPermutation[i]))
                {
                    centersPermutation[i] = 31;
                }
            }
        }

        public void RecolorCube(Dictionary<Side, Color> recolor)
        {
            Dictionary<Color, Color> recoloringGuide = new Dictionary<Color, Color>();
            for (int i = 0; i < centersPermutation.Length; i++)
            {
                Color originalColor = CenterToColor(centersPermutation[i]);
                Color desiredColor = recolor[(Side)i];
                recoloringGuide.Add(originalColor, desiredColor);
                centersPermutation[i] += ((int)desiredColor - (int)originalColor);
            }

            for (int i = 0; i < cornersPermutation.Length; i++)
            {
                Color originalColor = CornerToColor(cornersPermutation[i]);
                Color desiredColor = recoloringGuide[originalColor];
                cornersPermutation[i] += ((int)desiredColor - (int)originalColor) * 4;
            }

            for (int i = 0; i < edgesPermutation.Length; i++)
            {
                Color originalColor = EdgeToColor(edgesPermutation[i]);
                Color desiredColor = recoloringGuide[originalColor];
                edgesPermutation[i] += ((int)desiredColor - (int)originalColor) * 4;
            }
        }

        public void RecolorCubeV2(Dictionary<Side, Color> recolor)
        {
            Dictionary<Color, Color> recoloringGuide = new Dictionary<Color, Color>();
            for (int i = 0; i < this.centersPermutation.Length; i++)
            {
                Color originaColor = CenterToColor(this.centersPermutation[i]);
                Color desiredColor = recolor[(Side)i];
                recoloringGuide.Add(originaColor, desiredColor);
            }

            Dictionary<Side, Color[]> newLayout = new Dictionary<Side, Color[]>();
            foreach (Side s in Enum.GetValues(typeof(Side)))
            {
                Color[] newSide = new Color[9];
                Color[] oldSide = GetSideColors(s);

                for (int i = 0; i < newSide.Length; i++)
                {
                    newSide[i] = recoloringGuide[oldSide[i]];
                }

                newLayout.Add(s, newSide);
            }

            PCube newCube = new PCube(newLayout);
            this.cornersPermutation = newCube.cornersPermutation;
            this.edgesPermutation = newCube.edgesPermutation;
            this.centersPermutation = newCube.centersPermutation;
        }

        public bool SimpleCompare(PCube other)
        {
            for (int i = 0; i < cornersPermutation.Length; i++)
            {
                if (cornersPermutation[i] != other.cornersPermutation[i])
                {
                    return false;
                }
            }

            for (int i = 0; i < edgesPermutation.Length; i++)
            {
                if (edgesPermutation[i] != other.edgesPermutation[i])
                {
                    return false;
                }
            }

            for (int i = 0; i < centersPermutation.Length; i++)
            {
                if (centersPermutation[i] != other.centersPermutation[i])
                {
                    return false;
                }
            }

            return true;
        }

        private bool SidesCompare(PCube other, Dictionary<Side, bool[]> mask)
        {
            Dictionary<Color, Color> colorD = new Dictionary<Color, Color>();
            foreach (Side s in Enum.GetValues(typeof(Side)))
            {
                Color[] thisSide = this.GetSideColors(s);
                Color[] otherSide = other.GetSideColors(s);

                for (int i = 0; i < thisSide.Length; i++)
                {
                    if (!mask[s][i]) continue;

                    Color toCompare;
                    if (colorD.ContainsKey(thisSide[i]))
                    {
                        toCompare = colorD[thisSide[i]];
                    }
                    else
                    {
                        // ? if d hasValue(otherSide) return false;
                        colorD.Add(thisSide[i], otherSide[i]);
                        continue;
                    }
                    if (toCompare != otherSide[i]) return false;
                }
            }
            return true;
        }

        public bool Compare(PCube other, Dictionary<Side, bool[]> mask, Move[] interchangeableMoves, out Move? usedMove)
        {
            usedMove = null;

            if (other == null) return false;

            if (ReferenceEquals(this, other)) return true;

            if (SidesCompare(other, mask)) return true;

            foreach (Move move in interchangeableMoves)
            {
                PCube movedCube = new PCube(other);
                movedCube.ApplyMoves(new Moves(move));
                if (movedCube.SidesCompare(this, mask))
                {
                    usedMove = EnumUtils.GetOppositeMove(move);
                    return true;
                }
            }

            return false;
        }

        public bool Compare(PCube other, Dictionary<Side, bool[]> mask)
        {
            Move? move;
            return this.Compare(other, mask, null, out move);
        }
    }

    class Moves
    {
        private Dictionary<int, int> corners;
        private Dictionary<int, int> edges;
        private Dictionary<int, int> centers;
        private List<Move> description;

        public Dictionary<int, int> CornerMoves
        {
            get => corners;
        }

        public Dictionary<int, int> EdgeMoves
        {
            get => edges;
        }

        public Dictionary<int, int> CenterMoves
        {
            get => centers;
        }

        public Moves()
        {
            this.corners = new Dictionary<int, int>();
            this.edges = new Dictionary<int, int>();
            this.centers = new Dictionary<int, int>();
            this.description = new List<Move>();
        }

        public Moves(Move move)
        {
            this.description = new List<Move> { move };
            switch (move)
            {
                // Normal moves - basic - hardcoded
                case Move.U:
                    this.corners = new Dictionary<int, int> { { 0, 12 }, { 12, 8 }, { 8, 4 }, { 4, 0 }, { 1, 13 }, { 13, 9 }, { 9, 5 }, { 5, 1 }, { 16, 17 }, { 17, 18 }, { 18, 19 }, { 19, 16 } };
                    this.edges = new Dictionary<int, int> { { 0, 12 }, { 12, 8 }, { 8, 4 }, { 4, 0 }, { 16, 17 }, { 17, 18 }, { 18, 19 }, { 19, 16 } };
                    this.centers = new Dictionary<int, int>();
                    break;
                case Move.D:
                    this.corners = new Dictionary<int, int> { { 2, 6 }, { 6, 10 }, { 10, 14 }, { 14, 2 }, { 3, 7 }, { 7, 11 }, { 11, 15 }, { 15, 3 }, { 20, 21 }, { 21, 22 }, { 22, 23 }, { 23, 20 } };
                    this.edges = new Dictionary<int, int> { { 2, 6 }, { 6, 10 }, { 10, 14 }, { 14, 2 }, { 20, 21 }, { 21, 22 }, { 22, 23 }, { 23, 20 } };
                    this.centers = new Dictionary<int, int>();
                    break;
                case Move.R:
                    this.corners = new Dictionary<int, int> { { 1, 17 }, { 17, 11 }, { 11, 21 }, { 21, 1 }, { 2, 18 }, { 18, 8 }, { 8, 22 }, { 22, 2 }, { 4, 5 }, { 5, 6 }, { 6, 7 }, { 7, 4 } };
                    this.edges = new Dictionary<int, int> { { 1, 17 }, { 17, 11 }, { 11, 21 }, { 21, 1 }, { 4, 5 }, { 5, 6 }, { 6, 7 }, { 7, 4 } };
                    this.centers = new Dictionary<int, int>();
                    break;
                case Move.L:
                    this.corners = new Dictionary<int, int> { { 0, 20 }, { 20, 10 }, { 10, 16 }, { 16, 0 }, { 3, 23 }, { 23, 9 }, { 9, 19 }, { 19, 3 }, { 12, 13 }, { 13, 14 }, { 14, 15 }, { 15, 12 } };
                    this.edges = new Dictionary<int, int> { { 3, 23 }, { 23, 9 }, { 9, 19 }, { 19, 3 }, { 12, 13 }, { 13, 14 }, { 14, 15 }, { 15, 12 } };
                    this.centers = new Dictionary<int, int>();
                    break;
                case Move.F:
                    this.corners = new Dictionary<int, int> { { 18, 7 }, { 7, 20 }, { 20, 13 }, { 13, 18 }, { 19, 4 }, { 4, 21 }, { 21, 14 }, { 14, 19 }, { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 0 } };
                    this.edges = new Dictionary<int, int> { { 18, 7 }, { 7, 20 }, { 20, 13 }, { 13, 18 }, { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 0 } };
                    this.centers = new Dictionary<int, int>();
                    break;
                case Move.B:
                    this.corners = new Dictionary<int, int> { { 17, 12 }, { 12, 23 }, { 23, 6 }, { 6, 17 }, { 16, 15 }, { 15, 22 }, { 22, 5 }, { 5, 16 }, { 8, 9 }, { 9, 10 }, { 10, 11 }, { 11, 8 } };
                    this.edges = new Dictionary<int, int> { { 16, 15 }, { 15, 22 }, { 22, 5 }, { 5, 16 }, { 8, 9 }, { 9, 10 }, { 10, 11 }, { 11, 8 } };
                    this.centers = new Dictionary<int, int>();
                    break;
                case Move.M:
                    this.corners = new Dictionary<int, int>();
                    this.edges = new Dictionary<int, int> { { 0, 20 }, { 20, 10 }, { 10, 16 }, { 16, 0 }, { 2, 22 }, { 22, 8 }, { 8, 18 }, { 18, 2 } };
                    this.centers = new Dictionary<int, int> { { 0, 5 }, { 5, 2 }, { 2, 4 }, { 4, 0} };
                    break;
                case Move.E:
                    this.corners = new Dictionary<int, int>();
                    this.edges = new Dictionary<int, int> { { 3, 7 }, { 7, 11 }, { 11, 15 }, { 15, 3 }, { 1, 5 }, { 5, 9 }, { 9, 13 }, { 13, 1 } };
                    this.centers = new Dictionary<int, int> { { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 0 } };
                    break;
                case Move.S:
                    this.corners = new Dictionary<int, int>();
                    this.edges = new Dictionary<int, int> { { 19, 4 }, { 4, 21 }, { 21, 14 }, { 14, 19 }, { 17, 6 }, { 6, 23 }, { 23, 12 }, { 12, 17 } };
                    this.centers = new Dictionary<int, int> { { 4, 1 }, { 1, 5 }, { 5, 3 }, { 3, 4 } };
                    break;

                // Normal moves - prime
                case Move.Up:
                    Moves result = new Moves(Move.U);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Dp:
                    result = new Moves(Move.D);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Rp:
                    result = new Moves(Move.R);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Lp:
                    result = new Moves(Move.L);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Fp:
                    result = new Moves(Move.F);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Bp:
                    result = new Moves(Move.B);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Mp:
                    result = new Moves(Move.M);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Ep:
                    result = new Moves(Move.E);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Sp:
                    result = new Moves(Move.S);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;

                // Normal moves - double
                case Move.U2:
                    result = new Moves(Move.U);
                    result.AddMove(Move.U);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.D2:
                    result = new Moves(Move.D);
                    result.AddMove(Move.D);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.R2:
                    result = new Moves(Move.R);
                    result.AddMove(Move.R);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.L2:
                    result = new Moves(Move.L);
                    result.AddMove(Move.L);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.F2:
                    result = new Moves(Move.F);
                    result.AddMove(Move.F);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.B2:
                    result = new Moves(Move.B);
                    result.AddMove(Move.B);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.M2:
                    result = new Moves(Move.M);
                    result.AddMove(Move.M);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.E2:
                    result = new Moves(Move.E);
                    result.AddMove(Move.E);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.S2:
                    result = new Moves(Move.S);
                    result.AddMove(Move.S);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;

                // Wide moves - basic
                case Move.Uw:
                    result = new Moves(Move.U);
                    result.AddMove(Move.Ep);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Dw:
                    result = new Moves(Move.D);
                    result.AddMove(Move.E);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Rw:
                    result = new Moves(Move.R);
                    result.AddMove(Move.Mp);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Lw:
                    result = new Moves(Move.L);
                    result.AddMove(Move.M);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Fw:
                    result = new Moves(Move.F);
                    result.AddMove(Move.S);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Bw:
                    result = new Moves(Move.B);
                    result.AddMove(Move.Sp);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;

                // Wide moves - prime
                case Move.Uwp:
                    result = new Moves(Move.Uw);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Dwp:
                    result = new Moves(Move.Dw);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Rwp:
                    result = new Moves(Move.Rw);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Lwp:
                    result = new Moves(Move.Lw);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Fwp:
                    result = new Moves(Move.Fw);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Bwp:
                    result = new Moves(Move.Bw);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;

                // Wide moves - double
                case Move.Uw2:
                    result = new Moves(Move.Uw);
                    result.AddMove(Move.Uw);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Dw2:
                    result = new Moves(Move.Dw);
                    result.AddMove(Move.Dw);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Rw2:
                    result = new Moves(Move.Rw);
                    result.AddMove(Move.Rw);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Lw2:
                    result = new Moves(Move.Lw);
                    result.AddMove(Move.Lw);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Fw2:
                    result = new Moves(Move.Fw);
                    result.AddMove(Move.Fw);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Bw2:
                    result = new Moves(Move.Bw);
                    result.AddMove(Move.Bw);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;

                // Rotations - basic
                case Move.X:
                    result = new Moves(Move.Lp);
                    result.AddMove(Move.Mp);
                    result.AddMove(Move.R);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Y:
                    result = new Moves(Move.U);
                    result.AddMove(Move.Ep);
                    result.AddMove(Move.Dp);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Z:
                    result = new Moves(Move.F);
                    result.AddMove(Move.S);
                    result.AddMove(Move.Bp);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;

                // Rotations - prime
                case Move.Xp:
                    result = new Moves(Move.X);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Yp:
                    result = new Moves(Move.Y);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Zp:
                    result = new Moves(Move.Z);
                    result.Invert();
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;

                // Rotations - double
                case Move.X2:
                    result = new Moves(Move.X);
                    result.AddMove(Move.X);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Y2:
                    result = new Moves(Move.Y);
                    result.AddMove(Move.Y);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
                case Move.Z2:
                    result = new Moves(Move.Z);
                    result.AddMove(Move.Z);
                    this.corners = result.corners;
                    this.edges = result.edges;
                    this.centers = result.centers;
                    break;
            }
        }

        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Move move in description)
            {
                sb.Append(EnumUtils.MoveToString(move));
            }
            return sb.ToString();
        }

        private static Dictionary<int, int> GetInverse(Dictionary<int, int> m)
        {
            Dictionary<int, int> inverse = new Dictionary<int, int>();

            foreach (KeyValuePair<int, int> move in m)
            {
                inverse.Add(move.Value, move.Key);
            }

            return inverse;
        }

        public void Invert()
        {
            this.corners = GetInverse(this.corners);
            this.edges = GetInverse(this.edges);
            this.centers = GetInverse(this.centers);
            this.description.Reverse();
        }

        private static Dictionary<int, int> CombineMoves(int total_count, Dictionary<int, int> m1, Dictionary<int, int> m2)
        {
            Dictionary<int, int> combination = new Dictionary<int, int>();

            // Iterate over all possible key, value pairs even the ones that doesn't actually move
            for (int i = 0; i < total_count; i++)
            {
                if (m1.ContainsKey(i))
                {
                    if (m2.ContainsKey(m1[i]))
                    {
                        combination.Add(i, m2[m1[i]]);
                    }
                    else
                    {
                        combination.Add(i, m1[i]);
                    }
                }
                else
                {
                    if (m2.ContainsKey(i))
                    {
                        combination.Add(i, m2[i]);
                    }
                }
            }

            return combination;
        }

        public void AddMove(Move move)
        {
            Moves m = new Moves(move);
            this.corners = CombineMoves(24, this.corners, m.corners);
            this.edges = CombineMoves(24, this.edges, m.edges);
            this.centers = CombineMoves(6, this.centers, m.centers);
            this.description.Add(move);
        }

        public void AddMoves(Moves moves)
        {
            this.corners = CombineMoves(24, this.corners, moves.corners);
            this.edges = CombineMoves(24, this.edges, moves.edges);
            this.centers = CombineMoves(6, this.centers, moves.centers);
            this.description.AddRange(moves.description);
        }
    }
}
