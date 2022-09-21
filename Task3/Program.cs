// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int x, int y)
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
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

double[] GetAverageInColumn(int[,] arr)
{
    double[] average = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++) // перебираем столбцы
    {
        for (int j = 0; j < arr.GetLength(0); j++) // перебираем строки
        {
            double sum = 0;
            average[i] = average[i] + arr[j, i];  // находим  сумму в столбце и вносим значение в нов массив
        }
        average[i] = Math.Round((average[i] / arr.GetLength(0)), 2); //находим среднее ариф, округляем и заносим в массив
    }
    return average;
}

void PrintResult(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

Console.WriteLine("Введите количество строк: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Вывод массива: ");
int[,] array = FillArray(x, y);
PrintArray(array);

Console.WriteLine("Массив из сред ариф элементов в каждом столбце: ");
double[] result = GetAverageInColumn(array);
PrintResult(result);


