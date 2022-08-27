// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет (Пример не соответствует заданию)

Console.Clear();
int[,] array = new int[4, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите позицию элемента массива, а я выведу ее на экран");
Console.WriteLine();
Console.Write("Введите строку массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= array.GetLength(0) || n >= array.GetLength(1))
{
    Console.Write("Такого элемента в системе нет");
}
else
{
    Console.Write($"{array[m, n]}");
}