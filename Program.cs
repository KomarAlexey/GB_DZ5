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
