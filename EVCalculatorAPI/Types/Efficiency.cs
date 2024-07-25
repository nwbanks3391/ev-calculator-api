namespace EVCalculatorAPI.Types
{
    public class Efficiency
    {
        public Efficiency(double milesPerkWh, double whPerMile, double kWhPer100Miles, double kilometersPerkWh, double whPerKilometer, double kWhPer100Kilometers, double mPGe)
        {
            MilesPerkWh = milesPerkWh;
            WhPerMile = whPerMile;
            KWhPer100Miles = kWhPer100Miles;
            KilometersPerkWh = kilometersPerkWh;
            WhPerKilometer = whPerKilometer;
            KWhPer100Kilometers = kWhPer100Kilometers;
            MPGe = mPGe;
        }

        public double MilesPerkWh { get; set; }
        public double WhPerMile { get; set; }
        public double KWhPer100Miles { get; set; }
        public double KilometersPerkWh { get; set; }
        public double WhPerKilometer { get; set; }
        public double KWhPer100Kilometers { get; set; }
        public double MPGe { get; set; }

    }
}
