﻿/* Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double [,] generate2DArray(int height,int width, double randomStart, double randomEnd)
{
    double [,] twoDArray = new double[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = Math.Round((new Random().Next(-99, 99) / 10.0), 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(double [,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк в массиве (параметр m) \t");
int mUserNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве (параметр n) \t");
int nUserNumber = Convert.ToInt32(Console.ReadLine());
double [,] generatedArray = generate2DArray(mUserNumber,nUserNumber, -11.0, 11.0);
print2DArray(generatedArray);
