/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Пример1 2, 3, 7 -> 7
Пример2 44 5 78 -> 78
Пример3 22 3 9 -> 22
*/
Console.WriteLine();
Console.WriteLine("Решение для поиска максимального числа из трех целых чисел введенных с клавиатуры");
Console.WriteLine();
Console.Write("Введите первое число\t");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число\t");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число\t");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
int [] arr = {userNumber1,userNumber2,userNumber3,};
int maxValue = arr.Max<int>();
Console.WriteLine($"Максимальное из этих трех чисел {maxValue}");

//Общее решение для поиска максимального числа из любого набора целых чисел введенных с клавиатуры

Console.WriteLine();
Console.WriteLine("Общее решение для поиска максимального целого числа");
Console.WriteLine();
Console.Write("Введите количество чисел для сравнения:\t");
int elementsArr = Convert.ToInt32(Console.ReadLine());
int [] arr1 = new int[elementsArr];
int i = 0;
for (i = 0; i < arr1.Length; i++)
{
      Console.Write($"Введите число {i + 1}:\t"); 
      arr1[i] = Convert.ToInt32(Console.ReadLine()); 
}
int maxValue1 = arr1.Max<int>();
Console.Write($"Ответ: {maxValue1} максимальное из этих {i} чисел");
