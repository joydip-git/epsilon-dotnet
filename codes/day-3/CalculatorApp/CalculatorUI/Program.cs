namespace CalculatorUI
{
    class Program
    {
        static void Main()
        {
            char toContinue = 'n';
            do
            {
                UIManager.PrintMenu();
                int choice = UIManager.GetChoice();
                UIManager.Calculate(choice);
                toContinue = UIManager.ToContinueOrNot();
                UIManager.ConvertChoice(ref toContinue);
            } while (toContinue != 'n' && toContinue == 'y');
        }
    }
}
