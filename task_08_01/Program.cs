/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int [,] sortArrayRows(int [,] array)
{
    int temp = 0; 
    for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        if (array[k,i] < array[k,j])
                        {    
                            temp = array[k,j];
                            array[k,j] = array[k,i];
                            array[k,i] = temp;
                        }
                    }
                }
            }
        
        }
    return array;
}

Console.Clear();
Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine();
int randomNumberOfRows = new Random().Next(3, 10);
int randomNumberOfColumns = new Random().Next(3, 10);
Console.WriteLine($"Вывод случайно сгенерированного массива {randomNumberOfRows} X {randomNumberOfColumns}");
Console.WriteLine();
int[,] generatedArray = generate2DArray(randomNumberOfRows, randomNumberOfColumns, 1, 20);
print2DArray(generatedArray);
Console.WriteLine();
Console.WriteLine("Вывод отсортированного массива с элементами упорядоченными по убыванию");
Console.WriteLine();
int[,] sortArray = sortArrayRows(generatedArray);
print2DArray(sortArray);
Console.WriteLine();
