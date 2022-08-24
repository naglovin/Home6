﻿///// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 1, -7, 567, 89, 223-> 3
Console.WriteLine("Количество цифер: ");
int a = Convert.ToInt32(Console.ReadLine());
int [] MassiveNumbers = new int [a];
void InputNumbers(int a)
{
    for (int i = 0; i < a; i++)
    {
        Console.Write($"Введи {i+1} число: ");
         MassiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Comparison(int[] MassiveNumbers)
{
  int count = 0;
  for (int i = 0; i < MassiveNumbers.Length; i++)
  {
    if(MassiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(a);

Console.WriteLine($"Введено чисел больше 0: {Comparison(MassiveNumbers)} ");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

