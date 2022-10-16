/* Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
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
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] resultSumArray(int[,] array1, int[,] array2)
{
int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            resultArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
} return resultArray;
}
Console.Clear();
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц..");
Console.WriteLine();
int randomNumberOfColumnsAndRows = new Random().Next(2, 5);
int randomNumberOfRows = new Random().Next(2, 5);
int randomNumberOfColumns = new Random().Next(2, 5);
Console.WriteLine($"Вывод первой случайно сгенерированной матрицы {randomNumberOfRows} X {randomNumberOfColumnsAndRows}");
Console.WriteLine();
int[,] generatedArray1 = generate2DArray(randomNumberOfRows, randomNumberOfColumnsAndRows, 1, 9);
print2DArray(generatedArray1);
Console.WriteLine();
Console.WriteLine($"Вывод второй случайно сгенерированной матрицы {randomNumberOfColumnsAndRows} X {randomNumberOfColumns}");
Console.WriteLine();
int[,] generatedArray2 = generate2DArray(randomNumberOfColumnsAndRows, randomNumberOfColumns, 1, 9);
print2DArray(generatedArray2);
Console.WriteLine();
Console.WriteLine($"Вывод произведения двух матриц {randomNumberOfRows} X {randomNumberOfColumns}");
Console.WriteLine();
int[,] resultArray = resultSumArray(generatedArray1, generatedArray2);
print2DArray(resultArray);
