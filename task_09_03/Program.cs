/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}
Console.WriteLine();
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine();
Console.Write("Введите начальное число m: \t");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число n: \t");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Функция Аккермана для чисел ({numberM} и {numberN}) = {AckermannFunction(numberM, numberN)}");
