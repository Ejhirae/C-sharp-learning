## Data Types in C#
Different types of Variables in C#
String - 
usage - string characterName = "Victor";

Int - Negative/Positive Whole Numbers
usage - int characterAge = 21;

Char - For storing a single character
usage - char characterGender = 'M';

Float - 7 digits (32 bit) degree of precision

Double-15-16 digits (64 bit) degree of precision
usuage - double characterGpa = 3.94;

Decimal -28-29 significant digits (128 bit) degree of precision

Boolean - True or false
usage- bool isMale = true;

## Working with Numbers
int age = 17;

age = --age - ++age;

Console.WriteLine(age);

int x = 4;

x = x++ + ++x;

Console.WriteLine(x);

Console.WriteLine(Math.Floor(4.8));

## Getting user inputs
Console.Write("Enter first number: ");

string num1 = Console.ReadLine()!;

Console.Write("Enter second number: ");

string num2 = Console.ReadLine()!;

int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);

Console.WriteLine("Your answer is: " + sum.ToString() );

Console.Beep();

## Arrays
int[] scores = { 1, 2, 3, 4, 5, 6 };

Console.WriteLine(scores[0].ToString() + scores[1].ToString() + scores[2].ToString() + scores[3].ToString() + scores[4].ToString() + scores[5].ToString());

string[] names = { "Victor", "Edward", "Amarachi", "Kitan" };

Console.WriteLine(names[1] + names[2] + names[0] + names[3]);

## Methods and Return
string name = "Victor";

int age = 20;

int num1 = -2, num2 = 15;

Console.WriteLine("Your sum is: "+ sumTwoNumbers(12,12));

Console.WriteLine("Your sum is: " + sumTwoNumbers(num1, num2));

getDetails(16, "Irene");

getDetails(age, name);

Console.WriteLine(returnPow(2, 3));

}

static int sumTwoNumbers(int num1, int num2)
{

return num1 + num2;

}

static void getDetails(int age, string name)
{

Console.WriteLine("Your name is "+ name +  " and you are "+age+" years old.");

}

static double returnPow(double baseNumber, double powerNumber)
{

return Math.Pow(baseNumber, powerNumber);

}

## IF Statements
static double tempConverter(double temp, char degrees)
{
    if (degrees == 'F' || degrees == 'f') {
        return (temp - 32) * 5 / 9;
    } else if (degrees == 'C' || degrees == 'c')
    {
        return (temp * 9 / 5) + 32;
    }
    else
    {
        Console.WriteLine("Invalid degree detected");
        return 0.0;
    }
}

static void decisionMaker(bool isRaining)
{
    string computerResponse;
    Console.WriteLine("Human Question: Should I go to class?");
    if (isRaining == false)
    {
        computerResponse = "Computer Response: Go to class. It is not raining";
        Console.WriteLine(computerResponse);
    }
    else
    {
        computerResponse = "Computer Response: No do not go to class. It is raining";
        Console.WriteLine(computerResponse);
    }
}
static void electionDescision(int age) {
    Console.WriteLine("AI: How old are you?");
    Console.WriteLine("Me: "+ age);
    if (age >= 18)
    {
        Console.WriteLine("AI: You are eligible to vote.");
    }
    else
    {
        int yearsTillEligible = 18 - age;
        Console.WriteLine("AI: You are not eligible to vote.");
        Console.WriteLine("AI: Come back in the next " + yearsTillEligible +" year(s).");
    }
}

# Switch Statements