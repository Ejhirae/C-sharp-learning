internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = { "Victor", "Edward", "Amarachi", "Kitan" };

        //For Normal
        for(int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }

        //For each
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}