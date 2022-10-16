/* Задача 66: 
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SumFromMToN(int M, int N)
{
    int sum = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        sum = M + SumFromMToN(M, N);
        return sum;
    }
}
Console.WriteLine();
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();
Console.Write("Введите число M \t");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N \t");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"M = {M}; N = {N}. -> {SumFromMToN(M - 1, N)}");
