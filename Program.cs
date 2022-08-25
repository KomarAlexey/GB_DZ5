// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.Clear();

// int[] CreateRandomArray(int length,int start,int end)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(start,end+1);
//     }
//     return array;
// }
// int CorrectLengthInput(string text = "")
// {
//     Console.Write(text);
//     int input = int.Parse(Console.ReadLine()!);
//     while(input < 1)
//     {
//         Console.Write("Введите длину массива: ");
//         int TryAgain = int.Parse(Console.ReadLine());
//         input = TryAgain;
//     }
//     return input;
// }
// int length =    CorrectLengthInput("Введите длину массива: ");
// int[] array = CreateRandomArray(length, 100, 999);
// int count = 0;
// for (int i = 0; i < length; i++)
// {
//     if(array[i]%2 == 0)
//     {
//         count ++;
//     }
// }
// Console.Write($"[{String.Join(", ", array) }] количество четных {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Clear();
// int[] FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max = 1);
//     }
//     return array;
// }
// int[] array = new int[4];
// FillArray(array, -10, 10);
// Console.WriteLine($"[{String.Join(" , ", array)}]");
// int sum = 0 ;
// for (int i = 1; i < array.Length; i+= 2)
// {
//     sum +=array[i];
// }
// Console.Write($"Сумма элементов , стоящих  на нечетных позициях равна {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.Clear();
// int[] FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max = 1);
//     }
//     return array;
// }
// int[] array = new int[5];
// FillArray(array, -10, 10);
// Console.WriteLine($"[{String.Join(" , ", array)}]");
// int min = array[0];
// int max = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// Console.Write($"Разница между максимальным и минимальным элементом массива равна {max - min}");