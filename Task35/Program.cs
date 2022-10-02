/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int getSumNumbers(int[] inArray, int numFrom, int numTo)
{
    int result = 0;
    for (int j = 1; j < inArray.Length; j++)
    {
        if (inArray[j] >= numFrom && inArray[j] <= numTo)
        {
            result = result + 1;
        }
    }
    return result;
}

void getPrint(string Text, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(Text);
    Console.ResetColor();
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0;i < array.Length-1;i++)
    {
         Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}

Console.WriteLine("Введите желаемую длину массива :");
int userNumber = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте минимальный диапазон значений в массиве :", ConsoleColor.Blue);
int MinMeaning = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте максимальный диапазон значений в массиве :", ConsoleColor.Red);
int MaxMeaning = Convert.ToInt32(Console.ReadLine());


int[] Array = new int[userNumber];
for (int i = 0; i < userNumber; i++)
{
    Array[i] = new Random().Next(MinMeaning, MaxMeaning +1);
}

PrintArray(Array);
Console.WriteLine(getSumNumbers(Array, 10, 99));

