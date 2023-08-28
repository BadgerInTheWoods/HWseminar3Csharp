// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

void Fillar(int[] arr)
{
    var Rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("insert next number of an array");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printar(int[] arr)
{
    int i = 0;
    while(i < arr.Length){
        Console.Write($"{arr[i]}, ");
        i++;
    }
}


Fillar(array);
printar(array);