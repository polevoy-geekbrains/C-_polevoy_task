/* Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double[,] coeff = new double[2, 2];
double[] IntersectionPoint = new double[2];

void InputValues(){
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Solution(double[,] coeff)
{
  IntersectionPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  IntersectionPoint[1] = IntersectionPoint[0] * coeff[0,0] + coeff[0,1];
  return IntersectionPoint;
}

void OutputSolution(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Solution(coeff);
    Console.Write($"Точка пересечения прямых: ({IntersectionPoint[0]}, {IntersectionPoint[1]})");
  }
}

InputValues();
OutputSolution(coeff);
