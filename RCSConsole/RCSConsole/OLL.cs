using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class OLL
    {
        public static Solution Solve(Cube cube)
        {
            // We don't need to clone the cube since there is only single step in this solution
            // We will not need to apply solution to the cube in order to determine what to do next
        }

        private static Solution Alg01()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
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

            step = new Step(Move.U2);
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

        private static Solution Alg02()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
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

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg03()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rwp);
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

            step = new Step(Move.Rw);
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

            step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg04()
        {
            Solution s = new Solution();

            Step step = new Step(Move.M);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
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

            step = new Step(Move.Rwp);
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

            step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg05()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Lwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
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

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lw);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg06()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg07()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg08()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Lwp);
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

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lw);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg09()
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

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg10()
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

            return s;
        }

        private static Solution Alg11()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            return s;
        }

        private static Solution Alg12()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Mp);
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

            step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg13()
        {
            Solution s = new Solution();

            Step step = new Step(Move.F);
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

            step = new Step(Move.R2);
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

        private static Solution Alg14()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rp);
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

            step = new Step(Move.Fp);
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

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg15()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Lwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lw);
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

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lw);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg16()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rwp);
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

            step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg17()
        {
            Solution s = new Solution();

            Step step = new Step(Move.F);
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

            step = new Step(Move.Rwp);
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

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg18()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw2);
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

            step = new Step(Move.U2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg19()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rwp);
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

            step = new Step(Move.Mp);
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

        private static Solution Alg20()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            step = new Step(Move.M2);
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

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Mp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg21()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
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

            return s;
        }

        private static Solution Alg22()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
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

            step = new Step(Move.R2);
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

        private static Solution Alg23()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R2);
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

            step = new Step(Move.U2);
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

            step = new Step(Move.R);
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

        private static Solution Alg24()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            step = new Step(Move.Rwp);
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

        private static Solution Alg25()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw);
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

            step = new Step(Move.Rwp);
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

            return s;
        }

        private static Solution Alg26()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
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

            return s;
        }

        private static Solution Alg27()
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

        private static Solution Alg28()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            step = new Step(Move.Rwp);
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

            return s;
        }

        private static Solution Alg29()
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

            return s;
        }

        private static Solution Alg30()
        {
            Solution s = new Solution();

            Step step = new Step(Move.F);
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

            step = new Step(Move.F2);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg31()
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

            step = new Step(Move.F);
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

            return s;
        }

        private static Solution Alg32()
        {
            Solution s = new Solution();

            Step step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
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

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg33()
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

        private static Solution Alg34()
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
            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg35()
        {
            Solution s = new Solution();

            Step step = new Step(Move.R);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
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

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg36()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Lp);
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

            step = new Step(Move.Up);
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

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg37()
        {
            Solution s = new Solution();

            Step step = new Step(Move.F);
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

        private static Solution Alg38()
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

        private static Solution Alg39()
        {
            Solution s = new Solution();

            Step step = new Step(Move.L);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
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

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg40()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rp);
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

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
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

        private static Solution Alg41()
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

            step = new Step(Move.U2);
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

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg42()
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

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg43()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
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

            step = new Step(Move.F);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg44()
        {
            Solution s = new Solution();

            Step step = new Step(Move.F);
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

            return s;
        }

        private static Solution Alg45()
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

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg46()
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

        private static Solution Alg47()
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

        private static Solution Alg48()
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

            step = new Step(Move.Fp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg49()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg50()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw2);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg51()
        {
            Solution s = new Solution();

            Step step = new Step(Move.F);
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

            return s;
        }

        private static Solution Alg52()
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

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.B);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Bp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg53()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Lwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.U2);
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

            step = new Step(Move.Up);
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

            step = new Step(Move.U);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Lw);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg54()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rw);
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

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }

        private static Solution Alg55()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rp);
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

            step = new Step(Move.R2);
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

            return s;
        }

        private static Solution Alg56()
        {
            Solution s = new Solution();

            Step step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Up);
            // TODO
            // Add text to step
            s.AddStep(step);

            step = new Step(Move.Rw);
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

            step = new Step(Move.R);
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

            return s;
        }

        private static Solution Alg57()
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

            step = new Step(Move.Mp);
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

            step = new Step(Move.Rwp);
            // TODO
            // Add text to step
            s.AddStep(step);

            return s;
        }
    }
}
