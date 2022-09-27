/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер четверти плоскости, в которой находится эта точка.*/

int getQuarterByCoordinate(int coordinateX, int coordinateY)
{
    int result = 0;
    if (coordinateX > 0 & coordinateY > 0)
    {
        result = 1;
    }
    else if (coordinateX > 0 & coordinateY < 0)
    {
        result = 2;
    }
    else if (coordinateX < 0 & coordinateY < 0)
    {
        result = 3;
    }
    else
    {
        result = 4;
    }
    return(result);
}

int userCoordinateX =0;
int userCoordinateY=0;
Console.WriteLine("Введите координаты");
Console.Write("X:");
userCoordinateX=Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
userCoordinateY=Convert.ToInt32(Console.ReadLine());
int quarter=getQuarterByCoordinate(userCoordinateX,userCoordinateY);
Console.WriteLine($"Точка с коордитанами X:{userCoordinateX} Y:{userCoordinateY} находится в {quarter} четверти");