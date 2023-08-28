// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double expon()
{
    Console.WriteLine("insert int number A");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("insert int number B");
    int B = Convert.ToInt32(Console.ReadLine());
    double result = Math.Pow(A,B);
    return result;
}

Console.Write(expon());