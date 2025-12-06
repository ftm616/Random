using System;

namespace appRandom
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();

        int[] arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 101); 
        }

        Console.WriteLine("مقادیر تصادفی آرایه:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.ReadKey();
    
        }
    }
}
