namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Calculator calculator = new();

                double[] numbers = new double[2];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Введите {i + 1} число: ");
                    while (!ReadDouble(out numbers[i])) ;
                }

                char[] operations = ['+', '-', '*', '/'];
                char operation;

                do Console.Write("Введите знак операции (+, -, *, /): ");
                while (!ConsoleHelper.ReadAnswer(operations, out operation));

                switch (operation)
                {
                    case '+':
                        calculator.Addition(numbers[0], numbers[1]);
                        break;
                    case '-':
                        calculator.Subtraction(numbers[0], numbers[1]);
                        break;
                    case '*':
                        calculator.Multiplication(numbers[0], numbers[1]);
                        break;
                    case '/' when numbers[1] != 0:
                        calculator.Division(numbers[0], numbers[1]);
                        break;
                    case '/':
                        ConsoleHelper.Error("ДЕЛЕНИЕ НА НОЛЬ");
                        break;
                }

                Console.WriteLine($"{numbers[0]} {operation} {numbers[1]} = {Calculator.Answer}");
                ConsoleHelper.PressAnyButton();
            }
            while (ConsoleHelper.AskYesOrNo("Запустить программу заново?"));
        }


        private static bool ReadDouble(out double result)
        {
            string? str = Console.ReadLine();
            if (!double.TryParse(str, out result))
            {
                ConsoleHelper.Error();
                return false;
            }
            return true;
        }
    }
}
