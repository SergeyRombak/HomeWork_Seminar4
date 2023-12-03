// Задача 1:
/* Напишите программу, которая бесконечно запрашивает целые числа
с консоли. Программа завершается при вводе "q" или при вводе
числа, сумма цифр которого четная.*/

while (true)
{
Console.Clear();
Console.WriteLine("Введите целое число или 'q' для завершения программы");
string input = Console.ReadLine()!;

if (input.ToLower() == "q") 
{ 
    Console.WriteLine("Программа завершена");
    break;
}

if(int.TryParse(input, out int number))
{
    int sum = CDS(number);
  
    if(sum % 2 == 0)
    {
        Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершается.");
        break;
    }
    else
    {
        Console.WriteLine($"Сумма цифр числа {number} не чётная. Введите число.");
    }
}
else
{
        Console.WriteLine("Некоректный ввод.");
}
}

int CDS(int num) 
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10; 
        num /= 10; 
    }
    return sum;
}

