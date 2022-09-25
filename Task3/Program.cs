/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Е
сли число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно*/

string getMultipayNumber (int num1, int num2)
{
    int remainNumber = 0;
    string result="";
    remainNumber = num2%num1;
    if(remainNumber==0)
    {
        result="кратно";
    }
    else
    {
        result="Не кратно, остаток от деления "+Convert.ToString(remainNumber);
    }
    return result;
}
Console.WriteLine("Введите число 1:");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int number2 =Convert.ToInt32(Console.ReadLine());
string res=getMultipayNumber(number1, number2);
Console.WriteLine(res);