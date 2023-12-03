internal class Program
{
    private static void Main(string[] args)
    {
        //A calculator that asks for input then asks for operator(+, -, *, /) and perform the operation based on which operator was chosen
        int num1 = 25, num2 = 25;
        char operatorChar1 = '+';
        char operatorChar2 = '-';
        char operatorChar3 = '*';
        char operatorChar4 = '/';
        char operatorChar5 = '%';

        Console.WriteLine($"{num1} {operatorChar1} {num2} = {calculatorFunc(num1, num2, operatorChar1)}");
        Console.WriteLine($"{num1} {operatorChar2} {num2} = {calculatorFunc(num1, num2, operatorChar2)}");
        Console.WriteLine($"{num1} {operatorChar3} {num2} = {calculatorFunc(num1, num2, operatorChar3)}");
        Console.WriteLine($"{num1} {operatorChar4} {num2} = {calculatorFunc(num1, num2, operatorChar4)}");
        Console.WriteLine($"{num1} {operatorChar5} {num2} = {calculatorFunc(num1, num2, operatorChar5)}");
    }

    static double calculatorFunc(double num1, double num2, char operatorChar)
    {
        if (operatorChar == '+')
        {
            return num1 + num2;
        }
        if (operatorChar == '-')
        {
            return num1 - num2;
        }
        if (operatorChar == '*')
        {
            return num1 * num2;
        }
        if(operatorChar == '/')
        {
            return num1 / num2;
        }
        else {
            Console.WriteLine("Invalid operator or Operator not defined in code function");
            return 0;
        }
    }
}