using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class CubePiece
    {
        private Color color;
        public Color Color
        {
            get => color;
        }

        public CubePiece(Color color)
        {
            this.color = color;
        }
    }
}
