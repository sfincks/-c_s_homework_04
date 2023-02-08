//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber (string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int firstNumber = GetNumber("Введите первое число");
int secondNumber = GetNumber("Введите второе число");

int PowerOfNumber (int number,int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result = result*number;
    }
    return result;
}

// System.Console.WriteLine(Math.Pow(firstNumber,secondNumber));
System.Console.WriteLine(PowerOfNumber(firstNumber,secondNumber));

