using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] X = new int[10 + 8];


        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(100);
        }


        Console.WriteLine("Масив X:");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();


        int min = X[0];
        int max = X[0];
        for (int i = 1; i < X.Length; i++)
        {
            if (X[i] < min)
            {
                min = X[i];
            }
            if (X[i] > max)
            {
                max = X[i];
            }
        }


        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }
}
