/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int powNumber(int numA, int numB)
{
    return Convert.ToInt32(Math.Pow(numA, numB));
}

Console.WriteLine("Введите чило для возведения в степень: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numPow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {userNumber} в степени {numPow} равно {powNumber(userNumber, numPow)}");