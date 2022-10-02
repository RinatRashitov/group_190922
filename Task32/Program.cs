/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
int[] getSetPlusMinusArray(int[] inArray)
{
    int count = inArray.Length; 
    int[] result= new int[inArray.Length];
    for(int i=0;i<inArray.Length;i++)
    {
        result[i]=inArray[i]*-1;
    }
    return result;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0;i < array.Length-1;i++)
    {
         Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}


int[] userArray= new int[] {-4, -8, 8, 2};
//int[] itogArray=new int[inArray.Length];
int[] itogArray=getSetPlusMinusArray(userArray);
PrintArray(itogArray);


