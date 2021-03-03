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
                char continutaionChoice = UIManager.ToContinueOrNot();
                toContinue = UIManager.ConvertChoice(continutaionChoice);
            } while (toContinue != 'n' && toContinue == 'y');
        }
    }
}
