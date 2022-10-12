/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/
int convertDecimalToBinary(int userDigital, int userPosition)
{
     return userDigital * Convert.ToInt32(Math.Pow(10, userPosition));    
}

int userDecimalNumber = 2;
int userNumb=userDecimalNumber;
int userBinaryNumber = 0;
int count = 0;
while (userNumb > 0)
{
    userBinaryNumber = userBinaryNumber + convertDecimalToBinary(userNumb % 2, count);
    count = count + 1;
    userNumb = Convert.ToInt32(Math.Floor(userNumb / 2.0));
}
Console.WriteLine($"Десятичное число {userDecimalNumber} равно двоичному числу {userBinaryNumber}");