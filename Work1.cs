using System;
class Program
{
    static void Main()
    {
        while(true)
        {
        Console.WriteLine("Введите число c клавиатуры или закончите цикл нажав 'q':");
        string input = Console.ReadLine()!;
        if(input == "q")
            {
            break;
            }
        int numbers;
        if(int.TryParse(input, out numbers))
            {
            int sum = 0;
            while(numbers > 0)
                {
                sum = numbers % 10;
                numbers = numbers / 10;
                }
            if(sum % 2 == 0)
                {
                Console.WriteLine("STOP");
                break;
                }
        }
        else
            {
            Console.WriteLine("Некоректный ввод числа, введите целое число или закончите ввод нажав 'q':");
            }
        }

    }
}