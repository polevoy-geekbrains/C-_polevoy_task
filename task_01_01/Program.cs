/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Пример1 a = 5; b = 7 -> max = 7 Пример2 a = 2 b = 10 -> max = 10 Пример3 a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое значение");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 < userNumber2)
{
    Console.WriteLine($"Число {userNumber1} меньше числа {userNumber2}");
}
else if (userNumber1 > userNumber2)
{
    Console.WriteLine($"Число {userNumber1} больше числа {userNumber2}");
}
else
{
    Console.WriteLine($"Число {userNumber1} равно числу {userNumber1}");
}