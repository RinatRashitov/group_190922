/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToInt32(Math.Ceiling(Math.Log10(userNumber)));
//Console.WriteLine(count);
if (count != 5)
{
    Console.WriteLine("Вы ввели не 5 значное число. Работа программы прекращена.");
    return;
}

//Console.WriteLine(userNumber / Convert.ToInt32(Math.Pow(10, 4)));
int i = 0;
int numDigital = count;
for (i = 0; i < count / 2 - count % 2 + 1; i++)
{
    if (numDigital != 0 && userNumber % 10 == userNumber / Convert.ToInt32(Math.Pow(10, numDigital - 1)))
    {
        //Console.WriteLine($"Цифра {i + 1} {userNumber % 10}");
        //Console.WriteLine($"Цифра {numDigital} {userNumber / Convert.ToInt32(Math.Pow(10, numDigital - 1))}");
        //Console.WriteLine($"Цифра {i + 1} и {numDigital} нормально");
        userNumber = (userNumber % Convert.ToInt32(Math.Pow(10, numDigital - 1))) / 10;
        //Console.WriteLine(userNumber);
        numDigital = numDigital - 2;
    }
    else
    {
        break;
    }
}
if(numDigital<2)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}
