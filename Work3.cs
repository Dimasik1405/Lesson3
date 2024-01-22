using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[10] {1, 10, 121, 4, 8, 12, 88, 64, 18, 44};
        int revers;
        foreach(int element in numbers)
        {
            Console.Write(element +" ");
        }
        for(int i = 0; i < numbers.Length/2; i++)
        {
            revers = numbers[i];
           numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = revers;
        }
        Console.Write("Перевернутый массив" + " ");
        foreach(int element in numbers)
        {
        Console.Write(element + " ");
        }

    }
}