/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

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

Console.WriteLine("Введите число элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента: ");
int numFrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: ");
int numTo = Convert.ToInt32(Console.ReadLine());
int[] UserArray = createArray(userNumber);
//PrintArray(UserArray);
Console.WriteLine("Полученный массив");
PrintArray(FillDataArray(UserArray, numFrom, numTo+1));