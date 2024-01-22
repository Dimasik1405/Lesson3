using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[6];
        Random rnd = new Random();
        int count = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(100, 1000);
            Console.WriteLine(numbers[i]+" ");
            if(numbers[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Количество чётных чисел в массиве {count}");
    }
}
