/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int getCoorditateFromUser(string userInformation)
{
    int result = 0;
    string userLine = "";
    while (result == 0 & userLine != "0")
    {
        Console.Write(userInformation);
        userLine = (Console.ReadLine());
        int.TryParse(userLine, out result);
        if (result == 0 & userLine != "0")
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
    }
    return (result);
}

double getDistance(int AX, int AY, int AZ, int BX, int BY, int BZ)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((AX - BX), 2) + Math.Pow((AY - BY),2) + Math.Pow((AZ - BZ), 2));
    return (result);
}
int coordinateAX = getCoorditateFromUser("Введите координату х для точки A ");
int coordinateAY = getCoorditateFromUser("Введите координату y для точки A ");
int coordinateAZ = getCoorditateFromUser("Введите координату z для точки A ");
int coordinateBX = getCoorditateFromUser("Введите координату х для точки B ");
int coordinateBY = getCoorditateFromUser("Введите координату y для точки B ");
int coordinateBZ = getCoorditateFromUser("Введите координату z для точки B ");

double distance = Math.Round(getDistance(coordinateAX, coordinateAY, coordinateAZ, coordinateBX, coordinateBY, coordinateBZ), 2);
Console.WriteLine($"Расстояние между точками A и B с координатами ({coordinateAX},{coordinateAY}), ({coordinateAY},{coordinateBY}) составляет {distance}");
