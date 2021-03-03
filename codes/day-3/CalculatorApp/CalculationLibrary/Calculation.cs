namespace CalculationLibrary
{
    /// <summary>
    /// This class contains methods for calculation
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// Method to add two numbers
        /// </summary>
        /// <param name="firstValue">First Number to be passed</param>
        /// <param name="secondValue">Second Number to be passed</param>
        /// <returns>
        /// returns the added value
        /// </returns>
        public int Add(int firstValue, int secondValue)
        {
            return (firstValue + secondValue);
        }

        /// <summary>
        /// Method to subtract a number from another
        /// </summary>
        /// <param name="firstValue">First Number to be passed</param>
        /// <param name="secondValue">Second Number to be passed</param>
        /// <returns>
        /// returns the subtracted value
        /// </returns>
        public int Subtract(int firstValue, int secondValue)
        {
            return (firstValue - secondValue);
        }

        /// <summary>
        /// Method to multiply a number by another
        /// </summary>
        /// <param name="firstValue">First Number to be passed</param>
        /// <param name="secondValue">Second Number to be passed</param>
        /// <returns>
        /// returns the multiplied value
        /// </returns>
        public int Multiply(int firstValue, int secondValue)
        {
            return (firstValue * secondValue);
        }

        /// <summary>
        /// Method to divide a number by another
        /// </summary>
        /// <param name="firstValue">First Number to be passed</param>
        /// <param name="secondValue">Second Number to be passed</param>
        /// <returns>
        /// returns the division value
        /// </returns>
        public int Divide(int firstValue, int secondValue)
        {
            return (firstValue / secondValue);
        }
    }
}
