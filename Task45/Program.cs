/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования*/

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

int[] ReverseArray(int[] reversibleArray)
{
    int[] resultArray= new int[reversibleArray.Length];
    for(int i=0;i<reversibleArray.Length;i++)
    {
        resultArray[i]=reversibleArray[i]; 
    }
    return resultArray;
}

Console.WriteLine("Введите число элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента: ");
int numFrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: ");
int numTo = Convert.ToInt32(Console.ReadLine());
int[] userArray = createArray(userNumber);
userArray = FillDataArray(userArray, numFrom, numTo);
Console.WriteLine("Полученный массив");
PrintArray(userArray);
int[] reversedArray = createArray(userNumber);
reversedArray=ReverseArray(userArray);
Console.WriteLine();
Console.WriteLine("Скопированный массив");
PrintArray(reversedArray);



