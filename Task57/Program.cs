/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается 
элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/

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
int[,] create2DArray(int userNumX, int userNumY)
{
    int[,] userAr = new int[userNumX, userNumY];
    return userAr;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void Print2DArray(int[,] usArray)
{
    Console.Write(" \t");
    for (int j = 0; j < usArray.GetLength(1); j++)
    {
        printColorData(j + "\t");
    }
    Console.WriteLine();
    for (int j = 0; j < usArray.GetLength(0); j++)
    {
        printColorData(j + "\t");
        for (int k = 0; k < usArray.GetLength(1); k++)
        {
            Console.Write($"{usArray[j, k]}" + "\t");
        }
        Console.WriteLine("");
    }
}
int[,] Fill2DDataArray(int[,] usArray, int numFrom, int numTo)
{
    for (int j = 0; j < usArray.GetLength(0); j++)
    {
        for (int k = 0; k < usArray.GetLength(1); k++)
        {
            usArray[j, k] = new Random().Next(numFrom, numTo);
        }
    }
    return usArray;
}
int getMaxFromArray(int[,] usArray)
{
    int maxNumb = usArray[0, 0];
    for (int i = 0; i < usArray.GetLength(0); i++)
    {
        for (int j = 0; j < usArray.GetLength(1); j++)
        {
            if (maxNumb < usArray[i, j])
            {
                maxNumb = usArray[i, j];
            }
        }
    }
    return maxNumb;
}
int getMinFromArray(int[,] usArray)
{
    int minNumb = usArray[0, 0];
    for (int i = 0; i < usArray.GetLength(0); i++)
    {
        for (int j = 0; j < usArray.GetLength(1); j++)
        {
            if (minNumb > usArray[i, j])
            {
                minNumb = usArray[i, j];
            }
        }
    }
    return minNumb;
}
int[,] getCountNumberFromArray(int[,] cArray, int[,] usArray)
{
    int count = getMinFromArray(usArray);
    int countNum = 0;
    for (int k = 0; k < getMaxFromArray(usArray) - getMinFromArray(usArray) + 1; k++)// k = getMinFromArray(usArray); k <= getMaxFromArray(usArray); k++)
    {
        for (int i = 0; i < usArray.GetLength(0); i++)
        {
            for (int j = 0; j < usArray.GetLength(1); j++)
            {
                if (count == usArray[i, j])
                {
                    countNum = countNum + 1;
                }
            }
        }
        cArray[k, 0] = count;
        cArray[k, 1] = countNum;
        count = count + 1;
        countNum = 0;
    }
    return cArray;
}

string printCountName(int count)
{
    string result = "";
    if (Math.Abs(count) == 2 | Math.Abs(count) == 3 | Math.Abs(count) == 4)
    {
        result = "раза";
    }
    else
    {
        result = "раз";
    }
    return result;
}
void printFrequencyArray(int[,] frequencyArray)
{
    Console.WriteLine("Частотный массив");
    int sum=0;
    for (int i = 0; i < frequencyArray.GetLength(0); i++)
    {
        if (frequencyArray[i, 1] > 0) Console.WriteLine($"Число {frequencyArray[i, 0]} встречается {frequencyArray[i, 1]} {printCountName(frequencyArray[i, 1])}");
        sum=sum+frequencyArray[i, 1];
    }
    Console.WriteLine($"Итого {sum} {printCountName(sum)}");
}

int numX = getIntNumberFromUser("Введите значение по вертикали ");
int numY = getIntNumberFromUser("Введите значение по горизонтали ");
int numFrom = getIntNumberFromUser("Введите минимальное значение элемента: ");
int numTo = getIntNumberFromUser("Введите максимальное значение элемента: ");
int[,] userArray = create2DArray(numX, numY);
userArray = Fill2DDataArray(userArray, numFrom, numTo + 1);
Console.WriteLine("Массив");
Print2DArray(userArray);

int[,] countArray = create2DArray(getMaxFromArray(userArray) - getMinFromArray(userArray) + 1, 2);

countArray = getCountNumberFromArray(countArray, userArray);
printFrequencyArray(countArray);



