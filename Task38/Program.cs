/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


double[] createArray(int userNum)
{
    double[] userAr = new double[userNum];
    return userAr;
}

void PrintArray(double[] usArray)
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

double[] FillDataArray(double[] usArray)
{
    for (int j = 0; j < usArray.Length; j++)
    {
        usArray[j] = Math.Round(new Random().NextDouble() * 100, 3);
    }
    return usArray;
}

double getMinFromArray(double[] userArray)
{
    double result = userArray[0];
    for (int j = 1; j < userArray.Length; j++)
    {
        if (userArray[j] < result)
        {
            result = userArray[j];
        }
    }
    return result;
}

double getMaxFromArray(double[] userArray)
{
    double result = userArray[0];
    for (int j = 1; j < userArray.Length; j++)
    {
        if (userArray[j] > result)
        {
            result = userArray[j];
        }
    }
    return result;
}

Console.WriteLine("Введите число элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

double[] userArray = createArray(userNumber);
userArray = FillDataArray(userArray);
Console.WriteLine("Полученный массив");
PrintArray(userArray);
Console.WriteLine("");

Console.WriteLine($"Разница между максимальным {getMaxFromArray(userArray)} и минимальным {getMinFromArray(userArray)} значениями массива составляет {getMaxFromArray(userArray) - getMinFromArray(userArray)}");