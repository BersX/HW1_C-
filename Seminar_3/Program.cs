﻿// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X не=0 и Y не=0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.


// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (X>0 && Y>0)
// {
//     Console.WriteLine("1 четверть ");
// }

// else if (X<0 && Y>0)
// {
//     Console.WriteLine("2 четверть ");
// }

// else if (X<0 && Y<0)
// {
//     Console.WriteLine("3 четверть ");
// }

// else if (X>0 && Y<0)
// {
//     Console.WriteLine("4 четверть ");
// }

// else
// {
//     Console.WriteLine("Точка находится на одной или двух осях координат ");
// }


// 18. Напишите программу, которая по заданному номеру четверти,
// показывает диапозон координат возможных точек в этой четверти (х и у)

// Console.WriteLine("Введите число");
// int input = Convert.ToInt32(Console.ReadLine());

// if (input == 1)
// {
//     Console.WriteLine("1 четверть ");
//     Console.WriteLine("X>0 && Y>0 ");
// }

// else if (input == 2)
// {
//     Console.WriteLine("2 четверть ");
//     Console.WriteLine("X<0 && Y>0");
// }
// else if (input == 3)
// {
//     Console.WriteLine("3 четверть ");
//     Console.WriteLine("X<0 && Y<0");
// }
// else if (input == 4)
// {
//     Console.WriteLine("4 четверть ");
//     Console.WriteLine("X>0 && Y<0");
// }
// else
// {
//     Console.WriteLine("оси координат");
// }


// 21. Напишите программу, котроая принимает на вход координаты 
// двух точек и находит растояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите число");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));
// Console.WriteLine(d);


// 22. Напишите программу, которая принимает на вход
// число (N)  и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1,4,9,16,25
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     Console.WriteLine(Math.Pow(i,2));
// }
