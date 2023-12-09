// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 

using System;

class Program
{
    static void Main()
    {
        int arraySize = 10;

        double[] numbers = new double[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = new Random().NextDouble() * 10; 
        }

        Console.Write("Массив вещественных чисел: [");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($" {numbers[i]:F2} ");
        }

        double maxNumber = numbers[0];
        double minNumber = numbers[0];

        for (int i = 1; i < arraySize; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }

            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        double difference = maxNumber - minNumber;

        Console.WriteLine($" ] => {difference:F2}");
    }
}
