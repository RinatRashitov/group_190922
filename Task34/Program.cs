/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


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

int getEvenOddCountFromArray(int[] usArray, int numEvent)
{
    int result = 0;
    for (int j = 0; j < usArray.Length; j++)
    {
        result = result + (usArray[j] - numEvent) % 2;
    }
    return result;
}

Console.WriteLine("Введите число элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента: ");
int numFrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: ");
int numTo = Convert.ToInt32(Console.ReadLine());
int[] userArray = createArray(userNumber);
userArray=FillDataArray(userArray, numFrom, numTo);
Console.WriteLine("Полученный массив");
PrintArray(userArray);
Console.WriteLine("");
Console.WriteLine("Введите поиск четных (1) или нечетных (0) значений: ");
int nEvent = Convert.ToInt32(Console.ReadLine());
int count=getEvenOddCountFromArray(userArray, nEvent);
if(nEvent==1)
{
    Console.WriteLine($"Количество четных элементов {count}");
}
else if(nEvent==0)
{
    Console.WriteLine($"Количество нечетных элементов {count}");
}
