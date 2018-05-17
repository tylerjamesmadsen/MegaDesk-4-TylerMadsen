using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        public enum ShippingSpeedChoice
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Standard14Days
        }

        // shipping speed constant strings
        public static readonly string[] SHIPPING_SPEEDS = {
            "Rush - 3 Days",
            "Rush - 5 Days",
            "Rush - 7 Days",
            "Standard - 14 Days" };

        // price constants
        const decimal PRICE_BASE = 200.00M;
        const decimal PRICE_SURFACE_AREA= 1.00M;
        const decimal PRICE_DRAWER_EACH = 50.00M;
        const decimal PRICE_SURFACE_MATERIAL_OAK = 200.00M;
        const decimal PRICE_SURFACE_MATERIAL_LAMINATE = 100.00M;
        const decimal PRICE_SURFACE_MATERIAL_PINE = 50.00M;
        const decimal PRICE_SURFACE_MATERIAL_ROSEWOOD = 300.00M;
        const decimal PRICE_SURFACE_MATERIAL_VENEER = 125.00M;
        const decimal PRICE_SHIP_3D_AND_SA_LT_1000 = 60.00M;
        const decimal PRICE_SHIP_3D_AND_SA_GT_1000_LT_2000 = 70.00M;
        const decimal PRICE_SHIP_3D_AND_SA_GT_2000 = 80.00M;
        const decimal PRICE_SHIP_5D_AND_SA_LT_1000 = 40.00M;
        const decimal PRICE_SHIP_5D_AND_SA_GT_1000_LT_2000 = 50.00M;
        const decimal PRICE_SHIP_5D_AND_SA_GT_2000 = 60.00M;
        const decimal PRICE_SHIP_7D_AND_SA_LT_1000 = 30.00M;
        const decimal PRICE_SHIP_7D_AND_SA_GT_1000_LT_2000 = 35.00M;
        const decimal PRICE_SHIP_7D_AND_SA_GT_2000 = 40.00M;
        const decimal PRICE_SHIP_STANDARD = 0.00M;


        // properties
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public ShippingSpeedChoice ShippingSpeed { get; set; }
        public DateTime QuoteDate { get; set; }

        // methods
        public decimal CalculateQuote()
        {
            // TODO:
            return PRICE_BASE;
        }

        public decimal GetShippingPrice()
        {
            // TODO:
            return 0.00M;
        }
    }
}
