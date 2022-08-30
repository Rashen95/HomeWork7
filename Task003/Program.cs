// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] NewArray(int line, int column)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanOfAColumn(int[,] array)
{
    decimal sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"Среднее арифметическое {j + 1} столбца = {Math.Round(sum / array.GetLength(0), 1)}");
        Console.WriteLine();
        sum = 0;
    }
}

Console.Clear();
Console.Write("Введите количество строк и столбцов двумерного массива а я выведу среднее арифметическое элементов каждого столбца");
Console.WriteLine();
Console.WriteLine();
Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = NewArray(n, m);
Console.WriteLine("Полученный массив");
ShowArray(array);
Console.WriteLine();
ArithmeticMeanOfAColumn(array);
Console.WriteLine();