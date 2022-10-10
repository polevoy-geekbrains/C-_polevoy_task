/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/ 

int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше нуля. {userInformation} ");
    }
    return result;
}

int countPositiveNumbers(int userNumber)
{
int count = 0;
for (int i = 0; i < userNumber; i++)
   {
    Console.Write($"Введите число {i + 1}:\t");
    int userNumber1 = Convert.ToInt32(Console.ReadLine());
    if (userNumber1 > 0)
            count++;
   }
return count;
}
int tempNumber = getNumberFromUser("Введите количество вводимых чисел:\t");
int userNumber = countPositiveNumbers(tempNumber);
Console.Write($"Положительных чисел: {userNumber}");
