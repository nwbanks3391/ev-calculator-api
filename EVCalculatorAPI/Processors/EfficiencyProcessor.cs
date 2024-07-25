using EVCalculatorAPI.Interfaces;
using EVCalculatorAPI.Types;

namespace EVCalculatorAPI.Processors
{
    public class EfficiencyProcessor : IEfficiencyProcessor
    {
        public Efficiency GetEfficiencyCalculations(double value, string unit)
        {
            double MilesPerkWh = 0.00;
            double WhPerMile = 0.00;
            double KWhPer100Miles = 0.00;
            double KilometersPerkWh = 0.00;
            double WhPerKilometer = 0.00;
            double KWhPer100Kilometers = 0.00;
            double MPGe = 0.00;

            double milesToKilometers = 1.609344;
            double kWhPerGallon = 33.410107;




            switch (unit)
            {
                case "mi/kWh":
                    MilesPerkWh = value; break;
                case "Wh/mi":
                    MilesPerkWh = (1.0 / value) * 1000.0;
                    WhPerMile = (1.0 / value);
                    break;
                case "kWh/100mi":
                    MilesPerkWh = (1.0 / value) * 100.0;
                    KWhPer100Miles = value;
                    break;
                case "km/kWh":
                    MilesPerkWh = value * (1.0 / milesToKilometers);
                    KilometersPerkWh = value;
                    break;
                case "Wh/km":
                    MilesPerkWh = (1.0 / (1.0 / milesToKilometers) * value) * 1000.0; 
                    WhPerKilometer = value;
                    break;
                case "kWh/100km":
                    MilesPerkWh = (1.0 / (1.0 / milesToKilometers) * value) * 100.0;
                    KWhPer100Kilometers = value;
                    break;
                case "MPGe":
                    MilesPerkWh = kWhPerGallon / value;
                    MPGe = value;
                    break;
                default:
                    break;
            }

            WhPerMile = WhPerMile > 0.0 ? WhPerMile : 1.0 / MilesPerkWh * 1000.0;
            KWhPer100Miles = KWhPer100Miles > 0.0 ? KWhPer100Miles : WhPerMile / 10.0;
            KilometersPerkWh = KilometersPerkWh > 0.0 ? KilometersPerkWh : MilesPerkWh * milesToKilometers;
            WhPerKilometer = WhPerKilometer > 0.0 ? WhPerKilometer : (1.0 / KilometersPerkWh) * 1000;
            KWhPer100Kilometers = KWhPer100Kilometers  > 0.0? KWhPer100Kilometers : WhPerKilometer / 10.0;
            MPGe = MPGe > 0 ? MPGe : MilesPerkWh * kWhPerGallon;



            Efficiency efficiency = new Efficiency(MilesPerkWh,WhPerMile,KWhPer100Miles,KilometersPerkWh,WhPerKilometer,KWhPer100Kilometers,MPGe);
            return efficiency;
        }

     
    }
}
