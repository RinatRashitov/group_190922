/*18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)*/

Console.WriteLine("Введите номер четверти:");
int userQuarter = 0;
while (userQuarter == 0 | userQuarter < 1 ^ userQuarter > 4)
{
    string userLine = Console.ReadLine();
    int.TryParse(userLine, out userQuarter);
    if (userQuarter == 0 | userQuarter < 1 | userQuarter > 4)
    {
        Console.WriteLine($"Введите правильно значение квартала, целое число от 1 до 4, вы ввели {userLine}");
    }
}

if(userQuarter==1) 
{
    Console.WriteLine($"Для квартала {userQuarter} возможные координаты x>0, y>0");
}
else if(userQuarter==2) 
{
    Console.WriteLine($"Для квартала {userQuarter} возможные координаты x<0, y>0");
}
else if(userQuarter==3) 
{
    Console.WriteLine($"Для квартала {userQuarter} возможные координаты x<0, y<0");
}
else if(userQuarter==4) 
{
    Console.WriteLine($"Для квартала {userQuarter} возможные координаты x>0, y<0");
}