﻿Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + num + " четное!");
   
}
else
{
    Console.WriteLine("Число " + num + " нечетное!");
    
}