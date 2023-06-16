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
        private int[] edgesPermutration;
        private int[] centersPermutation;

        public PCube()
        {
            this.cornersPermutation = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            this.edgesPermutration = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            this.centersPermutation = new int[] { 0, 1, 2, 3, 4, 5 };
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
            ApplyMoves(moves.EdgeMoves, this.edgesPermutration);
            ApplyMoves(moves.CenterMoves, this.centersPermutation);
        }

        private static Color CornerToColor(int corner)
        {
            if ((0 <= corner) && (corner <= 3))
            {
                return Color.Red;
            }
            else if ((4 <= corner) && (corner <= 7))
            {
                return Color.Green;
            }
            else if ((8 <= corner) && (corner <= 11))
            {
                return Color.Orange;
            }
            else if ((12 <= corner) && (corner <= 15))
            {
                return Color.Blue;
            }
            else if ((16 <= corner) && (corner <= 19))
            {
                return Color.Yellow;
            }
            else
            {
                return Color.White;
            }
        }

        private static Color EdgeToColor(int edge)
        {
            if ((0 <= edge) && (edge <= 3))
            {
                return Color.Red;
            }
            else if ((4 <= edge) && (edge <= 7))
            {
                return Color.Green;
            }
            else if ((8 <= edge) && (edge <= 11))
            {
                return Color.Orange;
            }
            else if ((12 <= edge) && (edge <= 15))
            {
                return Color.Blue;
            }
            else if ((16 <= edge) && (edge <= 19))
            {
                return Color.Yellow;
            }
            else
            {
                return Color.White;
            }
        }

        private static Color CenterToColor(int center)
        {
            return (Color)center;
        }

        public Color[] GetSideColors(Side side)
        {
            switch (side)
            {
                case Side.Front:
                    return new Color[]
                    { 
                        CornerToColor(cornersPermutation[0]),
                        EdgeToColor(edgesPermutration[0]),
                        CornerToColor(cornersPermutation[1]),
                        EdgeToColor(edgesPermutration[3]),
                        CenterToColor(centersPermutation[0]),
                        EdgeToColor(edgesPermutration[1]),
                        CornerToColor(cornersPermutation[3]),
                        EdgeToColor(edgesPermutration[2]),
                        CornerToColor(cornersPermutation[2])
                    };
                case Side.Right:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[4]),
                        EdgeToColor(edgesPermutration[4]),
                        CornerToColor(cornersPermutation[5]),
                        EdgeToColor(edgesPermutration[7]),
                        CenterToColor(centersPermutation[1]),
                        EdgeToColor(edgesPermutration[5]),
                        CornerToColor(cornersPermutation[7]),
                        EdgeToColor(edgesPermutration[6]),
                        CornerToColor(cornersPermutation[6])
                    };
                case Side.Back:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[8]),
                        EdgeToColor(edgesPermutration[8]),
                        CornerToColor(cornersPermutation[9]),
                        EdgeToColor(edgesPermutration[11]),
                        CenterToColor(centersPermutation[2]),
                        EdgeToColor(edgesPermutration[9]),
                        CornerToColor(cornersPermutation[11]),
                        EdgeToColor(edgesPermutration[10]),
                        CornerToColor(cornersPermutation[10])
                    };
                case Side.Left:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[12]),
                        EdgeToColor(edgesPermutration[12]),
                        CornerToColor(cornersPermutation[13]),
                        EdgeToColor(edgesPermutration[15]),
                        CenterToColor(centersPermutation[3]),
                        EdgeToColor(edgesPermutration[13]),
                        CornerToColor(cornersPermutation[15]),
                        EdgeToColor(edgesPermutration[14]),
                        CornerToColor(cornersPermutation[14])
                    };
                case Side.Up:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[16]),
                        EdgeToColor(edgesPermutration[16]),
                        CornerToColor(cornersPermutation[17]),
                        EdgeToColor(edgesPermutration[19]),
                        CenterToColor(centersPermutation[4]),
                        EdgeToColor(edgesPermutration[17]),
                        CornerToColor(cornersPermutation[19]),
                        EdgeToColor(edgesPermutration[18]),
                        CornerToColor(cornersPermutation[18])
                    };
                case Side.Down:
                    return new Color[]
                    {
                        CornerToColor(cornersPermutation[20]),
                        EdgeToColor(edgesPermutration[20]),
                        CornerToColor(cornersPermutation[21]),
                        EdgeToColor(edgesPermutration[23]),
                        CenterToColor(centersPermutation[5]),
                        EdgeToColor(edgesPermutration[21]),
                        CornerToColor(cornersPermutation[23]),
                        EdgeToColor(edgesPermutration[22]),
                        CornerToColor(cornersPermutation[22])
                    };
                default:
                    throw new Exception("Invalid side!");
            }
        }
    }

    class Moves
    {
        private Dictionary<int, int> corners;
        private Dictionary<int, int> edges;
        private Dictionary<int, int> centers;

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

        private Moves()
        {
            this.corners = new Dictionary<int, int>();
            this.edges = new Dictionary<int, int>();
            this.centers = new Dictionary<int, int>();
        }

        public Moves(Move move)
        {
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
        }
    }
}
