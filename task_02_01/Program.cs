/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Примеры: 456 -> 5   782 -> 8    918 -> 1
*/
Console.WriteLine();
Link1:
Console.Write("Введите трехзначное число\t");
int userNumber = Convert.ToInt32(Console.ReadLine());
//Проверка действительно ли введенное число является трехзначным.
if (userNumber > 999 || userNumber < 100)
{
    Console.WriteLine("Введенное число не является трехзначным. Попробуйте еще раз.");
    goto Link1; //Знаю, что операторы перехода считаются "некрасивым решением",
    // но не понимаю как оптимально реализовать возврат к более раннему коду.
}
int secondNumber = ((userNumber/10)%10);
Console.Write($"{secondNumber}");
