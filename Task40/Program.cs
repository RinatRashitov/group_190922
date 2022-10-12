/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

int enterSideOfTriangle(string text)
{
    Console.WriteLine($"Введите длину стороны трехугольника {text}: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

bool canExistTriangle(int sideLenght1, int sideLenght2, int sideLenght3)
{
    return sideLenght1 < sideLenght2 + sideLenght3;
}

int lenghtSideOfTriangleA = enterSideOfTriangle("A");
int lenghtSideOfTriangleB = enterSideOfTriangle("B");
int lenghtSideOfTriangleC = enterSideOfTriangle("C");

Console.Write($"Трехугольник со сторонами A={lenghtSideOfTriangleA}, B={lenghtSideOfTriangleB}, C={lenghtSideOfTriangleC}");
if (canExistTriangle(lenghtSideOfTriangleA, lenghtSideOfTriangleB, lenghtSideOfTriangleC) 
     && canExistTriangle(lenghtSideOfTriangleB, lenghtSideOfTriangleA, lenghtSideOfTriangleC) 
     && canExistTriangle(lenghtSideOfTriangleC, lenghtSideOfTriangleA, lenghtSideOfTriangleB))
{
    Console.Write(" существует");
}
else
{
    Console.Write(" не существует");
}
