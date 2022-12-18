// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int [,] array = new int [3, 4];
FillArray(array);
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    int index = 0;
    int max = 0;
    while (index < array.GetLength(1))
    {
        max = array[i, index];
        int maxpos = index;
        for (int j = index+1; j < array.GetLength(1); j++)
        {
            if (array[i,j] > max)
            {
                max = array[i, j];
                maxpos = j;
            }
        }
        int help = array[i, index];
        array [i, index] = max;
        array [i, maxpos] = help;
        index++;
        
    }
}
Console.WriteLine();
PrintArray(array);

