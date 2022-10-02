/* Задача 37(сложная необязательная):
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
второй и предпоследний и т.д. Результат запишите в новом массиве.
Пример: [1 2 3 4 5] -> 5 8 3    [6 7 3 6] -> 36 21
*/

Console.Write("Введите количество элементов одномерного массива:\t");
int elementsArr = Convert.ToInt32(Console.ReadLine());
double [] arr1 = new double[elementsArr];
    for (int i = 0; i < arr1.Length; i++)
    {
      Console.Write($"Введите элемент массива с индексом {i}:\t"); 
      arr1[i] = Convert.ToDouble(Console.ReadLine()); 
    }
void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.Write("]");
}
printArray(arr1);
Console.Write("  ->  ");
int j = 0;
int count = elementsArr - 1;
if (elementsArr % 2 == 0)
{
    double [] arr2 = new double[elementsArr / 2];
    for (j = 0; j < (arr1.Length / 2); j++)
    {
        arr2[j] = arr1[j] * arr1[count];
        count = count - 1;
    }
    printArray(arr2);
}
else
{
    double [] arr2 = new double[(elementsArr / 2) + 1];
    for (j = 0; j < ((arr1.Length+1) / 2); j++)
    {
        arr2[j] = arr1[j] * arr1[count];
        
        if (j == count)
        {
            arr2[j] = arr1[j];
        }
        count = count - 1;
    }
    printArray(arr2);
}
