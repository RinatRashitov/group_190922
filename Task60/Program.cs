/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int getIntNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, Вы ввели: {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}
int[,,] create3DArray(int userNumX, int userNumY, int userNumZ)
{
    int[,,] userAr = new int[userNumX, userNumY, userNumZ];
    return userAr;
}
void Print3DArray(int[,,] usArray)
{
    Console.WriteLine();
    for (int j = 0; j < usArray.GetLength(0); j++)
    {
        for (int k = 0; k < usArray.GetLength(1); k++)
        {
            for (int l = 0; l < usArray.GetLength(2); l++)
            {
                Console.WriteLine($"{usArray[j, k, l]} ({j},{k},{l})");
            }
        }
    }
}
int getNextNotExistNumberFrom3dArray(int[,,] usArray)
{
    int result = 0;
    while (result == 0)
    {
        result = new Random().Next(10, 100);
        for (int j = 0; j < usArray.GetLength(0); j++)
        {
            for (int k = 0; k < usArray.GetLength(1); k++)
            {
                for (int l = 0; l < usArray.GetLength(2); l++)
                {
                    if (result == usArray[j, k, l] | result == 0)
                    {
                        result=0;
                    }
                }
            }
        }
    }
    return result;
}
int[,,] Fill3DDataArray(int[,,] usArray)
{
    for (int j = 0; j < usArray.GetLength(0); j++)
    {
        for (int k = 0; k < usArray.GetLength(1); k++)
        {
            for (int l = 0; l < usArray.GetLength(2); l++)
            {
                usArray[j, k, l] = getNextNotExistNumberFrom3dArray(usArray);
            }
        }
    }
    return usArray;
}

int numX = getIntNumberFromUser("Введите значение по 1 измерению ");
int numY = getIntNumberFromUser("Введите значение по 2 измерению ");
int numZ = getIntNumberFromUser("Введите значение по 3 измерению ");
if (numX * numY * numZ > 90)
{
    Console.WriteLine($"При таком сочетании количества элементов измерений массив не может быть создан, так как количество его ячеек больше чем возмлжных значений");
}
else
{
    int[,,] userArray = create3DArray(numX, numY, numZ);
    userArray = Fill3DDataArray(userArray);
    Console.WriteLine("Массив");
    Print3DArray(userArray);
}
