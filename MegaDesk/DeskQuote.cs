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
        private const decimal ShippingPrice3DayRushSmallDesk = 60.00M;
        private const decimal ShippingPrice3DayRushMediumDesk = 70.00M;
        private const decimal ShippingPrice3DayRushLargeDesk = 80.00M;
        private const decimal ShippingPrice5DayRushSmallDesk = 40.00M;
        private const decimal ShippingPrice5DayRushMediumDesk = 50.00M;
        private const decimal ShippingPrice5DayRushLargeDesk = 60.00M;
        private const decimal ShippingPrice7DayRushSmallDesk = 30.00M;
        private const decimal ShippingPrice7DayRushMediumDesk = 35.00M;
        private const decimal ShippingPrice7DayRushLargeDesk = 40.00M;
        private const decimal ShippingPriceStandard = 0.00M;


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
            // TODO:
            var shippingPrice = 0.00M;
            switch (RushShipping)
            {
                case RushShippingChoice.Rush3Days:
                    shippingPrice = ShippingPrice3DayRushSmallDesk;
                    break;
                case RushShippingChoice.Rush5Days:
                    shippingPrice = ShippingPrice5DayRushSmallDesk;
                    break;
                case RushShippingChoice.Rush7Days:
                    shippingPrice = ShippingPrice7DayRushSmallDesk;
                    break;
                default: // standard shipping
                    shippingPrice = ShippingPriceStandard;
                    break;
            }

            var sizeOfDesk = Desk.CalculateSurfaceArea();
            if (sizeOfDesk >= 1000 && sizeOfDesk <= 2000)
            {

            }
            else if (sizeOfDesk > 2000)
            {

            }
            return shippingPrice;
        }
    }
}
