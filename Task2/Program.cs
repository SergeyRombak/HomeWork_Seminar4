// Задача2
/* Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

Console.Clear();
int SizaArr = 15;
 int[] FillArray(int size)
 {
    int[] array = new int[size];   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
 }

void PrintArray(int[] inputArray)
{   
    Console.Write("Массив с элементами: ");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i] + " ");
    }
}

void CTPOAE(int[] num) 
{
    int[] evenNumbers = new int[num.Length];
    Console.WriteLine(); 
    Console.Write("Элементы массива, значения которых четное: "); 

    int countOfEvenNumbers = 0;

    for (int i = 0; i < num.Length; i++) 
    { 
        if (num[i] % 2 == 0) 
        {
            Console.Write(num[i] + " ");
            evenNumbers[countOfEvenNumbers] = num[i];
            countOfEvenNumbers++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел в массиве: {countOfEvenNumbers}");
}

int[] Arr = FillArray(SizaArr);
PrintArray(Arr);
CTPOAE(Arr);
