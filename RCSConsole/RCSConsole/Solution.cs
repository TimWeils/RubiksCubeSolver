using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Solution
    {
        public List<Step> steps;
        public int turnsCount;

        public Solution()
        {
            this.steps = new List<Step>();
            this.turnsCount = 0;
        }

        public void AddStep(Step step)
        {
            steps.Add(step);

            switch (step.move)
            {
                case Move.U2:
                case Move.Uw2:
                case Move.D2:
                case Move.Dw2:
                case Move.R2:
                case Move.Rw2:
                case Move.L2:
                case Move.Lw2:
                case Move.M2:
                case Move.E2:
                case Move.S2:
                case Move.RotationX2:
                case Move.RotationY2:
                case Move.RotationZ2:
                    turnsCount += 2;
                    break;
                default:
                    turnsCount++;
                    break;
            }
        }
    }
}
