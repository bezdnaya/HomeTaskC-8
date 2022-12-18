// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int [,] arrayA = new int [3, 3];
int [,] arrayB = new int [3, 3];
int [,] arrayC = new int [3, 3];
FillArray(arrayA);
FillArray(arrayB);
int Sum = 0;
int index = 0;
for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
        while (index < arrayA.GetLength(0))
        {
            Sum = Sum + arrayA[i, index]*arrayB[index, j];
            index++;
        }
        arrayC[i,j] = Sum;
        Sum = 0;
        index = 0;
    }
}
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(arrayC);
