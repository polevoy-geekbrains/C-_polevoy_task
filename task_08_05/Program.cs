/* Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
//int n = 4;

int[,] generateSquareArray(int dimensionOfSquareArray)
{
int count = 1;
int[,] twoDArray = new int[dimensionOfSquareArray, dimensionOfSquareArray];
int i = 0;
int j = 0;

while (count <= twoDArray.GetLength(0) * twoDArray.GetLength(1))
{
  twoDArray[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < twoDArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= twoDArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > twoDArray.GetLength(1) - 1)
    j--;
  else
    i--;
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
            if (arrayToPrint[i,j] < 10)
            Console.Write("0" + arrayToPrint[i,j] + "\t");
            else
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
Console.WriteLine();
int dimensionOfSquareArray = 4; 
Console.WriteLine($"Вывод массива {dimensionOfSquareArray} Х {dimensionOfSquareArray} заполненного змейкой");
Console.WriteLine();
int[,] generateArray = generateSquareArray(dimensionOfSquareArray);
print2DArray(generateArray);
Console.WriteLine();
