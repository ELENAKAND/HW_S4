/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
  int result = 0;
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
void GetPow(int number1, int number2)
{
    Console.WriteLine(Math.Pow(number1, number2));
}
int number1 = GetNumber("Введите первое число");
int number2 = GetNumber("Введите второе число");
GetPow(number1, number2);
