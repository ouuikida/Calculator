namespace CalculatorApp
{
    internal class Calculator
    {
        public static double Answer { get; private set; }

        public void Addition(double a, double b) => Answer = a + b;
        public void Subtraction(double a, double b) => Answer = a - b;
        public void Multiplication (double a, double b) => Answer = a * b;
        public void Division(double a, double b) => Answer = a / b;
    }
}
