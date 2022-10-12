/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int getNextFibonacci (int firstNumber, int secondNumber)
{
    return firstNumber+secondNumber;
}

Console.WriteLine("Введите число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"Последовательность чисел Фиббоначи для {userNumber} равно 0, 1");
int numOne=0;
int numTwo=1;
int count=3;
while(count<=userNumber)
{
    int numThree=getNextFibonacci(numOne, numTwo);
    Console.Write($", {numThree}");
    numOne=numTwo;
    numTwo= numThree;
    count=count+1;
}