// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
WriteLine();
Console.WriteLine("Введите размерность матрицы:");
int num = Convert.ToInt32(ReadLine());
int[,] arrr = new int[num, num];
FilArray(arrr);
PrintArray(arrr);
int[,] arrr2 = new int[num, num];
FilArray(arrr2);
PrintArray(arrr2);
int[,] result = new int[num, num];
result = DoArray(arrr, arrr2);
PrintArray(result);
WriteLine();

void FilArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) ar[i, j] = new Random().Next(1, 9);
    }
}


void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) Write(ar[i, j] + " ");
        WriteLine();
    }
    WriteLine();
}


int[,] DoArray(int[,] ar1, int[,] ar2)
{
    int[,] res = new int[ar1.GetLength(0), ar1.GetLength(0)];
    for (int i = 0; i < ar1.GetLength(0); i++)
    {
        for (int j = 0; j < ar1.GetLength(0); j++)
        {
            int sum = 0;
            for (int k = 0; k < ar1.GetLength(0); k++)
            {
                sum = sum + ar1[i, k] * ar2[k, j];
            }
            res[i, j] = sum;
        }

    }
    return res;
}