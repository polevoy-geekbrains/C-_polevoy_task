/* Задача 64: 
Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void PrintNumbers(int N)
{
    if (N > 0)
    {
        Console.Write($"{N}, ");
        PrintNumbers(N - 1);
    }
}
// Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа"); 
Console.WriteLine("в промежутке от N до 1. Выполнить с помощью рекурсии.");
Console.WriteLine();
Console.Write("Введите число N \t");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {userNumber}  ->  ");
PrintNumbers(userNumber);
