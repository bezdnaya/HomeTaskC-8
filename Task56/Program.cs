// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void FillArray (int[,] col)
{
     for (int i = 0; i < col.GetLength(0); i++)
     {
        for (int j = 0; j < col.GetLength(1); j++)
        col[i, j] = new Random().Next(1, 10);
     }
}
void PrintArray (int[,] collection)
{
    for (int k = 0; k < collection.GetLength(0); k++)
    {
        for (int l = 0; l < collection.GetLength(1); l++)
        {
            Console.Write($"{collection[k, l]} ");
        }
    Console.WriteLine();
    }
}
int [,] array = new int [6, 3];
FillArray(array);
int Sum = 0;
int row = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    Sum += array [0, i];
}
int min = Sum;
for (int j = 1; j < array.GetLength(0); j++)
{
    Sum = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        Sum += array[j, k];
    }
    if (Sum < min)
    {
        min = Sum;
        row = j;
    }
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row}");
