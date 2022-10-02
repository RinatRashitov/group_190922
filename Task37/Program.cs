/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] createArray(int userNum)
{
    int[] userAr = new int[userNum];
    return userAr;
}

void PrintArray(int[] usArray)
{
    Console.Write("[");
    int index = usArray.Length;
    for (int j = 0; j < index - 1; j++)
    {
        Console.Write(usArray[j]);
        Console.Write(", ");
    }
    Console.Write(usArray[index - 1]);
    Console.Write("]");
}

int[] FillDataArray(int[] usArray, int numFrom, int numTo)
{
    for (int j = 0; j < usArray.Length; j++)
    {
        usArray[j] = new Random().Next(numFrom, numTo);
    }
    return usArray;
}

int[] returnArrayMagig(int[] usArray)
{
    int[] MagicArray = new int[usArray.Length / 2 + usArray.Length % 2];
    for (int j = 0; j < usArray.Length / 2 + usArray.Length % 2; j++)
    {
        //Console.WriteLine($"usArray.Length/2+usArray.Length%2={usArray.Length / 2 + usArray.Length % 2}");
        if (j == usArray.Length / 2 && usArray.Length % 2 == 1)
        {
            MagicArray[j] = usArray[j];
            //Console.WriteLine($"j={j}");
        }
        else
        {
            MagicArray[j] = usArray[j] + usArray[usArray.Length - j - 1];
        }
    }
    return MagicArray;
}

Console.Write("Введите число элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента: ");
int numFrom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента: ");
int numTo = Convert.ToInt32(Console.ReadLine());
int[] userArray = createArray(userNumber);
userArray = FillDataArray(userArray, numFrom, numTo);
Console.WriteLine("Полученный массив");
PrintArray(userArray);
Console.WriteLine("");
Console.WriteLine("Результирующий массив");
PrintArray(returnArrayMagig(userArray));
