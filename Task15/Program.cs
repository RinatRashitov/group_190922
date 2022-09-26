/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
string chekWeekend(int number)
{
    if(number>0 & number<6)
    {
        return("нет");
    }
    else if(number>5&number<8)
    {
        return("да");
    }
    else
    {
        return("не день недели");
    }
}
Console.WriteLine("Введите день недели:");
int userNumber = 0;
userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(chekWeekend(userNumber));