/* Задача 56:
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
void SearchArrayRowsMinimalSum (int [,] array)
{
    int sumFirstString = 0;
    int sumSecondString = 0;
    int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumFirstString = sumFirstString + array[i, j];
            }

            if (sumSecondString == 0)
            {
                sumSecondString = sumFirstString;
            }

            if (sumFirstString < sumSecondString)
            {
                sumSecondString = sumFirstString;
                count = i;
            }
            Console.WriteLine($"Сумма {i} строки {sumFirstString}");
            sumFirstString = 0;
        }
    Console.WriteLine();
    Console.WriteLine($"Строка массива с наименьшей суммой элементов -> {count}");
}

Console.Clear();
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine();
int randomNumberOfRows = new Random().Next(3, 10);
int randomNumberOfColumns = new Random().Next(3, 10);
Console.WriteLine($"Вывод случайно сгенерированного массива {randomNumberOfRows} X {randomNumberOfColumns}");
Console.WriteLine();
int[,] generatedArray = generate2DArray(randomNumberOfRows, randomNumberOfColumns, 1, 20);
print2DArray(generatedArray);
Console.WriteLine();
SearchArrayRowsMinimalSum(generatedArray);
Console.WriteLine();
