/* Задача 50. 
Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
 1 4 7 2
[4][5][6][7]
 5 9 2 3
[8][9][10][11]
 8 4 2 4
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
void FindElement(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (element == array[i, j])
            {
                Console.WriteLine($"Позиция элемента со значением {element} - [{i}, {j}]");
                return;
            }                  
        }
    }
    Console.WriteLine("Такого элемента нет в массиве");
}
void FindIndex(int[,] array, int index)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (index == count)
            {
                Console.WriteLine($"Элемент массива с индексом {index} -> {array[i, j]}");
                return;
            }   
            count++;               
        }
    }
    Console.WriteLine("Такого элемента нет в массиве");
}
Console.Write("Введите число которое необходимо найти в массиве ");
int ElementToFind = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс числа которое необходимо найти в массиве ");
int ElementToIndex = Convert.ToInt32(Console.ReadLine());
int randomNumberOfRows = new Random().Next(1, 10 + 1);
int randomNumberOfColumns = new Random().Next(1, 10 + 1);
int[,] generatedArray = generate2DArray(randomNumberOfRows, randomNumberOfColumns, 1, 20);
print2DArray(generatedArray);
Console.WriteLine();
FindElement(generatedArray, ElementToFind);
FindIndex(generatedArray, ElementToIndex);
