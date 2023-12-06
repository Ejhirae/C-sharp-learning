internal class Program
{
    private static void Main(string[] args)
    {
        //Student Age - Student Scores

        int[,] studentDetails =
        {
            { 18, 50 },
            { 23, 73},
            { 54, 98},
        };
        try
        {


            for (int i = 0; i <= studentDetails.GetLength(0); i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j <= studentDetails.GetLength(0); j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(studentDetails[i, j]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}