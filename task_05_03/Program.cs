/* Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Пример [3 7 22 2 78] -> 76
*/
Console.Write("Введите количество элементов одномерного массива:\t");
int elementsArr = Convert.ToInt32(Console.ReadLine());
double [] arr1 = new double[elementsArr];
int i = 0;
for (i = 0; i < arr1.Length; i++)
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
double maxValue = arr1.Max<double>();
double minValue = arr1.Min<double>();
double result = maxValue - minValue;
Console.Write($"  ->  {result}");
