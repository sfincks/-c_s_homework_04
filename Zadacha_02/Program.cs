//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string? getNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}

string? number = getNumber("Введите число");

int sumOfNumbers(string number)
{
    int result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        result = result + Convert.ToInt32(Convert.ToString(number[i]));
        // System.Console.WriteLine(result);
    }
    return result;
}

System.Console.WriteLine(sumOfNumbers(number));