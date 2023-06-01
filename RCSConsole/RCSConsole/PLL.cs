using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class PLL
    {
        public static Solution Solve(Cube cube)
        {
            // We don't need to clone the cube since there is only single step in this solution
            // We will not need to apply solution to the cube in order to determine what to do next
        }

        private static Solution Aa()
        {
            Solution s = new Solution();

            Step step = new Step(Move.RotationX);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Ab()
        {
            Solution s = new Solution();

            Step step = new Step(Move.RotationXp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution F()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Ga()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Gb()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Gc()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Gd()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Ja()
        {
            Solution s = new Solution();

            Step step = new Step(Move.RotationX);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Jb()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Ra()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Rb()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution T()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution E()
        {
            Solution s = new Solution();

            Step step = new Step(Move.RotationXp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Dp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.D);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Na()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Nb()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution V()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.RotationY);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Y()
        {
            Solution s = new Solution();

            Step step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution H()
        {
            Solution s = new Solution();

            Step step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Ua()
        {
            Solution s = new Solution();

            Step step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Ub()
        {
            Solution s = new Solution();

            Step step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Z()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.M2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }
    }
}
