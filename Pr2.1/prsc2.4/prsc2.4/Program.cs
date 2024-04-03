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
            X[i] = random.Next(-50, 51);
        }


        Console.WriteLine("Масив X:");
        PrintArray(X);


        Console.Write("Введіть число M: ");
        int M = int.Parse(Console.ReadLine());


        int[] Y = GetElementsGreaterThanM(X, M);


        Console.WriteLine($"Число M: {M}");
        Console.WriteLine("Масив Y (елементи, більші за M по модулю):");
        PrintArray(Y);
    }

    
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }


    static int[] GetElementsGreaterThanM(int[] array, int M)
    {

        int count = 0;
        foreach (int num in array)
        {
            if (Math.Abs(num) > M)
            {
                count++;
            }
        }


        int[] Y = new int[count];


        int index = 0;
        foreach (int num in array)
        {
            if (Math.Abs(num) > M)
            {
                Y[index] = num;
                index++;
            }
        }

        return Y;
    }
}