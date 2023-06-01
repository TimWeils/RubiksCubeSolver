using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Algorithms
    {
        public static Solution WhiteCross(Cube cube)
        {
            // Check if White Cross is not already solved
            List<Color> colorsToComplete = new List<Color> { Color.Red, Color.Green, Color.Orange, Color.Blue };
            for (Color c = Color.Red; c < Color.Yellow; c++)
            {
                if ((cube.sides[(int)c].pieces[7].Color == c) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[1]].Color == Color.White))
                {
                    colorsToComplete.Remove(c);
                }
            }

            // It is
            if (colorsToComplete.Count == 0)
            {
                return new Solution();
            }
            else // Nope -> We need to complete it
            {
                return WCrossFindBestSolution(cube, colorsToComplete);
            }
        }

        private static Solution WCrossFindBestSolution(Cube cube, List<Color> colorsToComplete)
        {
            if (colorsToComplete.Count != 1)
            {
                Solution best = new Solution();
                best.turnsCount = int.MaxValue;
                foreach (Color c in colorsToComplete)
                {
                    Cube cCube = cube.Clone();
                    List<Color> remainingColors = new List<Color>(colorsToComplete);
                    remainingColors.Remove(c);
                    // Create solution using color c
                    Solution s = WCrossFindSolution(cCube, c, remainingColors);
                    Solution next = WCrossFindBestSolution(cCube, remainingColors);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                    if (s.turnsCount < best.turnsCount)
                    {
                        best = s;
                    }
                }
                return best;
            }
            else
            {
                // Create solution using remaining color
                return WCrossFindSolution(cube, colorsToComplete[0], new List<Color>());
            }
        }

        private static Solution WCrossFindSolution(Cube cube, Color c, List<Color> remainingColors)
        {
            Solution s = new Solution();

            // Check if piece is not already solved
            if ((cube.sides[(int)c].pieces[7].Color == c) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[1]].Color == Color.White))
            {
                // TODO
                // Add text
                return s;
            }


            if (cube.frontC != c)
            {
                Solution rotation = RotateCube(cube, c);
                s.steps.AddRange(rotation.steps);
                s.turnsCount += rotation.turnsCount;
            }

            // Check all possible positions of the piece we need to move and move it

            // Front side - color
            if ((cube.sides[(int)c].pieces[3].Color == c) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[5].Color == Color.White))
            {
                Moves.Fp(cube);

                Step step = new Step(Move.Fp);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[(int)c].pieces[5].Color == c) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[3].Color == Color.White))
            {
                Moves.F(cube);

                Step step = new Step(Move.F);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[(int)c].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[7]].Color == Color.White))
            {
                Moves.F2(cube);

                Step step = new Step(Move.F2);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            // Front side - white
            if ((cube.sides[(int)c].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[1]].Color == c))
            {
                Moves.F(cube);

                Step step = new Step(Move.F);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (remainingColors.Count != 3)
                {
                    Moves.Dp(cube);

                    step = new Step(Move.Dp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.L(cube);

                step = new Step(Move.L);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.D(cube);

                step = new Step(Move.D);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[(int)c].pieces[3].Color == Color.White) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[5].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.Dp(cube);

                    step = new Step(Move.Dp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.L(cube);

                step = new Step(Move.L);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.D(cube);

                step = new Step(Move.D);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[(int)c].pieces[5].Color == Color.White) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[3].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.D(cube);

                    step = new Step(Move.D);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.Rp(cube);

                step = new Step(Move.Rp);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.Dp(cube);

                step = new Step(Move.Dp);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[(int)c].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[7]].Color == c))
            {
                Moves.Fp(cube);

                Step step = new Step(Move.Fp);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (remainingColors.Count != 3)
                {
                    Moves.Dp(cube);

                    step = new Step(Move.Dp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.L(cube);

                step = new Step(Move.L);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.D(cube);

                step = new Step(Move.D);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            // Left side - color
            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[7].Color == c) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[3]].Color == Color.White))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Dp(cube);

                    step = new Step(Move.Dp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.L(cube);

                    step = new Step(Move.L);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.D(cube);

                step = new Step(Move.D);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[3]].Color == Color.White))
            {
                Moves.Up(cube);

                Step step = new Step(Move.Up);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F2(cube);

                step = new Step(Move.F2);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            // Left side - white
            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[3]].Color == c))
            {
                Moves.Lp(cube);

                Step step = new Step(Move.Lp);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.Fp(cube);

                step = new Step(Move.Fp);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[3]].Color == c))
            {
                Moves.L(cube);

                Step step = new Step(Move.L);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.Fp(cube);

                step = new Step(Move.Fp);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (!remainingColors.Contains(Modulo.sColorMod(c - 1)))
                {
                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                return s;
            }

            // Right side - color
            if ((cube.sides[Modulo.sIntMod(c + 1)].pieces[7].Color == c) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[5]].Color == Color.White))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.R(cube);

                    step = new Step(Move.R);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.D(cube);

                    step = new Step(Move.D);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Rp(cube);

                    step = new Step(Move.Rp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.Dp(cube);

                step = new Step(Move.Dp);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 1)].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[5]].Color == Color.White))
            {
                Moves.U(cube);

                Step step = new Step(Move.U);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F2(cube);

                step = new Step(Move.F2);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            // Right side - white
            if ((cube.sides[Modulo.sIntMod(c + 1)].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[5]].Color == c))
            {
                Moves.R(cube);

                Step step = new Step(Move.R);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F(cube);

                step = new Step(Move.F);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 1)].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[5]].Color == c))
            {
                Moves.Rp(cube);

                Step step = new Step(Move.Rp);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F(cube);

                step = new Step(Move.F);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.R(cube);

                    step = new Step(Move.R);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                return s;
            }

            // Back side - color
            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[7].Color == c) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[7]].Color == Color.White))
            {
                Step step;
                if (remainingColors.Count == 3)
                {
                    Moves.D2(cube);

                    step = new Step(Move.D2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    return s;
                }

                if (remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.B(cube);

                    step = new Step(Move.B);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.R2(cube);

                    step = new Step(Move.R2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.F(cube);

                    step = new Step(Move.F);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    return s;
                }

                if (remainingColors.Contains(Modulo.sColorMod(c - 1)))
                {
                    Moves.Bp(cube);

                    step = new Step(Move.Bp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.L2(cube);

                    step = new Step(Move.L2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Fp(cube);

                    step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    return s;
                }

                Moves.B2(cube);

                step = new Step(Move.B2);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.U2(cube);

                step = new Step(Move.U2);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F2(cube);

                step = new Step(Move.F2);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[3].Color == c) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[5].Color == Color.White))
            {
                Moves.R2(cube);

                Step step = new Step(Move.R2);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F(cube);

                step = new Step(Move.F);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.R2(cube);

                    step = new Step(Move.R2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[5].Color == c) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[3].Color == Color.White))
            {
                Moves.L2(cube);

                Step step = new Step(Move.L2);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.Fp(cube);

                step = new Step(Move.Fp);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.L2(cube);

                    step = new Step(Move.L2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[1]].Color == Color.White))
            {
                Moves.U2(cube);

                Step step = new Step(Move.U2);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F2(cube);

                step = new Step(Move.F2);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            // Back side - white
            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[7]].Color == c))
            {
                Moves.B(cube);

                Step step = new Step(Move.B);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.D(cube);

                step = new Step(Move.D);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.R(cube);

                step = new Step(Move.R);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.Dp(cube);

                step = new Step(Move.Dp);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[3].Color == Color.White) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[5].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.D(cube);

                    step = new Step(Move.D);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.R(cube);

                step = new Step(Move.R);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.Dp(cube);

                step = new Step(Move.Dp);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[5].Color == Color.White) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[3].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.Dp(cube);

                    step = new Step(Move.Dp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Moves.Lp(cube);

                step = new Step(Move.Lp);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.D(cube);

                step = new Step(Move.D);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[1]].Color == c))
            {
                Step step;
                if (remainingColors.Contains(Modulo.sColorMod(c - 1)))
                {
                    Moves.Up(cube);

                    step = new Step(Move.Up);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.L(cube);

                    step = new Step(Move.L);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Fp(cube);

                    step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    return s;
                }

                Moves.U(cube);

                step = new Step(Move.U);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.Rp(cube);

                step = new Step(Move.Rp);
                // TODO
                // Add text to step
                s.AddStep(step);

                Moves.F(cube);

                step = new Step(Move.F);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.R(cube);

                    step = new Step(Move.R);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                return s;
            }

            // This return is unreachable if the given cube is valid
            return s;
        }

        private static Solution RotateCube(Cube cube, Color c)
        {
            Solution s = new Solution();
            if (c == cube.frontC)
            {

            }
            else if (c == Modulo.sColorMod(cube.frontC + 1))
            {
                Moves.RotationY(cube);

                Step step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);

            }
            else if (c == Modulo.sColorMod(cube.frontC + 2))
            {
                Moves.RotationY2(cube);

                Step step = new Step(Move.RotationY2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (c == Modulo.sColorMod(cube.frontC - 1))
            {
                Moves.RotationYp(cube);

                Step step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            return s;
        }

        public static Solution DaisyWhiteCross(Cube cube)
        {
            // We don't check if any part of White Cross is already solved
            // It doesn't make much sence in this algorithm
            // Since we are creating Daisy and then we turn it into WC
            List<Color> colorsToComplete = new List<Color> { Color.Red, Color.Green, Color.Orange, Color.Blue };
            return DWCrossFindBestSolution(cube, colorsToComplete);
        }

        private static Solution DWCrossFindBestSolution(Cube cube, List<Color> colorsToComplete)
        {
            if (colorsToComplete.Count != 1)
            {
                Solution best = new Solution();
                best.turnsCount = int.MaxValue;
                foreach (Color c in colorsToComplete)
                {
                    Cube cCube = cube.Clone();
                    List<Color> remainingColors = new List<Color>(colorsToComplete);
                    remainingColors.Remove(c);
                    // Create solution using color c
                    Solution s = DWCrossFindSolution(cCube, c, remainingColors);
                    Solution next = DWCrossFindBestSolution(cCube, remainingColors);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                    if (s.turnsCount < best.turnsCount)
                    {
                        best = s;
                    }
                }
                return best;
            }
            else
            {
                // Create solution using remaining color
                return DWCrossFindSolution(cube, colorsToComplete[0], new List<Color>());
            }
        }

        private static Solution DWCrossFindSolution(Cube cube, Color c, List<Color> remainingColors)
        {
            Solution s = new Solution();

            // Check all possible edge piece positions and move to the top to create daisy
            ColorPair cp = new ColorPair(c, Color.White);
            Color orientation;
            if (CheckEdge(cube, EdgePosition.UM, cp, out orientation))
            {
                if (orientation == Color.White)
                {
                    // Flip the edge piece and insert it back to its position
                    Moves.Fp(cube);

                    Step step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    // Do nothing piece is in place
                }
            }
            else if (CheckEdge(cube, EdgePosition.UL, cp, out orientation))
            {
                Moves.RotationYp(cube);

                Step step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    // Flip the edge piece and insert it back to its position
                    Moves.Fp(cube);

                    step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    // Do nothing piece is in place
                }
            }
            else if (CheckEdge(cube, EdgePosition.UR, cp, out orientation))
            {
                Moves.RotationY(cube);

                Step step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    // Flip the edge piece and insert it back to its position
                    Moves.Fp(cube);

                    step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    // Do nothing piece is in place
                }
            }
            else if (CheckEdge(cube, EdgePosition.UB, cp, out orientation))
            {
                Moves.RotationY2(cube);

                Step step = new Step(Move.RotationY2);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    // Flip the edge piece and insert it back to its position
                    Moves.Fp(cube);

                    step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    // Do nothing piece is in place
                }
            }
            else if (CheckEdge(cube, EdgePosition.MFL, cp, out orientation))
            {
                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 3);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.Lp(cube);

                    Step step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F(cube);

                    Step step = new Step(Move.F);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }
            else if (CheckEdge(cube, EdgePosition.MFR, cp, out orientation))
            {
                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 5);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.R(cube);

                    Step step = new Step(Move.R);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.Fp(cube);

                    Step step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }
            else if (CheckEdge(cube, EdgePosition.MBL, cp, out orientation))
            {
                Moves.RotationYp(cube);

                Step step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F(cube);

                    step = new Step(Move.F);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 3);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }
            else if (CheckEdge(cube, EdgePosition.MBR, cp, out orientation))
            {
                Moves.RotationY(cube);

                Step step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.Fp(cube);

                    step = new Step(Move.Fp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 5);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.R(cube);

                    step = new Step(Move.R);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }
            else if (CheckEdge(cube, EdgePosition.DM, cp, out orientation))
            {
                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F(cube);

                    Step step = new Step(Move.F);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F2(cube);

                    Step step = new Step(Move.F2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }
            else if (CheckEdge(cube, EdgePosition.DL, cp, out orientation))
            {
                Moves.RotationYp(cube);

                Step step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F(cube);

                    step = new Step(Move.F);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F2(cube);

                    step = new Step(Move.F2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }
            else if (CheckEdge(cube, EdgePosition.DR, cp, out orientation))
            {
                Moves.RotationY(cube);

                Step step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F(cube);

                    step = new Step(Move.F);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F2(cube);

                    step = new Step(Move.F2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }
            else if (CheckEdge(cube, EdgePosition.DB, cp, out orientation))
            {
                Moves.RotationY2(cube);

                Step step = new Step(Move.RotationY2);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (orientation == Color.White)
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F(cube);

                    step = new Step(Move.F);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Moves.Lp(cube);

                    step = new Step(Move.Lp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else
                {
                    Solution freeDaisy = MakePositionOnDaisyFree(cube, 7);
                    s.steps.AddRange(freeDaisy.steps);
                    s.turnsCount += freeDaisy.turnsCount;

                    Moves.F2(cube);

                    step = new Step(Move.F2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
            }

            // If this was the last color -> Turn daisy into cross
            if (remainingColors.Count == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Step step;
                    Color daisyColor = cube.sides[(int)cube.frontC].pieces[1].Color;
                    // Find correct bottom
                    if (cube.frontC == daisyColor)
                    {
                        // Do nothing
                        // We have the correct bottom
                    }
                    else if (Modulo.sColorMod(cube.frontC - 1) == daisyColor)
                    {
                        Moves.Dw(cube);

                        step = new Step(Move.Dw);
                        // TODO
                        // Add text to step
                        s.AddStep(step);
                    }
                    else if (Modulo.sColorMod(cube.frontC + 1) == daisyColor)
                    {
                        Moves.Dwp(cube);

                        step = new Step(Move.Dwp);
                        // TODO
                        // Add text to step
                        s.AddStep(step);
                    }
                    else
                    {
                        Moves.Dw2(cube);

                        step = new Step(Move.Dw2);
                        // TODO
                        // Add text to step
                        s.AddStep(step);
                    }

                    // Insert the piece to the cross
                    Moves.F2(cube);

                    step = new Step(Move.F2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    if (i != 3)
                    {
                        // Move to the next color
                        Moves.RotationY(cube);

                        step = new Step(Move.RotationY);
                        // TODO
                        // Add text to step
                        s.AddStep(step);
                    }
                }
            }

            return s;
        }

        private static Solution MakePositionOnDaisyFree(Cube cube, int position)
        {
            Solution s = new Solution();
            int[] yellowCoords = Cube.GetYCoordinates(cube.frontC);
            if (cube.sides[4].pieces[yellowCoords[position]].Color != Color.White)
            {
                // Position is free
                return s;
            }
            else
            {
                if (cube.sides[4].pieces[yellowCoords[Cube.GetLeftEdgePosition(position)]].Color != Color.White)
                {
                    // Position is not free but the one on the left is
                    Moves.Up(cube);

                    Step step = new Step(Move.Up);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    return s;
                }
                else if (cube.sides[4].pieces[yellowCoords[Cube.GetRightEdgePosition(position)]].Color != Color.White)
                {
                    // Position is not free but the one on the right is
                    Moves.U(cube);

                    Step step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    return s;
                }
                else
                {
                    // Position is not free but the opposite one is
                    Moves.U2(cube);

                    Step step = new Step(Move.U2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    return s;
                }
            }
        }

        public static Solution WhiteCorners(Cube cube)
        {
            // Check if White Corners are not already solved
            List<ColorPair> cornersToComplete = new List<ColorPair>();
            // Pairs are created in such way that the first color (c1) denotes the front side from which we should insert the corner
            cornersToComplete.Add(new ColorPair(Color.Red, Color.Blue));
            cornersToComplete.Add(new ColorPair(Color.Green, Color.Red));
            cornersToComplete.Add(new ColorPair(Color.Orange, Color.Green));
            cornersToComplete.Add(new ColorPair(Color.Blue, Color.Orange));
            for (Color c = Color.Red; c < Color.Yellow; c += 2)
            {
                // Check corner on the left side
                Color left = Modulo.sColorMod(c - 1);
                if ((cube.sides[(int)c].pieces[6].Color == c) && (cube.sides[(int)left].pieces[8].Color == left))
                {
                    foreach (ColorPair cp in cornersToComplete)
                    {
                        if (((cp.c1 == c) && (cp.c2 == left)) || ((cp.c1 == left) && (cp.c2 == c)))
                        {
                            cornersToComplete.Remove(cp);
                            break;
                        }
                    }
                }

                // Check corner on the right side
                Color right = Modulo.sColorMod(c + 1);
                if ((cube.sides[(int)c].pieces[8].Color == c) && (cube.sides[(int)right].pieces[6].Color == right))
                {
                    foreach (ColorPair cp in cornersToComplete)
                    {
                        if (((cp.c1 == c) && (cp.c2 == right)) || ((cp.c1 == right) && (cp.c2 == c)))
                        {
                            cornersToComplete.Remove(cp);
                            break;
                        }
                    }
                }
            }

            // They are
            if (cornersToComplete.Count == 0)
            {
                return new Solution();
            }
            else // Nope -> We need to complete them
            {
                return WCornersFindBestSolution(cube, cornersToComplete);
            }
        }

        private static Solution WCornersFindBestSolution(Cube cube, List<ColorPair> cornersToComplete)
        {
            if (cornersToComplete.Count != 1)
            {
                Solution best = new Solution();
                best.turnsCount = int.MaxValue;
                foreach (ColorPair cp in cornersToComplete)
                {
                    Cube cCube = cube.Clone();
                    List<ColorPair> remainingCorners = new List<ColorPair>(cornersToComplete);
                    remainingCorners.Remove(cp);
                    // Create solution using color c
                    Solution s = WCornersFindSolution(cCube, cp);
                    Solution next = WCornersFindBestSolution(cCube, remainingCorners);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                    if (s.turnsCount < best.turnsCount)
                    {
                        best = s;
                    }
                }
                return best;
            }
            else
            {
                // Create solution using remaining color
                return WCornersFindSolution(cube, cornersToComplete[0]);
            }
        }

        // This algorith seems to complicated for begginer solvers
        // And advanced version is not needed since later on user will move to F2L
        // It is here just in case I would reconsider this and decided to add it or somehow reuse it
        // It may contain some errors
        /*/
        private static Solution WCornersFindSolution(Cube cube, ColorPair cp)
        {
            Solution s = new Solution();

            // Check if corner is not already solved
            if ((cube.sides[(int)cp.c1].pieces[6].Color == cp.c1) && (cube.sides[(int)cp.c2].pieces[8].Color == cp.c2) && (cube.sides[5].pieces[Cube.GetWCoordinates(cp.c1)[0]].Color == Color.White))
            {
                // TODO
                // Add text to step
                return s;
            }


            if (cube.frontC != cp.c1)
            {
                Solution rotation = RotateCube(cube, cp.c1);
                s.steps.AddRange(rotation.steps);
                s.turnsCount += rotation.turnsCount;
            }

            // Check all possible positions of the corner we need to solve and move it above the left corner

            Color cornerOrientation;

            // Check corners on top
            if (CheckCorner(cube, CornerPosition.UFL, cp, out cornerOrientation))
            {
                // Do nothing
                // Corner is in place
                // Remember its orientation
            }
            else if (CheckCorner(cube, CornerPosition.UFR, cp, out cornerOrientation))
            {
                Moves.U(cube);

                Step step = new Step();
                step.move = "U";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;
            }
            else if (CheckCorner(cube, CornerPosition.UBL, cp, out cornerOrientation))
            {
                Moves.oU(cube);

                Step step = new Step();
                step.move = "U'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;
            }
            else if (CheckCorner(cube, CornerPosition.UBR, cp, out cornerOrientation))
            {
                Moves.U2(cube);

                Step step = new Step();
                step.move = "U2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;
            }
            else if (CheckCorner(cube, CornerPosition.DFL, cp, out cornerOrientation))
            {
                if (cornerOrientation == cp.c1)
                {
                    Moves.oL(cube);

                    Step step = new Step();
                    step.move = "L'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oU(cube);

                    step = new Step();
                    step.move = "U'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.L(cube);

                    step = new Step();
                    step.move = "L";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U(cube);

                    step = new Step();
                    step.move = "U";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    // Fix orientation
                    cornerOrientation = cp.c2;
                }
                else
                {
                    Moves.oL(cube);

                    Step step = new Step();
                    step.move = "L'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U(cube);

                    step = new Step();
                    step.move = "U";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.L(cube);

                    step = new Step();
                    step.move = "L";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    // Fix orientation
                    if (cornerOrientation == cp.c2)
                    {
                        cornerOrientation = cp.c1;
                    }
                    else
                    {
                        cornerOrientation = cp.c2;
                    }
                }
            }
            else if (CheckCorner(cube, CornerPosition.DFR, cp, out cornerOrientation))
            {
                if (cornerOrientation == cp.c1)
                {
                    Moves.R(cube);

                    Step step = new Step();
                    step.move = "R";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oU(cube);

                    step = new Step();
                    step.move = "U'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oR(cube);

                    step = new Step();
                    step.move = "R'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U(cube);

                    step = new Step();
                    step.move = "U";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    // Fix orientation
                    cornerOrientation = cp.c2;
                }
                else
                {
                    Moves.R(cube);

                    Step step = new Step();
                    step.move = "R";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U(cube);

                    step = new Step();
                    step.move = "U";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oR(cube);

                    step = new Step();
                    step.move = "R'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    // Fix orientation
                    if (cornerOrientation == cp.c2)
                    {
                        cornerOrientation = cp.c1;
                    }
                    else
                    {
                        cornerOrientation = cp.c2;
                    }
                }
            }
            else if (CheckCorner(cube, CornerPosition.DBL, cp, out cornerOrientation))
            {
                if (cornerOrientation == cp.c2)
                {
                    Moves.L(cube);

                    Step step = new Step();
                    step.move = "L";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U(cube);

                    step = new Step();
                    step.move = "U";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oL(cube);

                    step = new Step();
                    step.move = "L'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U2(cube);

                    step = new Step();
                    step.move = "U2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;
                    
                    // Fix orientation
                    cornerOrientation = cp.c1;
                }
                else
                {
                    Moves.L(cube);

                    Step step = new Step();
                    step.move = "L";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oU(cube);

                    step = new Step();
                    step.move = "U'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oL(cube);

                    step = new Step();
                    step.move = "L'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oU(cube);

                    step = new Step();
                    step.move = "U'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    // Fix orientation
                    if (cornerOrientation == cp.c1)
                    {
                        cornerOrientation = cp.c2;
                    }
                    else
                    {
                        cornerOrientation = cp.c1;
                    }
                }
            }
            else if (CheckCorner(cube, CornerPosition.DBR, cp, out cornerOrientation))
            {
                if (cornerOrientation == cp.c2)
                {
                    Moves.oR(cube);

                    Step step = new Step();
                    step.move = "R'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U(cube);

                    step = new Step();
                    step.move = "U";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.R(cube);

                    step = new Step();
                    step.move = "R";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U2(cube);

                    step = new Step();
                    step.move = "U2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;

                    // Fix orientation
                    cornerOrientation = cp.c1;
                }
                else
                {
                    Moves.oR(cube);

                    Step step = new Step();
                    step.move = "R'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oU(cube);

                    step = new Step();
                    step.move = "U'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.R(cube);

                    step = new Step();
                    step.move = "R";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oU(cube);

                    step = new Step();
                    step.move = "U'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    // Fix orientation
                    if (cornerOrientation == cp.c1)
                    {
                        cornerOrientation = cp.c2;
                    }
                    else
                    {
                        cornerOrientation = cp.c1;
                    }
                }
            }

            // According to orientation execute one of the 3 algorithms
            if (cornerOrientation == cp.c1)
            {
                Moves.oU(cube);

                Step step = new Step();
                step.move = "U'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.oL(cube);

                step = new Step();
                step.move = "L'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.U(cube);

                step = new Step();
                step.move = "U";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.L(cube);

                step = new Step();
                step.move = "L";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }
            else
            {
                Step step;
                if (cornerOrientation == Color.White)
                {
                    Moves.oL(cube);

                    step = new Step();
                    step.move = "L'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U2(cube);

                    step = new Step();
                    step.move = "U2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;

                    Moves.L(cube);

                    step = new Step();
                    step.move = "L";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.U(cube);

                    step = new Step();
                    step.move = "U";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
                }

                Moves.oL(cube);

                step = new Step();
                step.move = "L'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.oU(cube);

                step = new Step();
                step.move = "U'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.L(cube);

                step = new Step();
                step.move = "L";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }
        }
        /**/

        private static Solution WCornersFindSolution(Cube cube, ColorPair cp)
        {
            Solution s = new Solution();

            // Check if corner is not already solved
            if ((cube.sides[(int)cp.c1].pieces[6].Color == cp.c1) && (cube.sides[(int)cp.c2].pieces[8].Color == cp.c2) && (cube.sides[5].pieces[Cube.GetWCoordinates(cp.c1)[0]].Color == Color.White))
            {
                // TODO
                // Add text to step
                return s;
            }

            // Check all possible positions of the corner we need to solve and move it above the left corner

            Color cornerOrientation;

            // Check corners on top
            if (CheckCorner(cube, CornerPosition.UFL, cp, out cornerOrientation))
            {
                // Do nothing
                // Corner is in place
                // Remember its orientation
            }
            else if (CheckCorner(cube, CornerPosition.UFR, cp, out cornerOrientation))
            {
                Moves.RotationY(cube);

                Step step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckCorner(cube, CornerPosition.UBL, cp, out cornerOrientation))
            {
                Moves.RotationYp(cube);

                Step step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckCorner(cube, CornerPosition.UBR, cp, out cornerOrientation))
            {
                Moves.RotationY2(cube);

                Step step = new Step(Move.RotationY2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckCorner(cube, CornerPosition.DFL, cp, out cornerOrientation))
            {
                if (cornerOrientation == cp.c1)
                {
                    Solution moveCorner = WCornersAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    Moves.U(cube);

                    Step step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Fix orientation
                    cornerOrientation = cp.c2;
                }
                else
                {
                    Solution moveCorner = WCornersGetOutAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    // Fix orientation
                    if (cornerOrientation == cp.c2)
                    {
                        cornerOrientation = cp.c1;
                    }
                    else
                    {
                        cornerOrientation = cp.c2;
                    }
                }
            }
            else if (CheckCorner(cube, CornerPosition.DFR, cp, out cornerOrientation))
            {
                Moves.RotationY(cube);
                Step step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (cornerOrientation == cp.c1)
                {
                    Solution moveCorner = WCornersAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Fix orientation
                    cornerOrientation = cp.c2;
                }
                else
                {
                    Solution moveCorner = WCornersGetOutAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    // Fix orientation
                    if (cornerOrientation == cp.c2)
                    {
                        cornerOrientation = cp.c1;
                    }
                    else
                    {
                        cornerOrientation = cp.c2;
                    }
                }
            }
            else if (CheckCorner(cube, CornerPosition.DBL, cp, out cornerOrientation))
            {
                Moves.RotationYp(cube);

                Step step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (cornerOrientation == cp.c1)
                {
                    Solution moveCorner = WCornersAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Fix orientation
                    cornerOrientation = cp.c2;
                }
                else
                {
                    Solution moveCorner = WCornersGetOutAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    // Fix orientation
                    if (cornerOrientation == cp.c2)
                    {
                        cornerOrientation = cp.c1;
                    }
                    else
                    {
                        cornerOrientation = cp.c2;
                    }
                }
            }
            else if (CheckCorner(cube, CornerPosition.DBR, cp, out cornerOrientation))
            {
                Moves.RotationY2(cube);
                Step step = new Step(Move.RotationY2);
                // TODO
                // Add text to step
                s.AddStep(step);

                if (cornerOrientation == cp.c1)
                {
                    Solution moveCorner = WCornersAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    Moves.U(cube);

                    step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Fix orientation
                    cornerOrientation = cp.c2;
                }
                else
                {
                    Solution moveCorner = WCornersGetOutAlg2(cube);
                    s.steps.AddRange(moveCorner.steps);
                    s.turnsCount += moveCorner.turnsCount;

                    // Fix orientation
                    if (cornerOrientation == cp.c2)
                    {
                        cornerOrientation = cp.c1;
                    }
                    else
                    {
                        cornerOrientation = cp.c2;
                    }
                }
            }

            // Find the corresponding bottom for the given corner on front
            if (cube.frontC == cp.c1)
            {
                // Do nothing
                // We have the correct bottom
            }
            else if (Modulo.sColorMod(cube.frontC - 1) == cp.c1)
            {
                Moves.Dw(cube);

                Step step = new Step(Move.Dw);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (Modulo.sColorMod(cube.frontC + 1) == cp.c1)
            {
                Moves.Dwp(cube);

                Step step = new Step(Move.Dwp);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else
            {
                Moves.Dw2(cube);

                Step step = new Step(Move.Dw2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }

            // According to orientation execute one of the 3 algorithms
            if (cornerOrientation == cp.c1)
            {
                Solution moveCorner = WCornersAlg1(cube);
                s.steps.AddRange(moveCorner.steps);
                s.turnsCount += moveCorner.turnsCount;

                return s;
            }
            else if (cornerOrientation == cp.c2)
            {
                Solution moveCorner = WCornersAlg2(cube);
                s.steps.AddRange(moveCorner.steps);
                s.turnsCount += moveCorner.turnsCount;

                return s;
            }
            else
            {
                Solution moveCorner = WCornersAlg3(cube);
                s.steps.AddRange(moveCorner.steps);
                s.turnsCount += moveCorner.turnsCount;

                return s;
            }
        }

        private static Solution WCornersAlg1(Cube cube)
        {
            Solution s = new Solution();

            Moves.Up(cube);

            Step step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Lp(cube);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.L(cube);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution WCornersAlg2(Cube cube)
        {
            Solution s = new Solution();

            Moves.Lp(cube);

            Step step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.L(cube);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution WCornersAlg3(Cube cube)
        {
            Solution s = new Solution();

            Moves.Lp(cube);

            Step step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.L(cube);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Lp(cube);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.L(cube);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution WCornersGetOutAlg2(Cube cube)
        {
            Solution s = new Solution();

            Moves.Lp(cube);

            Step step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.L(cube);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static bool CheckCorner(Cube cube, CornerPosition corner, ColorPair cp, out Color orientation)
        {
            switch (corner)
            {
                case CornerPosition.UFL:
                    int front = (int)cube.frontC;
                    int left = Modulo.sIntMod(cube.frontC - 1);
                    int[] yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[front].pieces[0].Color == cp.c1) && (cube.sides[left].pieces[2].Color == Color.White) && (cube.sides[4].pieces[yellowCoords[6]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[0].Color == Color.White) && (cube.sides[left].pieces[2].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[6]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[0].Color == cp.c2) && (cube.sides[left].pieces[2].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[6]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case CornerPosition.UFR:
                    front = (int)cube.frontC;
                    int right = Modulo.sIntMod(cube.frontC + 1);
                    yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[front].pieces[2].Color == Color.White) && (cube.sides[right].pieces[0].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[8]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[2].Color == cp.c2) && (cube.sides[right].pieces[0].Color == Color.White) && (cube.sides[4].pieces[yellowCoords[8]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[2].Color == cp.c1) && (cube.sides[right].pieces[0].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[8]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case CornerPosition.UBL:
                    int back = Modulo.sIntMod(cube.frontC + 2);
                    left = Modulo.sIntMod(cube.frontC - 1);
                    yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[back].pieces[2].Color == Color.White) && (cube.sides[left].pieces[0].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[0]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[2].Color == cp.c2) && (cube.sides[left].pieces[0].Color == Color.White) && (cube.sides[4].pieces[yellowCoords[0]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[2].Color == cp.c1) && (cube.sides[left].pieces[0].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[0]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case CornerPosition.UBR:
                    back = Modulo.sIntMod(cube.frontC + 2);
                    right = Modulo.sIntMod(cube.frontC + 1);
                    yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[back].pieces[0].Color == cp.c1) && (cube.sides[right].pieces[2].Color == Color.White) && (cube.sides[4].pieces[yellowCoords[2]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[0].Color == Color.White) && (cube.sides[right].pieces[2].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[2]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[0].Color == cp.c2) && (cube.sides[right].pieces[2].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[2]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case CornerPosition.DFL:
                    front = (int)cube.frontC;
                    left = Modulo.sIntMod(cube.frontC - 1);
                    int[] whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[front].pieces[6].Color == Color.White) && (cube.sides[left].pieces[8].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[0]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[6].Color == cp.c2) && (cube.sides[left].pieces[8].Color == Color.White) && (cube.sides[5].pieces[whiteCoords[0]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[6].Color == cp.c1) && (cube.sides[left].pieces[8].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[0]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case CornerPosition.DFR:
                    front = (int)cube.frontC;
                    right = Modulo.sIntMod(cube.frontC + 1);
                    whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[front].pieces[8].Color == cp.c1) && (cube.sides[right].pieces[6].Color == Color.White) && (cube.sides[5].pieces[whiteCoords[2]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[8].Color == Color.White) && (cube.sides[right].pieces[6].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[2]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[8].Color == cp.c2) && (cube.sides[right].pieces[6].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[2]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case CornerPosition.DBL:
                    back = Modulo.sIntMod(cube.frontC + 2);
                    left = Modulo.sIntMod(cube.frontC - 1);
                    whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[back].pieces[8].Color == cp.c1) && (cube.sides[left].pieces[6].Color == Color.White) && (cube.sides[5].pieces[whiteCoords[6]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[8].Color == Color.White) && (cube.sides[left].pieces[6].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[6]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[8].Color == cp.c2) && (cube.sides[left].pieces[6].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[6]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case CornerPosition.DBR:
                    back = Modulo.sIntMod(cube.frontC + 2);
                    right = Modulo.sIntMod(cube.frontC + 1);
                    whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[back].pieces[6].Color == Color.White) && (cube.sides[right].pieces[8].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[8]].Color == cp.c2))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[6].Color == cp.c2) && (cube.sides[right].pieces[8].Color == Color.White) && (cube.sides[5].pieces[whiteCoords[8]].Color == cp.c1))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[6].Color == cp.c1) && (cube.sides[right].pieces[8].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[8]].Color == Color.White))
                    {
                        orientation = Color.White;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                default:
                    orientation = Color.Red;
                    return false;
            }
        }

        public static Solution MiddleEdges(Cube cube)
        {
            // Check if Middle Edges are not already solved
            List<ColorPair> edgesToComplete = new List<ColorPair>();
            // Pairs are created so that it is easy to check them (we don't need any particular orientation for better solution finding)
            edgesToComplete.Add(new ColorPair(Color.Red, Color.Blue));
            edgesToComplete.Add(new ColorPair(Color.Red, Color.Green));
            edgesToComplete.Add(new ColorPair(Color.Orange, Color.Green));
            edgesToComplete.Add(new ColorPair(Color.Orange, Color.Blue));
            for (Color c = Color.Red; c < Color.Yellow; c += 2)
            {
                // Check edge on the left side
                Color left = Modulo.sColorMod(c - 1);
                if ((cube.sides[(int)c].pieces[3].Color == c) && (cube.sides[(int)left].pieces[5].Color == left))
                {
                    foreach (ColorPair cp in edgesToComplete)
                    {
                        if ((cp.c1 == c) && (cp.c2 == left))
                        {
                            edgesToComplete.Remove(cp);
                            break;
                        }
                    }
                }

                // Check edge on the right side
                Color right = Modulo.sColorMod(c + 1);
                if ((cube.sides[(int)c].pieces[5].Color == c) && (cube.sides[(int)right].pieces[3].Color == right))
                {
                    foreach (ColorPair cp in edgesToComplete)
                    {
                        if ((cp.c1 == c) && (cp.c2 == right))
                        {
                            edgesToComplete.Remove(cp);
                            break;
                        }
                    }
                }
            }

            // They are
            if (edgesToComplete.Count == 0)
            {
                return new Solution();
            }
            else // Nope -> We need to complete them
            {
                return MEdgesFindBestSolution(cube, edgesToComplete);
            }
        }

        private static Solution MEdgesFindBestSolution(Cube cube, List<ColorPair> edgesToComplete)
        {
            if (edgesToComplete.Count != 1)
            {
                Solution best = new Solution();
                best.turnsCount = int.MaxValue;
                foreach (ColorPair cp in edgesToComplete)
                {
                    Cube cCube = cube.Clone();
                    List<ColorPair> remainingEdges = new List<ColorPair>(edgesToComplete);
                    remainingEdges.Remove(cp);
                    // Create solution using color pair cp
                    Solution s = MEdgesFindSolution(cCube, cp);
                    Solution next = MEdgesFindBestSolution(cCube, remainingEdges);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                    if (s.turnsCount < best.turnsCount)
                    {
                        best = s;
                    }
                }
                return best;
            }
            else
            {
                // Create solution using remaining color pair
                return MEdgesFindSolution(cube, edgesToComplete[0]);
            }
        }

        private static Solution MEdgesFindSolution(Cube cube, ColorPair cp)
        {
            Solution s = new Solution();

            // Check if edge is not already solved
            if ((Modulo.sColorMod(cp.c1 - 1) == cp.c2) && (cube.sides[(int)cp.c1].pieces[3].Color == cp.c1) && (cube.sides[(int)cp.c2].pieces[5].Color == cp.c2))
            {
                // TODO
                // Add text to step
                return s;
            }

            if ((Modulo.sColorMod(cp.c1 + 1) == cp.c2) && (cube.sides[(int)cp.c2].pieces[3].Color == cp.c2) && (cube.sides[(int)cp.c1].pieces[5].Color == cp.c1))
            {
                // TODO
                // Add text to step
                return s;
            }

            Step step;

            // Check all possible positions of the edge we need to solve and move it to the front
            Color orientation;
            // We don't need to check UF since we don't need to do anything in this situation
            if (CheckEdge(cube, EdgePosition.UL, cp, out orientation))
            {
                Moves.RotationYp(cube);

                step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckEdge(cube, EdgePosition.UR, cp, out orientation))
            {
                Moves.RotationY(cube);

                step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckEdge(cube, EdgePosition.UB, cp, out orientation))
            {
                Moves.RotationY2(cube);

                step = new Step(Move.RotationY2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckEdge(cube, EdgePosition.MFL, cp, out orientation))
            {
                Solution moveEdge = ChangeLeftEdge(cube, false);
                s.steps.AddRange(moveEdge.steps);
                s.turnsCount += moveEdge.turnsCount;

                Moves.U2(cube);

                step = new Step(Move.U2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckEdge(cube, EdgePosition.MFR, cp, out orientation))
            {
                Solution moveEdge = ChangeRightEdge(cube, false);
                s.steps.AddRange(moveEdge.steps);
                s.turnsCount += moveEdge.turnsCount;

                Moves.U2(cube);

                step = new Step(Move.U2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckEdge(cube, EdgePosition.MBL, cp, out orientation))
            {
                Moves.RotationYp(cube);

                step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);

                Solution moveEdge = ChangeLeftEdge(cube, false);
                s.steps.AddRange(moveEdge.steps);
                s.turnsCount += moveEdge.turnsCount;

                Moves.U2(cube);

                step = new Step(Move.U2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (CheckEdge(cube, EdgePosition.MBR, cp, out orientation))
            {
                Moves.RotationY(cube);

                step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);

                Solution moveEdge = ChangeRightEdge(cube, false);
                s.steps.AddRange(moveEdge.steps);
                s.turnsCount += moveEdge.turnsCount;

                Moves.U2(cube);

                step = new Step(Move.U2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }

            // Find the correspondig bottom for the given edge on front
            Color edgeFrontColor = cube.sides[(int)cube.frontC].pieces[1].Color;
            if (cube.frontC == edgeFrontColor)
            {
                // Do nothing
                // We have the correct bottom
            }
            else if (Modulo.sColorMod(cube.frontC - 1) == edgeFrontColor)
            {
                Moves.Dw(cube);

                step = new Step(Move.Dw);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else if (Modulo.sColorMod(cube.frontC + 1) == edgeFrontColor)
            {
                Moves.Dwp(cube);

                step = new Step(Move.Dwp);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else
            {
                Moves.Dw2(cube);

                step = new Step(Move.Dw2);
                // TODO
                // Add text to step
                s.AddStep(step);
            }

            // Insert the edge to the correct side
            Color edgeTopColor = cube.sides[4].pieces[Cube.GetYCoordinates(cube.frontC)[7]].Color;
            if (Modulo.sColorMod(cube.frontC - 1) == edgeTopColor)
            {
                Solution moveEdge = ChangeLeftEdge(cube, true);
                s.steps.AddRange(moveEdge.steps);
                s.turnsCount += moveEdge.turnsCount;
            }
            else
            {
                Solution moveEdge = ChangeRightEdge(cube, true);
                s.steps.AddRange(moveEdge.steps);
                s.turnsCount += moveEdge.turnsCount;
            }

            return s;
        }

        private static Solution ChangeLeftEdge(Cube cube, bool insertFrontEdge)
        {
            Solution s = new Solution();
            Step step;

            if (insertFrontEdge)
            {
                Moves.Up(cube);

                step = new Step(Move.Up);
                // TODO
                // Add text to step
                s.AddStep(step);
            }

            Moves.Lp(cube);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.L(cube);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.F(cube);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution ChangeRightEdge(Cube cube, bool insertFrontEdge)
        {
            Solution s = new Solution();
            Step step;

            if (insertFrontEdge)
            {
                Moves.U(cube);

                step = new Step(Move.U);
                // TODO
                // Add text to step
                s.AddStep(step);
            }

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.F(cube);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static bool CheckEdge(Cube cube, EdgePosition edge, ColorPair cp, out Color orientation)
        {
            switch (edge)
            {
                case EdgePosition.UM:
                    int front = (int)cube.frontC;
                    int[] yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[front].pieces[1].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[7]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[1].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[7]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.UL:
                    int left = Modulo.sIntMod(cube.frontC - 1);
                    yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[left].pieces[1].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[3]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[left].pieces[1].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[3]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.UR:
                    int right = Modulo.sIntMod(cube.frontC + 1);
                    yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[right].pieces[1].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[5]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[right].pieces[1].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[5]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.UB:
                    int back = Modulo.sIntMod(cube.frontC + 2);
                    yellowCoords = Cube.GetYCoordinates(cube.frontC);
                    if ((cube.sides[back].pieces[1].Color == cp.c1) && (cube.sides[4].pieces[yellowCoords[1]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[1].Color == cp.c2) && (cube.sides[4].pieces[yellowCoords[1]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.MFL:
                    front = (int)cube.frontC;
                    left = Modulo.sIntMod(cube.frontC - 1);
                    if ((cube.sides[front].pieces[3].Color == cp.c1) && (cube.sides[left].pieces[5].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[3].Color == cp.c2) && (cube.sides[left].pieces[5].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.MFR:
                    front = (int)cube.frontC;
                    right = Modulo.sIntMod(cube.frontC + 1);
                    if ((cube.sides[front].pieces[5].Color == cp.c1) && (cube.sides[right].pieces[3].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[5].Color == cp.c2) && (cube.sides[right].pieces[3].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.MBL:
                    back = Modulo.sIntMod(cube.frontC + 2);
                    left = Modulo.sIntMod(cube.frontC - 1);
                    if ((cube.sides[back].pieces[5].Color == cp.c1) && (cube.sides[left].pieces[3].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[5].Color == cp.c2) && (cube.sides[left].pieces[3].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.MBR:
                    back = Modulo.sIntMod(cube.frontC + 2);
                    right = Modulo.sIntMod(cube.frontC + 1);
                    if ((cube.sides[back].pieces[3].Color == cp.c1) && (cube.sides[right].pieces[5].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[3].Color == cp.c2) && (cube.sides[right].pieces[5].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.DM:
                    front = (int)cube.frontC;
                    int[] whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[front].pieces[7].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[1]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[front].pieces[7].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[1]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.DL:
                    left = Modulo.sIntMod(cube.frontC - 1);
                    whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[left].pieces[7].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[3]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[left].pieces[7].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[3]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.DR:
                    right = Modulo.sIntMod(cube.frontC + 1);
                    whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[right].pieces[7].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[5]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[right].pieces[7].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[5]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                case EdgePosition.DB:
                    back = Modulo.sIntMod(cube.frontC + 2);
                    whiteCoords = Cube.GetWCoordinates(cube.frontC);
                    if ((cube.sides[back].pieces[7].Color == cp.c1) && (cube.sides[5].pieces[whiteCoords[7]].Color == cp.c2))
                    {
                        orientation = cp.c1;
                        return true;
                    }
                    else if ((cube.sides[back].pieces[7].Color == cp.c2) && (cube.sides[5].pieces[whiteCoords[7]].Color == cp.c1))
                    {
                        orientation = cp.c2;
                        return true;
                    }
                    else
                    {
                        orientation = Color.Red;
                        return false;
                    }
                default:
                    orientation = Color.Red;
                    return false;
            }
        }

        public static Solution YellowCross(Cube cube)
        {
            Solution s = new Solution();

            // Create a clone so we can find the solution
            Cube cCube = cube.Clone();

            while (true) // While the cross is not solved
            {
                // Scan the yellow side of the cube
                bool[] yellow = DetectYOnYSide(cCube);

                if (yellow[1] && yellow[3] && yellow[5] && yellow[7])
                {
                    // Cross is solved -> Return Solution
                    return s;
                }
                else if (yellow[1] && yellow[7]) // Horizontal line
                {
                    // Make it vertical
                    Moves.U(cCube);

                    Step step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use appropriate algorithm
                    Solution next = YCrossAlg2(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[3] && yellow[5]) // Vertical line
                {
                    // Use appropriate algorithm
                    Solution next = YCrossAlg2(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[1] && yellow[3]) // L at the up left
                {
                    // Use appropriate algorithm
                    Solution next = YCrossAlg1(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[1] && yellow[5]) // L at the up right
                {
                    // Shift it to the right position
                    Moves.Up(cCube);

                    Step step = new Step(Move.Up);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use appropriate algorithm
                    Solution next = YCrossAlg1(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[7] && yellow[3]) // L at the bottom left
                {
                    // Shift it to the right position
                    Moves.U(cCube);

                    Step step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use appropriate algorithm
                    Solution next = YCrossAlg1(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[7] && yellow[5]) // L at the bottom right
                {
                    // Shift it to the right position
                    Moves.U2(cCube);

                    Step step = new Step(Move.U2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use appropriate algorithm
                    Solution next = YCrossAlg1(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else // Yellow is only in the middle
                {
                    // Use appropriate algorithm
                    Solution next = YCrossAlg1(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
            }
        }

        private static bool[] DetectYOnYSide(Cube cube)
        {
            bool[] yellow = new bool[9];
            int[] yellowCoords = Cube.GetYCoordinates(cube.frontC);
            for (int i = 0; i < 9; i++)
            {
                if (cube.sides[4].pieces[yellowCoords[i]].Color == Color.Yellow)
                {
                    yellow[i] = true;
                }
                else
                {
                    yellow[i] = false;
                }
            }
            return yellow;
        }

        private static Solution YCrossAlg1(Cube cube)
        {
            Solution s = new Solution();

            Moves.F(cube);

            Step step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution YCrossAlg2(Cube cube)
        {
            Solution s = new Solution();

            Moves.F(cube);

            Step step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        public static Solution YellowSide(Cube cube)
        {
            Solution s = new Solution();

            // Create a clone so we can find the solution
            Cube cCube = cube.Clone();

            while (true) // While the cross is not solved
            {
                // Scan the yellow side of the cube
                bool[] yellow = DetectYOnYSide(cCube);

                // Check if the side is not all yellow
                bool solved = true;
                foreach (bool b in yellow)
                {
                    if (!b) solved = false;
                }

                if (solved)
                {
                    // Side solved -> Return Solution
                    return s;
                }

                if (!yellow[0] && !yellow[2] && !yellow[6] && !yellow[8]) // Cross
                {
                    if (cube.sides[Modulo.sIntMod(cube.frontC - 1)].pieces[2].Color == Color.Yellow) // Yellow on the left
                    {
                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                    else if (cube.sides[(int)cube.frontC].pieces[2].Color == Color.Yellow) // Yellow on the front
                    {
                        // Shift it to the right position
                        Moves.U(cCube);

                        Step step = new Step(Move.U);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                    else if (cube.sides[Modulo.sIntMod(cube.frontC + 1)].pieces[2].Color == Color.Yellow) // Yellow on the right
                    {
                        // Shift it to the right position
                        Moves.U2(cCube);

                        Step step = new Step(Move.U2);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                    else // Yellow on the back
                    {
                        // Shift it to the right position
                        Moves.Up(cCube);

                        Step step = new Step(Move.Up);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                }
                else if ((yellow[0] && yellow[2]) || (yellow[0] && yellow[6]) || (yellow[0] && yellow[8]) || (yellow[2] && yellow[6]) || (yellow[2] && yellow[8]) || (yellow[6] && yellow[8])) // Any two corners are yellow
                {
                    if (cube.sides[(int)cube.frontC].pieces[0].Color == Color.Yellow) // Yellow on the front
                    {
                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                    else if (cube.sides[Modulo.sIntMod(cube.frontC - 1)].pieces[0].Color == Color.Yellow) // Yellow on the left
                    {
                        // Shift it to the right position
                        Moves.Up(cCube);

                        Step step = new Step(Move.Up);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                    else if (cube.sides[Modulo.sIntMod(cube.frontC + 1)].pieces[0].Color == Color.Yellow) // Yellow on the right
                    {
                        // Shift it to the right position
                        Moves.U(cCube);

                        Step step = new Step(Move.U);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                    else // Yellow on the back
                    {
                        // Shift it to the right position
                        Moves.U2(cCube);

                        Step step = new Step(Move.U2);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        // Use the algorithm
                        Solution next = YSideAlg(cCube);
                        s.steps.AddRange(next.steps);
                        s.turnsCount += next.turnsCount;
                    }
                }
                else if (yellow[6]) // Arrow pointing left down
                {
                    // Use the algorithm
                    Solution next = YSideAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[0]) // Arrow pointing left up
                {
                    // Shift it to the right position
                    Moves.Up(cCube);

                    Step step = new Step(Move.Up);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use the algorithm
                    Solution next = YSideAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[8]) // Arrow pointing right down
                {
                    // Shift it to the right position
                    Moves.U(cCube);

                    Step step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use the algorithm
                    Solution next = YSideAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (yellow[2]) // Arrow pointing right up
                {
                    // Shift it to the right position
                    Moves.U2(cCube);

                    Step step = new Step(Move.U2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use the algorithm
                    Solution next = YSideAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
            }
        }

        private static Solution YSideAlg(Cube cube)
        {
            Solution s = new Solution();

            Moves.R(cube);

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        public static Solution YellowCorners(Cube cube)
        {
            Solution s = new Solution();

            // Create a clone so we can find the solution
            Cube cCube = cube.Clone();

            while (true) // While the corners are not solved
            {
                // Create variables to help
                int frontI = (int)cCube.frontC;
                int backI = Modulo.sIntMod(cCube.frontC + 2);
                int leftI = Modulo.sIntMod(cCube.frontC - 1);
                int rightI = Modulo.sIntMod(cCube.frontC + 1);

                // Check if the corners are not solved
                if ((cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[2].Color) && (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[2].Color))
                {
                    // Corners are solved -> Return Solution
                    return s;
                }

                // Solve the corners
                if (cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[2].Color)
                {
                    Solution bottom = YCornersFindBottom(cCube);
                    s.steps.AddRange(bottom.steps);
                    s.turnsCount += bottom.turnsCount;

                    Moves.RotationY2(cCube);

                    Step step = new Step(Move.RotationY2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use the algorithm
                    Solution next = YCornersAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (cCube.sides[leftI].pieces[0].Color == cCube.sides[leftI].pieces[2].Color)
                {
                    Moves.RotationYp(cCube);

                    Step step = new Step(Move.RotationYp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Solution bottom = YCornersFindBottom(cCube);
                    s.steps.AddRange(bottom.steps);
                    s.turnsCount += bottom.turnsCount;

                    Moves.RotationY2(cCube);

                    step = new Step(Move.RotationY2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use the algorithm
                    Solution next = YCornersAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (cCube.sides[rightI].pieces[0].Color == cCube.sides[rightI].pieces[2].Color)
                {
                    Moves.RotationY(cCube);

                    Step step = new Step(Move.RotationY);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Solution bottom = YCornersFindBottom(cCube);
                    s.steps.AddRange(bottom.steps);
                    s.turnsCount += bottom.turnsCount;

                    Moves.RotationY2(cCube);

                    step = new Step(Move.RotationY2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use the algorithm
                    Solution next = YCornersAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[2].Color)
                {
                    Moves.RotationY2(cCube);

                    Step step = new Step(Move.RotationY2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    Solution bottom = YCornersFindBottom(cCube);
                    s.steps.AddRange(bottom.steps);
                    s.turnsCount += bottom.turnsCount;

                    Moves.RotationY2(cCube);

                    step = new Step(Move.RotationY2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    // Use the algorithm
                    Solution next = YCornersAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (cCube.sides[frontI].pieces[0].Color == Modulo.sColorMod(cCube.sides[backI].pieces[0].Color + 2))
                {
                    Solution bottom = YCornersFindBottom(cCube);
                    s.steps.AddRange(bottom.steps);
                    s.turnsCount += bottom.turnsCount;

                    // Use the algorithm
                    Solution next = YCornersAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
                else if (cCube.sides[frontI].pieces[2].Color == Modulo.sColorMod(cCube.sides[backI].pieces[2].Color + 2))
                {
                    Solution bottom = YCornersFindBottom(cCube);
                    s.steps.AddRange(bottom.steps);
                    s.turnsCount += bottom.turnsCount;

                    // Use the algorithm
                    Solution next = YCornersAlg(cCube);
                    s.steps.AddRange(next.steps);
                    s.turnsCount += next.turnsCount;
                }
            }
        }

        private static Solution YCornersFindBottom(Cube cube)
        {
            Solution s = new Solution();

            int front = (int)cube.frontC;
            if (cube.sides[front].pieces[0].Color == cube.frontC)
            {
                // There is a correct bottom -> Do nothing
                return s;

            }
            else if (cube.sides[front].pieces[0].Color == Modulo.sColorMod(cube.frontC - 1))
            {
                Moves.Dw(cube);

                Step step = new Step(Move.Dw);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }
            else if (cube.sides[front].pieces[0].Color == Modulo.sColorMod(cube.frontC + 1))
            {
                Moves.Dwp(cube);

                Step step = new Step(Move.Dwp);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }
            else
            {
                Moves.Dw2(cube);

                Step step = new Step(Move.Dw2);
                // TODO
                // Add text to step
                s.AddStep(step);

                return s;
            }
        }

        private static Solution YCornersAlg(Cube cube)
        {
            Solution s = new Solution();

            Moves.Rp(cube);

            Step step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.F(cube);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.B2(cube);

            step = new Step(Move.B2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.B2(cube);

            step = new Step(Move.B2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R2(cube);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        public static Solution YellowEdges(Cube cube)
        {
            Solution s = new Solution();

            // Create a clone so we can find the solution
            Cube cCube = cube.Clone();

            while (true) // While the edges are not solved
            {
                // Create variables to help
                int frontI = (int)cCube.frontC;
                int backI = Modulo.sIntMod(cCube.frontC + 2);
                int leftI = Modulo.sIntMod(cCube.frontC - 1);
                int rightI = Modulo.sIntMod(cCube.frontC + 1);

                // Check if edges are not solved
                if ((cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[1].Color) && (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[1].Color))
                {
                    // Check if we have correct bottom
                    if (cCube.sides[frontI].pieces[0].Color != cCube.frontC)
                    {
                        // Nope -> Find it
                        // Find correct bottom
                        // Maybe we will need to create separate bottom finder for this but just for now we will use the YCorners one
                        Solution b = YCornersFindBottom(cCube);
                        s.steps.AddRange(b.steps);
                        s.turnsCount += b.turnsCount;
                    }

                    // Edges are solved -> Return Solution
                    return s;
                }

                // Solve the edges
                bool solvedEdge = false;
                if (cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[1].Color) // Edge on front is solved
                {
                    solvedEdge = true;
                }
                else if (cCube.sides[leftI].pieces[0].Color == cCube.sides[leftI].pieces[1].Color) // Edge on the left is solved
                {
                    solvedEdge = true;

                    // Move it to the fornt
                    Moves.RotationYp(cCube);

                    Step step = new Step(Move.RotationYp);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else if (cCube.sides[rightI].pieces[0].Color == cCube.sides[rightI].pieces[1].Color) // Edge on the right is solved
                {
                    solvedEdge = true;

                    // Move it to the fornt
                    Moves.RotationY(cCube);

                    Step step = new Step(Move.RotationY);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }
                else if (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[1].Color) // Edge at the back is solved
                {
                    solvedEdge = true;

                    // Move it to the fornt
                    Moves.RotationY2(cCube);

                    Step step = new Step(Move.RotationY2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                // If we have solved edge find the correct bottom and move it to the back
                if (solvedEdge)
                {
                    // Find correct bottom
                    // Maybe we will need to create separate bottom finder for this but just for now we will use the YCorners one
                    Solution bottom = YCornersFindBottom(cCube);
                    s.steps.AddRange(bottom.steps);
                    s.turnsCount += bottom.turnsCount;

                    // Move it to the back
                    Moves.RotationY2(cCube);

                    Step step = new Step(Move.RotationY2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                // Check if we need clockwise or counter-clockwise rotation and execute it
                Solution edges;
                if (cCube.sides[(int)cCube.frontC].pieces[1].Color == Modulo.sColorMod(cCube.frontC - 1))
                {
                    edges = YEdgesAlg(cCube, true);
                }
                else
                {
                    edges = YEdgesAlg(cCube, false);
                }
                s.steps.AddRange(edges.steps);
                s.turnsCount += edges.turnsCount;
            }
        }

        private static Solution YEdgesAlg(Cube cube, bool clockwise)
        {
            Solution s = new Solution();

            Moves.F2(cube);

            Step step = new Step(Move.F2);
            // TODO
            // Add text to step
            s.AddStep(step);

            if (clockwise)
            {
                Moves.U(cube);

                step = new Step(Move.U);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else
            {
                Moves.Up(cube);

                step = new Step(Move.Up);
                // TODO
                // Add text to step
                s.AddStep(step);
            }

            Moves.L(cube);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.F2(cube);

            step = new Step(Move.F2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Lp(cube);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            if (clockwise)
            {
                Moves.U(cube);

                step = new Step(Move.U);
                // TODO
                // Add text to step
                s.AddStep(step);
            }
            else
            {
                Moves.Up(cube);

                step = new Step(Move.Up);
                // TODO
                // Add text to step
                s.AddStep(step);
            }

            Moves.F2(cube);

            step = new Step(Move.F2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        public static Solution TLOLL(Cube cube)
        {
            Solution s = new Solution();

            // Create a clone so we can find the solution
            Cube cCube = cube.Clone();

            while (true) // While the yellow side is not solved
            {
                // Scan the yellow side of the cube
                bool[] yellow = DetectYOnYSide(cCube);

                // Check if the side is not all yellow
                int numberOfSolved = 0;
                foreach (bool b in yellow)
                {
                    if (b) numberOfSolved++;
                }

                if (numberOfSolved == 9)
                {
                    // Side solved -> Return Solution
                    return s;
                }

                if (!yellow[1] || !yellow[3] || !yellow[5] || !yellow[7]) // We don't have solved edges (cross) yet
                {
                    if (yellow[3] && yellow[5]) // Horizontal line
                    {
                        Solution line = TLOLLLine(cCube);
                        s.steps.AddRange(line.steps);
                        s.turnsCount += line.turnsCount;
                    }
                    else if (yellow[1] && yellow[7]) // Vertical line
                    {
                        Moves.U(cCube);

                        Step step = new Step(Move.U);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        Solution line = TLOLLLine(cCube);
                        s.steps.AddRange(line.steps);
                        s.turnsCount += line.turnsCount;
                    }
                    else if (yellow[1] && yellow[3]) // Small L up left
                    {
                        Moves.U2(cCube);

                        Step step = new Step(Move.U2);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        Solution smallL = TLOLLSmallL(cCube);
                        s.steps.AddRange(smallL.steps);
                        s.turnsCount += smallL.turnsCount;

                    }
                    else if (yellow[1] && yellow[5]) // Small L up right
                    {
                        Moves.U(cCube);

                        Step step = new Step(Move.U);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        Solution smallL = TLOLLSmallL(cCube);
                        s.steps.AddRange(smallL.steps);
                        s.turnsCount += smallL.turnsCount;
                    }
                    else if (yellow[3] && yellow[7]) // Small L down left
                    {
                        Moves.Up(cCube);

                        Step step = new Step(Move.Up);
                        // TODO
                        // Add text to step
                        s.AddStep(step);

                        Solution smallL = TLOLLSmallL(cCube);
                        s.steps.AddRange(smallL.steps);
                        s.turnsCount += smallL.turnsCount;
                    }
                    else if (yellow[5] && yellow[7]) // Small L down right
                    {
                        Solution smallL = TLOLLSmallL(cCube);
                        s.steps.AddRange(smallL.steps);
                        s.turnsCount += smallL.turnsCount;
                    }
                    else // Dot
                    {
                        Solution dot = TLOLLDot(cCube);
                        s.steps.AddRange(dot.steps);
                        s.turnsCount += dot.turnsCount;
                    }
                }
                else if (numberOfSolved == 5) // Cross (H or Pi)
                {
                    int frontI = (int)cCube.frontC;
                    int leftI = Modulo.sIntMod(cCube.frontC - 1);
                    int backI = Modulo.sIntMod(cCube.frontC + 2);
                    int rightI = Modulo.sIntMod(cCube.frontC + 1);

                    if (cCube.sides[frontI].pieces[0].Color == Color.Yellow)
                    {
                        if (cCube.sides[backI].pieces[0].Color == Color.Yellow) // Rotated H
                        {
                            Moves.U(cCube);

                            Step step = new Step(Move.U);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution h = TLOLLH(cCube);
                            s.steps.AddRange(h.steps);
                            s.turnsCount += h.turnsCount;
                        }
                        else if (cCube.sides[backI].pieces[2].Color == Color.Yellow) // Left Pi
                        {
                            Moves.U2(cCube);

                            Step step = new Step(Move.U2);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution pi = TLOLLPi(cCube);
                            s.steps.AddRange(pi.steps);
                            s.turnsCount += pi.turnsCount;
                        }
                        else // Up Pi
                        {
                            Moves.U(cCube);

                            Step step = new Step(Move.U);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution pi = TLOLLPi(cCube);
                            s.steps.AddRange(pi.steps);
                            s.turnsCount += pi.turnsCount;
                        }
                    }
                    else if (cCube.sides[leftI].pieces[2].Color == Color.Yellow)
                    {
                        if (cCube.sides[rightI].pieces[2].Color == Color.Yellow) // H
                        {
                            Solution h = TLOLLH(cCube);
                            s.steps.AddRange(h.steps);
                            s.turnsCount += h.turnsCount;
                        }
                        else if (cCube.sides[rightI].pieces[0].Color == Color.Yellow) // Bottom Pi
                        {
                            Moves.Up(cCube);

                            Step step = new Step(Move.Up);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution pi = TLOLLPi(cCube);
                            s.steps.AddRange(pi.steps);
                            s.turnsCount += pi.turnsCount;
                        }
                        else // (Right) Pi
                        {
                            Solution pi = TLOLLPi(cCube);
                            s.steps.AddRange(pi.steps);
                            s.turnsCount += pi.turnsCount;
                        }
                    }
                }
                else if (numberOfSolved == 6) // Sune or Antisune
                {
                    int frontI = (int)cCube.frontC;
                    int leftI = Modulo.sIntMod(cCube.frontC - 1);
                    int backI = Modulo.sIntMod(cCube.frontC + 2);
                    int rightI = Modulo.sIntMod(cCube.frontC + 1);

                    if (yellow[0]) // Pointing up left
                    {
                        if (cCube.sides[leftI].pieces[2].Color == Color.Yellow) // Rotated Sune
                        {
                            Moves.Up(cCube);

                            Step step = new Step(Move.Up);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution sune = TLOLLSune(cCube);
                            s.steps.AddRange(sune.steps);
                            s.turnsCount += sune.turnsCount;
                        }
                        else // Rotated Antisune
                        {
                            Moves.U(cCube);

                            Step step = new Step(Move.U);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution antisune = TLOLLAntisune(cCube);
                            s.steps.AddRange(antisune.steps);
                            s.turnsCount += antisune.turnsCount;

                        }
                    }
                    else if (yellow[2]) // Pointing up right
                    {
                        if (cCube.sides[backI].pieces[2].Color == Color.Yellow) // Rotated Sune
                        {
                            Moves.U2(cCube);

                            Step step = new Step(Move.U2);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution sune = TLOLLSune(cCube);
                            s.steps.AddRange(sune.steps);
                            s.turnsCount += sune.turnsCount;
                        }
                        else // Antisune
                        {
                            Solution antisune = TLOLLAntisune(cCube);
                            s.steps.AddRange(antisune.steps);
                            s.turnsCount += antisune.turnsCount;
                        }

                    }
                    else if (yellow[6]) // Pointing down left
                    {
                        if (cCube.sides[frontI].pieces[2].Color == Color.Yellow) // Sune
                        {
                            Solution sune = TLOLLSune(cCube);
                            s.steps.AddRange(sune.steps);
                            s.turnsCount += sune.turnsCount;
                        }
                        else // Rotated Antisune
                        {
                            Moves.U2(cCube);

                            Step step = new Step(Move.U2);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution antisune = TLOLLAntisune(cCube);
                            s.steps.AddRange(antisune.steps);
                            s.turnsCount += antisune.turnsCount;
                        }
                    }
                    else // Pointing down right
                    {
                        if (cCube.sides[rightI].pieces[2].Color == Color.Yellow) // Rotated Sune
                        {
                            Moves.U(cCube);

                            Step step = new Step(Move.U);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution sune = TLOLLSune(cCube);
                            s.steps.AddRange(sune.steps);
                            s.turnsCount += sune.turnsCount;
                        }
                        else // Rotated Antisune
                        {
                            Moves.Up(cCube);

                            Step step = new Step(Move.Up);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution antisune = TLOLLAntisune(cCube);
                            s.steps.AddRange(antisune.steps);
                            s.turnsCount += antisune.turnsCount;
                        }
                    }
                }
                else // Else (L, T, U)
                {
                    int frontI = (int)cCube.frontC;
                    int leftI = Modulo.sIntMod(cCube.frontC - 1);
                    int backI = Modulo.sIntMod(cCube.frontC + 2);
                    int rightI = Modulo.sIntMod(cCube.frontC + 1);

                    if (yellow[0] && yellow[8]) // L
                    {
                        if (cCube.sides[frontI].pieces[0].Color != Color.Yellow) // Yellow is not at the front
                        {
                            Moves.U2(cCube);

                            Step step = new Step(Move.U2);
                            // TODO
                            // Add text to step
                            s.AddStep(step);
                        }

                        Solution l = TLOLLL(cCube);
                        s.steps.AddRange(l.steps);
                        s.turnsCount += l.turnsCount;
                    }
                    else if (yellow[2] && yellow[6]) // Rotated L
                    {
                        if (cCube.sides[rightI].pieces[0].Color == Color.Yellow) // Yellow is on the left
                        {
                            Moves.U(cCube);

                            Step step = new Step(Move.U);
                            // TODO
                            // Add text to step
                            s.AddStep(step);
                        }
                        else // Yellow is on the right
                        {
                            Moves.Up(cCube);

                            Step step = new Step(Move.Up);
                            // TODO
                            // Add text to step
                            s.AddStep(step);
                        }

                        Solution l = TLOLLL(cCube);
                        s.steps.AddRange(l.steps);
                        s.turnsCount += l.turnsCount;
                    }
                    else if (yellow[0] && yellow[2]) // Complete up row
                    {
                        if (cCube.sides[frontI].pieces[0].Color == Color.Yellow) // U
                        {
                            Solution u = TLOLLU(cCube);
                            s.steps.AddRange(u.steps);
                            s.turnsCount += u.turnsCount;
                        }
                        else // Rotated T
                        {
                            Moves.U(cCube);

                            Step step = new Step(Move.U);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution t = TLOLLT(cCube);
                            s.steps.AddRange(t.steps);
                            s.turnsCount += t.turnsCount;
                        }
                    }
                    else if (yellow[0] && yellow[6]) // Complete left row
                    {
                        if (cCube.sides[rightI].pieces[0].Color == Color.Yellow) // Rotated U
                        {
                            Moves.U(cCube);

                            Step step = new Step(Move.U);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution u = TLOLLU(cCube);
                            s.steps.AddRange(u.steps);
                            s.turnsCount += u.turnsCount;
                        }
                        else // Rotated T
                        {
                            Moves.U2(cCube);

                            Step step = new Step(Move.U2);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution t = TLOLLT(cCube);
                            s.steps.AddRange(t.steps);
                            s.turnsCount += t.turnsCount;
                        }
                    }
                    else if (yellow[6] && yellow[8]) // Complete bottom row
                    {
                        if (cCube.sides[backI].pieces[0].Color == Color.Yellow) // Rotated U
                        {
                            Moves.U2(cCube);

                            Step step = new Step(Move.U2);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution u = TLOLLU(cCube);
                            s.steps.AddRange(u.steps);
                            s.turnsCount += u.turnsCount;
                        }
                        else // Rotated T
                        {
                            Moves.Up(cCube);

                            Step step = new Step(Move.Up);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution t = TLOLLT(cCube);
                            s.steps.AddRange(t.steps);
                            s.turnsCount += t.turnsCount;
                        }

                    }
                    else // Complete right row
                    {
                        if (cCube.sides[leftI].pieces[0].Color == Color.Yellow) // Rotated U
                        {
                            Moves.Up(cCube);

                            Step step = new Step(Move.Up);
                            // TODO
                            // Add text to step
                            s.AddStep(step);

                            Solution u = TLOLLU(cCube);
                            s.steps.AddRange(u.steps);
                            s.turnsCount += u.turnsCount;
                        }
                        else // T
                        {
                            Solution t = TLOLLT(cCube);
                            s.steps.AddRange(t.steps);
                            s.turnsCount += t.turnsCount;
                        }
                    }
                }
            }
        }

        private static Solution TLOLLDot(Cube cube)
        {
            Solution s = new Solution();

            Moves.F(cube);

            Step step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fw(cube);

            step = new Step(Move.Fw);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fwp(cube);

            step = new Step(Move.Fwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLLine(Cube cube)
        {
            Solution s = new Solution();

            Moves.F(cube);

            Step step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLSmallL(Cube cube)
        {
            Solution s = new Solution();

            Moves.Fw(cube);

            Step step = new Step(Move.Fw);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fwp(cube);

            step = new Step(Move.Fwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLAntisune(Cube cube)
        {
            Solution s = new Solution();

            Moves.R(cube);

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLH(Cube cube)
        {
            Solution s = new Solution();

            Moves.R(cube);

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLL(Cube cube)
        {
            Solution s = new Solution();

            Moves.F(cube);

            Step step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rw(cube);

            step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rwp(cube);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLPi(Cube cube)
        {
            Solution s = new Solution();

            Moves.R(cube);

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R2(cube);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R2(cube);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R2(cube);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLSune(Cube cube)
        {
            Solution s = new Solution();

            Moves.R(cube);

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLT(Cube cube)
        {
            Solution s = new Solution();

            Moves.Rw(cube);

            Step step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rwp(cube);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.F(cube);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLOLLU(Cube cube)
        {
            Solution s = new Solution();

            Moves.R2(cube);

            Step step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.D(cube);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Dp(cube);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        public static Solution TLPLL(Cube cube)
        {
            Solution s = new Solution();

            // Create a clone so we can find the solution
            Cube cCube = cube.Clone();

            // Create variables to help
            int frontI = (int)cCube.frontC;
            int backI = Modulo.sIntMod(cCube.frontC + 2);
            int leftI = Modulo.sIntMod(cCube.frontC - 1);
            int rightI = Modulo.sIntMod(cCube.frontC + 1);

            // Check if cube is not solved
            if ((cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[1].Color)
                && (cCube.sides[frontI].pieces[1].Color == cCube.sides[frontI].pieces[2].Color)
                && (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[1].Color)
                && (cCube.sides[backI].pieces[1].Color == cCube.sides[backI].pieces[2].Color))
            {
                // Check if we have correct bottom
                if (cCube.sides[frontI].pieces[0].Color != cCube.frontC)
                {
                    // Nope -> Find it
                    // Find correct bottom
                    // Maybe we will need to create separate bottom finder for this but just for now we will use the YCorners one
                    Solution b = YCornersFindBottom(cCube);
                    s.steps.AddRange(b.steps);
                    s.turnsCount += b.turnsCount;
                }

                // Cube is solved -> Return Solution
                return s;
            }

            // Find solution
            if (!((cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[2].Color) && (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[2].Color))) // Corners are not solved -> fix them
            {
                bool headlights = false;
                if (cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[2].Color) // Headlights facing front
                {
                    Moves.U(cCube);

                    Step step = new Step(Move.U);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    headlights = true;
                }
                else if (cCube.sides[leftI].pieces[0].Color == cCube.sides[leftI].pieces[2].Color) // Headlights facing left
                {
                    headlights = true;
                }
                else if (cCube.sides[rightI].pieces[0].Color == cCube.sides[rightI].pieces[2].Color) // Headlights facing right
                {
                    Moves.U2(cCube);

                    Step step = new Step(Move.U2);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    headlights = true;
                }
                else if (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[2].Color) // Headlights facing back
                {
                    Moves.Up(cCube);

                    Step step = new Step(Move.Up);
                    // TODO
                    // Add text to step
                    s.AddStep(step);

                    headlights = true;
                }

                if (headlights)
                {
                    Solution hlights = TLPLLHeadlights(cCube);
                    s.steps.AddRange(hlights.steps);
                    s.turnsCount += hlights.turnsCount;
                }
                else // No headlights -> Diagonal
                {
                    Solution diagonal = TLPLLDiagonal(cCube);
                    s.steps.AddRange(diagonal.steps);
                    s.turnsCount += diagonal.turnsCount;
                }
            }

            // Find correct bottom
            // Maybe we will need to create separate bottom finder for this but just for now we will use the YCorners one
            Solution bottom = YCornersFindBottom(cCube);
            s.steps.AddRange(bottom.steps);
            s.turnsCount += bottom.turnsCount;

            // Update variables to help
            frontI = (int)cCube.frontC;
            backI = Modulo.sIntMod(cCube.frontC + 2);
            leftI = Modulo.sIntMod(cCube.frontC - 1);
            rightI = Modulo.sIntMod(cCube.frontC + 1);

            // Check if cube is not solved
            if ((cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[1].Color)
                && (cCube.sides[frontI].pieces[1].Color == cCube.sides[frontI].pieces[2].Color)
                && (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[1].Color)
                && (cCube.sides[backI].pieces[1].Color == cCube.sides[backI].pieces[2].Color))
            {
                // Cube is solved -> Return Solution
                return s;
            }

            bool completeEdge = false;
            if (cCube.sides[frontI].pieces[0].Color == cCube.sides[frontI].pieces[1].Color) // Complete edge on the front
            {
                Moves.RotationY2(cCube);

                Step step = new Step(Move.RotationY2);
                // TODO
                // Add text to step
                s.AddStep(step);

                completeEdge = true;
            }
            else if (cCube.sides[leftI].pieces[0].Color == cCube.sides[leftI].pieces[1].Color) // Complete edge on the left
            {
                Moves.RotationY(cCube);

                Step step = new Step(Move.RotationY);
                // TODO
                // Add text to step
                s.AddStep(step);

                completeEdge = true;
            }
            else if (cCube.sides[rightI].pieces[0].Color == cCube.sides[rightI].pieces[1].Color) // Complete edge on the right
            {
                Moves.RotationYp(cCube);

                Step step = new Step(Move.RotationYp);
                // TODO
                // Add text to step
                s.AddStep(step);

                completeEdge = true;
            }
            else if (cCube.sides[backI].pieces[0].Color == cCube.sides[backI].pieces[1].Color) // Complete edge on the back
            {
                completeEdge = true;
            }
            else if (cCube.sides[frontI].pieces[1].Color == Modulo.sColorMod(cCube.frontC + 2)) // No comlepte edge but H case
            {
                Solution h = TLPLLH(cCube);
                s.steps.AddRange(h.steps);
                s.turnsCount += h.turnsCount;
            }
            else // No complete edge but Z case
            {
                if (cCube.sides[(int)cCube.frontC].pieces[1].Color == Modulo.sColorMod(cCube.frontC + 1)) // Z case is orientated wrong
                {
                    Moves.RotationY(cCube);

                    Step step = new Step(Move.RotationY);
                    // TODO
                    // Add text to step
                    s.AddStep(step);
                }

                Solution z = TLPLLZ(cCube);
                s.steps.AddRange(z.steps);
                s.turnsCount += z.turnsCount;
            }

            if (completeEdge)
            {
                // Check if we need clockwise or counter-clockwise rotation and execute it
                Solution u;
                if (cCube.sides[(int)cCube.frontC].pieces[1].Color == Modulo.sColorMod(cCube.frontC - 1))
                {
                    u = TLPLLUb(cCube);
                }
                else
                {
                    u = TLPLLUa(cCube);
                }
                s.steps.AddRange(u.steps);
                s.turnsCount += u.turnsCount;
            }

            return s;
        }

        private static Solution TLPLLDiagonal(Cube cube)
        {
            Solution s = new Solution();

            Moves.F(cube);

            Step step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.F(cube);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLPLLHeadlights(Cube cube)
        {
            Solution s = new Solution();

            Moves.R(cube);

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.F(cube);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R2(cube);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Fp(cube);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLPLLH(Cube cube)
        {
            Solution s = new Solution();

            Moves.M2(cube);

            Step step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.M2(cube);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.M2(cube);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.M2(cube);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLPLLUa(Cube cube)
        {
            Solution s = new Solution();

            Moves.R(cube);

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R2(cube);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLPLLUb(Cube cube)
        {
            Solution s = new Solution();

            Moves.R2(cube);

            Step step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.R(cube);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Up(cube);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Rp(cube);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution TLPLLZ(Cube cube)
        {
            Solution s = new Solution();

            Moves.Mp(cube);

            Step step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.M2(cube);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.M2(cube);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U(cube);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.Mp(cube);

            step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.U2(cube);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            Moves.M2(cube);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }
    }
}
