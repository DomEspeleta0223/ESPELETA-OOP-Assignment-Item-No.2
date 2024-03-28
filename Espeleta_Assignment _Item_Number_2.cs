using System;

internal class Espeleta_Assignment_Item_Number_2
{
    static void Main(string[] args)
    {
        int N = 1;
        while (N < 101)
        {
            if (N % 3 == 0 && N % 5 == 0)
            {
                Console.WriteLine("Hello Goodbye");
            }
            else if (N % 3 == 0)
            {
                Console.WriteLine("Hello");
            }
            else if (N % 5 == 0)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine(N);
            }
            N++;
        }
    }

}
