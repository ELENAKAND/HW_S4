/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine("Введите корректное число");
        }
    }
    return result;
}
int DigitsSum(int number)
{
    int sum = 0;
    for (int i = 0; number > 0; i++)
    {
        sum += number%10;
        number = number/10;
    }                 
    return sum;
 
}
int number = GetNumber("Введите число"); 
Console.WriteLine("Сумма цифр числа " + number + " = " + DigitsSum(number));







