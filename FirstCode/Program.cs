using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //while loop
        string[] names = { "Victor", "Edward", "Amarachi", "Kitan" };

        int i = 0;

        while (i < names.Length)
        {
            Console.WriteLine(names[i]);
            i++;
        }

        //do while loop
        string[] names2 = { "Victor", "Edward", "Doyinsola", "Harvard" };
        int j = 0;
        do
        {
            Console.WriteLine(names2[j]);
            j++;
        } while(j <= names2.Length-1);

        //while loop reversed

        i = names.Length-1;

        while (i >= 0)
        {
            Console.WriteLine(names[i]);
            i--;
        }

        //do while loop reversed

        j = names2.Length-1;

        do
        {
            Console.WriteLine(names2[j]);
            j--;
        }while(j >= 0);

    }
}