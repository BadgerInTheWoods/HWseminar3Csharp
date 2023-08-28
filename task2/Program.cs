// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("insert number");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 10)
{
    sum += number % 10;
    number = number / 10;

}

sum += number;

Console.WriteLine($"summary of digits in the number is {sum}");