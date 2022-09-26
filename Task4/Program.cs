/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да
*/

int getReminderFromDigital(int number, int divider)
{
    return (number % divider);
}

Console.WriteLine("Введите число:");
int userNumber = 0;
userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Делитель А:");
int dividerA = 0;
dividerA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Делитель Б:");
int dividerB = 0;
dividerB = Convert.ToInt32(Console.ReadLine());
if(getReminderFromDigital(userNumber, dividerA)==0 & getReminderFromDigital(userNumber, dividerB)==0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}