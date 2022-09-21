// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(int x, int y) 
{
    double[,] arr = new double[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = Convert.ToDouble((new Random().Next(-100, 100)) / 10.0);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк(M):");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк(N):");
int n = int.Parse(Console.ReadLine());

double[,] array = FillArray(m, n);
PrintArray(array);