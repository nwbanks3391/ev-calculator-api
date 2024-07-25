using EVCalculatorAPI.Types;
namespace EVCalculatorAPI.Interfaces

{
    public interface IEfficiencyProcessor
    {
        Efficiency GetEfficiencyCalculations(double value, string unit);
    }
}
