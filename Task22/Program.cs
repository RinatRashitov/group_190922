/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4*/

Console.WriteLine("Введите число ");
int userNumber = 0;
string result = "1";
int i = 0;
userNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[userNumber];
array[0]=1;
// эта строка сделана для варианта задачи, когда и для отрицательных N нужно решение
// в задаче просто не указано могу ли N быть отрицательными
//userNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for (i = 0; i < userNumber; i++)
{
    array[i] = Convert.ToInt32(Math.Pow(i+1, 2));
    //result = result+", "+Math.Pow(i,2);
}
//Console.WriteLine(result);
i = 0;
for (i = 0; i < userNumber; i++)
{
    Console.Write(array[i] + ", ");
}