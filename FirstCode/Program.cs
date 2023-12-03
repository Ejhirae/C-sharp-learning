internal class Program
{
    private static void Main(string[] args)
    {
        //Just like in the if-statement branch the same thing goes but using a switch statement this time
        int num1 = 72, num2 = 54;
        char operatorChar1 = '+';
        char operatorChar2 = '-';
        char operatorChar3 = '*';
        char operatorChar4 = '/';
        char operatorChar5 = '%';

        Console.WriteLine($"{num1} {operatorChar1} {num2} = {switchCalculator(num1, num2, operatorChar1)}");
        Console.WriteLine($"{num1} {operatorChar2} {num2} = {switchCalculator(num1, num2, operatorChar2)}");
        Console.WriteLine($"{num1} {operatorChar3} {num2} = {switchCalculator(num1, num2, operatorChar3)}");
        Console.WriteLine($"{num1} {operatorChar4} {num2} = {switchCalculator(num1, num2, operatorChar4)}");
        Console.WriteLine($"{num1} {operatorChar5} {num2} = {switchCalculator(num1, num2, operatorChar5)}");

    }

    static double switchCalculator(double num1, double num2, char operatorChar)
    {
        switch (operatorChar)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num1 / num2;
            default:
                Console.WriteLine("Invalid Operator or Operator not found");
                return 0;
        }
    }
}