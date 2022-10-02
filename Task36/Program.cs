/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


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

int getEvenOddSumFromArray(int[] usArray, int numEvent)
{
    int result = 0;
    for (int j = 0+numEvent; j < usArray.Length; j=j+2)
    {
        result = result + usArray[j];
        //Console.Write(j);
        //Console.Write(" ");
        //Console.WriteLine(usArray[j]);
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
Console.WriteLine("Введите поиск суммы четных (1) или нечетных (0) позиций элементов: ");
int nEvent = Convert.ToInt32(Console.ReadLine());
int sumEvenOdd=getEvenOddSumFromArray(userArray, nEvent);
if(nEvent==1)
{
    Console.WriteLine($"Сумма элементов стоящий на четных позициях {sumEvenOdd}");
}
else if(nEvent==0)
{
    Console.WriteLine($"Сумма элементов стоящий на четных позициях {sumEvenOdd}");
}

