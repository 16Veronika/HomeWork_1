//Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет
//количество чётных чисел в массиве


using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 5 целых чисел
        int[] array = new int[10]; 
        for (int i = 0; i < array.Length; i++)
       { 
        array[i] = new Random().Next(0,100);
        
       }
        // Находим количество элементов массива, значения которых лежат в отрезке [20, 90]
        int count = 0;
        for (int i = 0; i < array.Length; i++)
       
        {
            int element = array[i];
            if (element %2 == 0)
            {
                count++;
            }
        }

        // Выводим результат в указанном формате
        Console.WriteLine($" массив [{string.Join(" ", array)}] => {count}");
    }
}
