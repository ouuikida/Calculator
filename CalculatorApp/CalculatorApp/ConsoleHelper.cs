namespace CalculatorApp
{
    internal static class ConsoleHelper
    {
        public static void Error(string message = "НЕККОРЕКТНЫЙ ВВОД")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"!ОШИБКА: {message.ToUpper()}!");
            Console.ResetColor();
        }

        public static void PressAnyButton()
        {
            Console.WriteLine("\n*нажми на любую клавишу*");
            Console.ReadKey();
            Console.Clear();
        }

        public static bool ReadAnswer(char[] answerOptions, out char answer)
        {
            string? strAnswer = Console.ReadLine();
            if (!char.TryParse(strAnswer, out answer))
            {
                Error();
                return false;
            }

            if (answerOptions.Contains(answer))
                return true;
            
            Error();
            return false;
        }

        public static bool AskYesOrNo(string message = "Да или нет?")
        {
            char answer;
            while (!ReadAnswer(['д', 'н'], out answer)) ;
            if (answer == 'д') return true;
            return false;
        }
    }
}
