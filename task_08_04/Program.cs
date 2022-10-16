﻿/* Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
//Метод создания одномерного возрастающего массива из не повторяющихся чисел:
int [] GetOneMeasureArray (int minValue, int length)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minValue;
        minValue++;
    }
    return array;
}
// Метод создания трёхмерного массива из не повторяющихся чисел:
int [,,] GetTripleArray(int depth, int rows, int columns)
{
    int arrayRandomIndex = 1;
    int [] oneArray = GetOneMeasureArray(-99, 199); //Создание одномерного массива двузначных чисел:
    int [,,] array = new int [depth, rows, columns];
    Random randomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    arrayRandomIndex = randomValue.Next(109, 198); //Положиетльные двузначные числа:
                    if (oneArray[arrayRandomIndex] == 0)
                    {
                        arrayRandomIndex = randomValue.Next(10, 89); //Отрицательные двузначные числа
                    }
                    if (array[i, j, k] == 0)
                    {
                        array[i, j, k] = oneArray[arrayRandomIndex]; //Значение рандомного индекса одномерного массива присваивается трёхмерному:
                        oneArray[arrayRandomIndex] = 0; //Обнуление значения индекса в одномерном массиве:
                        k = 0;
                        j = 0;
                        i = 0;
                    }
                }
            }
        }
    return array;
}
void Print3DArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("{0,6}", $"{array[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
int [,,] array = GetTripleArray(2,2,2);
Console.WriteLine();

Print3DArray(array);
Console.WriteLine();
