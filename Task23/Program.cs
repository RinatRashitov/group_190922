/*ЗЗадача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число ");
int userNumber = 0;
string result = "1";
int i = 0;
userNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[userNumber];
for (i = 0; i < userNumber; i++)
{
    array[i] = Convert.ToInt32(Math.Pow(i+1, 3));
    //result = result+", "+Math.Pow(i,2);
}
//Console.WriteLine(result);
i = 0;
for (i = 0; i < userNumber; i++)
{
    Console.Write(array[i] + ", ");
}