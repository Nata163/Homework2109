//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray()
{
    int[,] arr = new int[10, 8];
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            arr[i, j] = new Random().Next(1, 100);
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

void FindElementValue(int[,] arr, int x, int y)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                Console.WriteLine($"Значение элемента на позиции ({x},{y}) равно {arr[i, j]}");
            }
        }
    }
}

void NoElement(int[,] arr, int x, int y)
{
    if ((x >= arr.GetLength(0)) || (y >= arr.GetLength(1)))
    {
        Console.WriteLine("Такого элемента нет");
    }
}

Console.WriteLine("Введите номер строки: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int y = int.Parse(Console.ReadLine());

int[,] array = FillArray();
PrintArray(array);
FindElementValue(array, x, y);
NoElement(array, x, y);
