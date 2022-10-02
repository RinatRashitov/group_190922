/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

// функция создания массива
// НКЦИЯ ПЕРЕМНОЖЕНИЯ ЭЛЕМЕНТОВ
// создаем массив

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
