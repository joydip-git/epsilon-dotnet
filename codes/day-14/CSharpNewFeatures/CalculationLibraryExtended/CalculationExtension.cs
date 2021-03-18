using CalculationLibrary;
namespace CalculationLibraryExtended
{
    //without modifying or recreating the existing type (class, interface etc..), adding or injecting additional functionalities is known as Extension Method technique
    public static class CalculationExtension
    {
        public static int Multiply(this Calculation calculation, int first, int second)
        {
            var res = calculation.Add(first, second);
            return (first * second * res);
        }
        public static int Divide(this Calculation calculation, int first, int second)
        {
            return (first / second);
        }
    }
}
