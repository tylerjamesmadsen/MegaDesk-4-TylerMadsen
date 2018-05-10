using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public int SurfaceMaterial { get; set; }

        private int calculateSurfaceArea()
        {
            // TODO
            return 500;
        }
    }
}
