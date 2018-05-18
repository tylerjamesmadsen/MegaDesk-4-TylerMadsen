using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        public enum RushShippingChoice
        {
            Rush3Days,
            Rush5Days,
            Rush7Days
        }

        private enum DeskSize
        {
            Small,
            Medium,
            Large
        }

        // shipping speed constant strings
        public static readonly string[] ShippingSpeeds = {
            "Rush - 3 Days", // 0
            "Rush - 5 Days", // 1
            "Rush - 7 Days", // 2
            "Standard - 14 Days" }; // 3

        // price constants
        private const decimal BasePrice = 200.00M;
        private const decimal SurfaceAreaPrice= 1.00M;
        private const decimal DrawerPriceEach = 50.00M;
        private const decimal SurfaceMaterialPriceOak = 200.00M;
        private const decimal SurfaceMaterialPriceLaminate = 100.00M;
        private const decimal SurfaceMaterialPricePine = 50.00M;
        private const decimal SurfaceMaterialPriceRosewood = 300.00M;
        private const decimal SurfaceMaterialPriceVeneer = 125.00M;
        // TEST
        private const decimal ShippingPriceStandard = 0.00M;
        // {small desk, medium desk, large desk}
        private readonly decimal[] _shippingPrice3DayRush = {60.00M, 70.00M, 80.00M};
        private readonly decimal[] _shippingPrice5DayRush = {40.00M, 50.00M, 60.00M};
        private readonly decimal[] _shippingPrice7DayRush = {30.00M, 35.00M, 40.00M};
        //private const decimal ShippingPrice3DayRushSmallDesk = 60.00M;
        //private const decimal ShippingPrice3DayRushMediumDesk = 70.00M;
        //private const decimal ShippingPrice3DayRushLargeDesk = 80.00M;
        //private const decimal ShippingPrice5DayRushSmallDesk = 40.00M;
        //private const decimal ShippingPrice5DayRushMediumDesk = 50.00M;
        //private const decimal ShippingPrice5DayRushLargeDesk = 60.00M;
        //private const decimal ShippingPrice7DayRushSmallDesk = 30.00M;
        //private const decimal ShippingPrice7DayRushMediumDesk = 35.00M;
        //private const decimal ShippingPrice7DayRushLargeDesk = 40.00M;
        private const int MediumDesk = 1000;
        private const int LargeDesk = 2001;



        // properties
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public RushShippingChoice RushShipping { get; set; }
        public DateTime QuoteDate { get; set; }

        // methods
        public decimal CalculateQuote()
        {
            // TODO:
            // total price = base price $200.00
            var totalPrice = BasePrice;
            // += $1.00 per sq. in. > 1000

            // += $50 per drawer

            // += <amount> for surface material

            // += <amount> if <rush choice> and <desk size>
            
            return totalPrice;
        }

        public decimal GetShippingPrice()
        {
            var shippingPrice = -1.00M;

            // check desk size
            var deskSize = GetDeskSizeIndex();

            // check shipping speed
            switch (RushShipping)
            {
                case RushShippingChoice.Rush3Days:
                    shippingPrice = _shippingPrice3DayRush[deskSize];
                    break;
                case RushShippingChoice.Rush5Days:
                    shippingPrice = _shippingPrice5DayRush[deskSize];
                    break;
                case RushShippingChoice.Rush7Days:
                    shippingPrice = _shippingPrice7DayRush[deskSize];
                    break;
                default: // standard shipping
                    shippingPrice = ShippingPriceStandard;
                    break;
            }

            return shippingPrice;
        }

        private int GetDeskSizeIndex()
        {
            var surfaceArea = Desk.CalculateSurfaceArea();
            if (surfaceArea < MediumDesk)
            {
                return 0; // small desk
            }
            else if (surfaceArea < LargeDesk)
            {
                return 1; // medium desk
            }
            else
            {
                return 2; // large desk
            }
        }
    }
}
