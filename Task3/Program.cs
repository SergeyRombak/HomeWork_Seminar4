﻿// Задача3
/* Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.) */

Console.Clear();
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintArray(int[] inputArray)
{
    Console.WriteLine();
    Console.Write("Массив с элементами: ");

    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i] + " ");
    }
}

void ReverseArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[length - 1 - i];
        arr[length - 1 - i] = temp;
    }
}
int SizaArr = 15;
int[] Arr = FillArray(SizaArr);
PrintArray(Arr);
ReverseArray(Arr);
PrintArray(Arr);
