using System;

namespace MegaDesk
{
    class DeskQuote
    {
        public enum RushShippingChoice
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Standard14Days
        }

        // shipping speed constant strings
        public static readonly string[] ShippingSpeeds = {
            "Rush - 3 Days", // 0
            "Rush - 5 Days", // 1
            "Rush - 7 Days", // 2
            "Standard - 14 Days" }; // 3

        // price constants
        private const decimal BasePrice = 200.00M;
        private const decimal SurfaceAreaPrice = 1.00M; // for every sq. in. > 1000
        private const decimal DrawerPriceEach = 50.00M;
        private const decimal SurfaceMaterialPriceOak = 200.00M;
        private const decimal SurfaceMaterialPriceLaminate = 100.00M;
        private const decimal SurfaceMaterialPricePine = 50.00M;
        private const decimal SurfaceMaterialPriceRosewood = 300.00M;
        private const decimal SurfaceMaterialPriceVeneer = 125.00M;
        private const decimal ShippingPriceStandard = 0.00M;

        // shipping price index order: {small desk, medium desk, large desk}
        private readonly decimal[] _shippingPrice3DayRush = { 60.00M, 70.00M, 80.00M };
        private readonly decimal[] _shippingPrice5DayRush = { 40.00M, 50.00M, 60.00M };
        private readonly decimal[] _shippingPrice7DayRush = { 30.00M, 35.00M, 40.00M };
        private const int MediumDesk = 1000;
        private const int LargeDesk = 2001;

        // properties
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public RushShippingChoice ShippingSpeed { get; set; }
        public DateTime QuoteDate { get; set; }

        // methods
        public decimal CalculateQuote()
        {
            var totalPrice = BasePrice;
            totalPrice += CalculateSurfaceAreaPrice();
            totalPrice += CalculatePriceOfDrawers();
            totalPrice += GetSurfaceMaterialPrice();
            totalPrice += GetShippingPrice();

            return totalPrice;
        }

        private decimal GetSurfaceMaterialPrice()
        {
            var surfaceMaterialPrice = 0.00M;

            switch (Desk.SurfaceMaterial)
            {
                case Desk.DesktopSurfaceMaterial.Laminate:
                    surfaceMaterialPrice = SurfaceMaterialPriceLaminate;
                    break;
                case Desk.DesktopSurfaceMaterial.Oak:
                    surfaceMaterialPrice = SurfaceMaterialPriceOak;
                    break;
                case Desk.DesktopSurfaceMaterial.Pine:
                    surfaceMaterialPrice = SurfaceMaterialPricePine;
                    break;
                case Desk.DesktopSurfaceMaterial.Rosewood:
                    surfaceMaterialPrice = SurfaceMaterialPriceRosewood;
                    break;
                case Desk.DesktopSurfaceMaterial.Veneer:
                    surfaceMaterialPrice = SurfaceMaterialPriceVeneer;
                    break;
            }

            return surfaceMaterialPrice;
        }

        private decimal CalculatePriceOfDrawers()
        {
            return DrawerPriceEach * Desk.NumberOfDrawers;
        }

        private decimal CalculateSurfaceAreaPrice()
        {
            if (CalculateSurfaceArea() > 1000)
            {
                return (CalculateSurfaceArea() - 1000) * SurfaceAreaPrice;
            }

            return 0.00M; // price if surface area <= 1000
        }

        public decimal GetShippingPrice()
        {
            decimal shippingPrice = 0.00M;

            // check desk size
            var deskSize = GetDeskSizeIndex();

            // check shipping speed
            switch (ShippingSpeed)
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
                case RushShippingChoice.Standard14Days:
                    shippingPrice = ShippingPriceStandard;
                    break;
            }

            return shippingPrice;
        }

        private int CalculateSurfaceArea()
        {
            return Desk.Width * Desk.Depth;
        }

        private int GetDeskSizeIndex()
        {
            var surfaceArea = CalculateSurfaceArea();
            if (surfaceArea < MediumDesk)
            {
                return 0; // small desk
            }
            return surfaceArea < LargeDesk ? 1 : 2; // medium desk if true, otherwise large desk
        }
    }
}
