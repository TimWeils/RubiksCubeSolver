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
                return WCrossFindSolution(cube, colorsToComplete[0], colorsToComplete);
            }
        }

        private static Solution WCrossFindSolution(Cube cube, Color c, List<Color> remainingColors)
        {
            Solution s = new Solution();
            if (cube.frontC != c)
            {
                Solution rotation = RotateCube(cube, c);
                s.steps.AddRange(rotation.steps);
                s.turnsCount += rotation.turnsCount;
            }

            // Check all possible positions of the piece we need to move and move it

            // Front side - color
            if ((cube.sides[(int)c].pieces[7].Color == c) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[1]].Color == Color.White))
            {
                // TODO
                // Add text
                return s;
            }

            if ((cube.sides[(int)c].pieces[3].Color == c) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[5].Color == Color.White))
            {
                Moves.oF(cube);

                Step step = new Step();
                step.move = "F'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[(int)c].pieces[5].Color == c) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[3].Color == Color.White))
            {
                Moves.F(cube);

                Step step = new Step();
                step.move = "F";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[(int)c].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[7]].Color == Color.White))
            {
                Moves.F2(cube);

                Step step = new Step();
                step.move = "F2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                return s;
            }

            // Front side - white
            if ((cube.sides[(int)c].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[1]].Color == c))
            {
                Moves.F(cube);

                Step step = new Step();
                step.move = "F";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                if (remainingColors.Count != 3)
                {
                    Moves.oD(cube);

                    step = new Step();
                    step.move = "D'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
                }

                Moves.L(cube);

                step = new Step();
                step.move = "L";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.D(cube);

                step = new Step();
                step.move = "D";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[(int)c].pieces[3].Color == Color.White) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[5].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.oD(cube);

                    step = new Step();
                    step.move = "D'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
                }

                Moves.L(cube);

                step = new Step();
                step.move = "L";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.D(cube);

                step = new Step();
                step.move = "D";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[(int)c].pieces[5].Color == Color.White) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[3].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.D(cube);

                    step = new Step();
                    step.move = "D";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
                }

                Moves.oR(cube);

                step = new Step();
                step.move = "R'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.oD(cube);

                step = new Step();
                step.move = "D'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[(int)c].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[7]].Color == c))
            {
                Moves.oF(cube);

                Step step = new Step();
                step.move = "F'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                if (remainingColors.Count != 3)
                {
                    Moves.oD(cube);

                    step = new Step();
                    step.move = "D'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
                }

                Moves.L(cube);

                step = new Step();
                step.move = "L";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.D(cube);

                step = new Step();
                step.move = "D";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            // Left side - color
            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[7].Color == c) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[3]].Color == Color.White))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.oL(cube);

                    step = new Step();
                    step.move = "L'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.oD(cube);

                    step = new Step();
                    step.move = "D'";
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
                }

                Moves.D(cube);

                step = new Step();
                step.move = "D";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[3]].Color == Color.White))
            {
                Moves.oU(cube);

                Step step = new Step();
                step.move = "U'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.F2(cube);

                step = new Step();
                step.move = "F2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                return s;
            }

            // Left side - white
            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[3]].Color == c))
            {
                Moves.oL(cube);

                Step step = new Step();
                step.move = "L'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.oF(cube);

                step = new Step();
                step.move = "F'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c - 1)].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[3]].Color == c))
            {
                Moves.L(cube);

                Step step = new Step();
                step.move = "L";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.oF(cube);

                step = new Step();
                step.move = "F'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                if (!remainingColors.Contains(Modulo.sColorMod(c - 1)))
                {
                    Moves.oL(cube);

                    step = new Step();
                    step.move = "L'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
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

                    step = new Step();
                    step.move = "R";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.D(cube);

                    step = new Step();
                    step.move = "D";
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
                }

                Moves.oD(cube);

                step = new Step();
                step.move = "D'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 1)].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[5]].Color == Color.White))
            {
                Moves.U(cube);

                Step step = new Step();
                step.move = "U";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.F2(cube);

                step = new Step();
                step.move = "F2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                return s;
            }

            // Right side - white
            if ((cube.sides[Modulo.sIntMod(c + 1)].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[5]].Color == c))
            {
                Moves.R(cube);

                Step step = new Step();
                step.move = "R";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.F(cube);

                step = new Step();
                step.move = "F";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 1)].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[5]].Color == c))
            {
                Moves.oR(cube);

                Step step = new Step();
                step.move = "R'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.F(cube);

                step = new Step();
                step.move = "F";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.R(cube);

                    step = new Step();
                    step.move = "R";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
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

                    step = new Step();
                    step.move = "D2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;

                    return s;
                }

                if (remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.B(cube);

                    step = new Step();
                    step.move = "B";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.R2(cube);

                    step = new Step();
                    step.move = "R2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;

                    Moves.F(cube);

                    step = new Step();
                    step.move = "F";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    return s;
                }

                if (remainingColors.Contains(Modulo.sColorMod(c - 1)))
                {
                    Moves.oB(cube);

                    step = new Step();
                    step.move = "B'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    Moves.L2(cube);

                    step = new Step();
                    step.move = "L2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;

                    Moves.oF(cube);

                    step = new Step();
                    step.move = "F'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    return s;
                }

                Moves.B2(cube);

                step = new Step();
                step.move = "B2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount +=2;

                Moves.U2(cube);

                step = new Step();
                step.move = "U2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                Moves.F2(cube);

                step = new Step();
                step.move = "F2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[3].Color == c) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[5].Color == Color.White))
            {
                Moves.R2(cube);

                Step step = new Step();
                step.move = "R2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                Moves.F(cube);

                step = new Step();
                step.move = "F";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.R2(cube);

                    step = new Step();
                    step.move = "R2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;
                }

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[5].Color == c) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[3].Color == Color.White))
            {
                Moves.L2(cube);

                Step step = new Step();
                step.move = "L2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                Moves.oF(cube);

                step = new Step();
                step.move = "F'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.L2(cube);

                    step = new Step();
                    step.move = "L2";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount += 2;
                }

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[1].Color == c) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[1]].Color == Color.White))
            {
                Moves.U2(cube);

                Step step = new Step();
                step.move = "U2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                Moves.F2(cube);

                step = new Step();
                step.move = "F2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;

                return s;
            }

            // Back side - white
            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[7].Color == Color.White) && (cube.sides[5].pieces[Cube.GetWCoordinates(c)[7]].Color == c))
            {
                Moves.B(cube);

                Step step = new Step();
                step.move = "B";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.D(cube);

                step = new Step();
                step.move = "D";
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

                Moves.oD(cube);

                step = new Step();
                step.move = "D'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[3].Color == Color.White) && (cube.sides[Modulo.sIntMod(c + 1)].pieces[5].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.D(cube);

                    step = new Step();
                    step.move = "D";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
                }

                Moves.R(cube);

                step = new Step();
                step.move = "R";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                Moves.oD(cube);

                step = new Step();
                step.move = "D'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[5].Color == Color.White) && (cube.sides[Modulo.sIntMod(c - 1)].pieces[3].Color == c))
            {
                Step step;
                if (remainingColors.Count != 3)
                {
                    Moves.oD(cube);

                    step = new Step();
                    step.move = "D'";
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

                Moves.D(cube);

                step = new Step();
                step.move = "D";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                return s;
            }

            if ((cube.sides[Modulo.sIntMod(c + 2)].pieces[1].Color == Color.White) && (cube.sides[4].pieces[Cube.GetYCoordinates(c)[1]].Color == c))
            {
                Step step;
                if (remainingColors.Contains(Modulo.sColorMod(c - 1)))
                {
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

                    Moves.oF(cube);

                    step = new Step();
                    step.move = "F'";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;

                    return s;
                }

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

                Moves.F(cube);

                step = new Step();
                step.move = "F";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

                if (!remainingColors.Contains(Modulo.sColorMod(c + 1)))
                {
                    Moves.R(cube);

                    step = new Step();
                    step.move = "R";
                    // TODO
                    // Add text to step
                    s.steps.Add(step);
                    s.turnsCount++;
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

                Step step = new Step();
                step.move = "y";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;

            }
            else if (c == Modulo.sColorMod(cube.frontC + 2))
            {
                Moves.RotationY2(cube);

                Step step = new Step();
                step.move = "y2";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount += 2;
            }
            else if (c == Modulo.sColorMod(cube.frontC - 1))
            {
                Moves.oRotationY(cube);

                Step step = new Step();
                step.move = "y'";
                // TODO
                // Add text to step
                s.steps.Add(step);
                s.turnsCount++;
            }
            return s;
        }

        public static Solution WhiteCorners(Cube cube)
        {
            // Check if White Corners are not already solved
            List<ColorPair> cornersToComplete = new List<ColorPair>();
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

        private static Solution WCornersFindSolution(Cube cube, ColorPair cp)
        {
            Solution s = new Solution();
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

                    Moves.L2(cube);

                    step = new Step();
                    step.move = "L2";
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

                    Moves.R2(cube);

                    step = new Step();
                    step.move = "R2";
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
    }
}
