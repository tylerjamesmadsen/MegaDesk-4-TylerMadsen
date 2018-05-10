using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        };

        public int CustomerName { get; set; }

        public int ShippingSpeed { get; set; }

        private decimal CalculatePriceQuote()
        {
            // TODO
            return 100.00M;
        }
    }
}
