/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

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

int[] FillDataArray(int[] usArray)
{
    for (int j = 0; j < usArray.Length; j++)
    {
        usArray[j] = new Random().Next(1, 100);
    }
    return usArray;
}

int[] ReverseArray(int[] reversibleArray)
{
    for (int i = 0; i < reversibleArray.Length / 2 + reversibleArray.Length % 2; i++)
    {
        int tmpNumber = reversibleArray[i];
        reversibleArray[i] = reversibleArray[reversibleArray.Length - i - 1];
        reversibleArray[reversibleArray.Length - i - 1] = tmpNumber;
    }
    return reversibleArray;
}

Console.WriteLine("Введите число элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = createArray(userNumber);
userArray = FillDataArray(userArray);
Console.WriteLine("Полученный массив");
PrintArray(userArray);
Console.WriteLine("");
userArray = ReverseArray(userArray);
Console.WriteLine("Перевернутый массив");
PrintArray(userArray);