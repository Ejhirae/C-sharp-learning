internal class Program
{
    private static void Main(string[] args)
    {
        //Guessing Game
        //User has 3 chances - guess the word
        // After 3 chances - failed
        //Guessed before 3 chances is up? You win

        string wordToGuess = "home";
        int numberOfGuesses = 3;
        bool isGuessed = false;
        Console.WriteLine($"You have {numberOfGuesses} attempts");
        while (numberOfGuesses > 0 && isGuessed == false) {
            Console.Write("Guess The Word:");
            string word = Console.ReadLine()!;
            if(word != wordToGuess) {
                numberOfGuesses--;
                Console.WriteLine("Incorrect Guess");
                Console.WriteLine($"You have {numberOfGuesses} attempt(s) left");
            }
            else
            {
                Console.WriteLine("Word Guessed Correctly");
                isGuessed = true;
            }
        }
    }
}