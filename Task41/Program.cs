/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

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

int[] createArray(int userNum)
{
    int[] userAr = new int[userNum];
    return userAr;
}

int getCountOverZeroFromArray(int[] inArray)
{
    int result=0;
    for(int i=0;i<inArray.Length;i++)
    {
        if(inArray[i]>0)
        {
            result=result+1;
        }
    }
    return result;
}
int userNumber = getIntNumberFromUser("Введите число элементов в массиве: ");
int[] inArray = createArray(userNumber);
for(int i=0;i<inArray.Length;i++)
{
    inArray[i]=getIntNumberFromUser("Введите число: ");
}
Console.WriteLine($"Число значений больше 0 введенных с клавиатуры составляет {getCountOverZeroFromArray(inArray)}");
