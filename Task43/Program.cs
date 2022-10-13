/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double getDoubleNumberFromUser(string userInformation)
{
    double result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите число, Вы ввели: {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

double numberB1=getDoubleNumberFromUser("Введите значение B1: ");
double numberK1=getDoubleNumberFromUser("Введите значение K1: ");
double numberB2=getDoubleNumberFromUser("Введите значение B2: ");
double numberK2=getDoubleNumberFromUser("Введите значение K2: ");

double numberX=(numberB2-numberB1)/(numberK1-numberK2);
double numberY=numberK1*numberX+numberB1;

Console.WriteLine($"Для значений коэффициентов K1={numberK1} B1={numberB1} K2={numberK2} B2={numberB2} X={numberX} Y={numberY}");