/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void FillArray(int[]array)
{
    Random rnd = new Random();
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index ++)
    {
        array [index] = rnd.Next(1,100);
    }
}
void PrintArray(int[]array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index ++)
    {
        Console.WriteLine(array [index]);
    }
}
int [] array = new int [8];
FillArray(array);
PrintArray(array);