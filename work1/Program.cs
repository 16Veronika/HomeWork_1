// Задайте одномерный массив из 10 целых
//чисел от 1 до 100. Найдите количество элементов
//массива, значения которых лежат в отрезке [20,90]. 


   
using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 5 целых чисел
        int[] array = new int[10]; 
        for (int i = 0; i < array.Length; i++)
       { 
        array[i] = new Random().Next(1,101);
        
       }
        // Находим количество элементов массива, значения которых лежат в отрезке [20, 90]
        int count = 0;
        for (int i = 0; i < array.Length; i++)
       
        {
            int element = array[i];
            if (element >= 20 && element <= 90)
            {
                count++;
            }
        }

        // Выводим результат в указанном формате
        Console.WriteLine($" [{string.Join(" ", array)}] => {count}");
    }
}


