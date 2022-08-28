﻿// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// Console.Clear();
// Console.WriteLine("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = 0;
// double y = 0;

// if (k1 == k2 && b1 == b2)
// {
//     Console.WriteLine("Прямые совпадают");
// }
// else if (k1 == k2)
// {
//     Console.WriteLine("Прямые параллельны");
// }
// else
// {
//     x = (b2-b1/(k1-k2));
//     y = k1 * x + b1;
// }

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
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

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);