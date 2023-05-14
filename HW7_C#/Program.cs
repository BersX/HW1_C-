// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите номер строки ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] array =new  double [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(-100,100)/10;
//        Console.Write(array[i,j] + "  ");
//     }

//     Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int [,] array =new  int [,] { {1,4,7,2} , {5,9,2,3} , {8,4,2,4} };

// Console.WriteLine("Введите номер строки ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите номер столбца");
// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows>2 && columns>3)
//  Console.WriteLine("такого числа нет");
//  else
//  {
//  Console.WriteLine(array[rows,columns]);
//  }



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array =new  int [rows,columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i,j] = new Random().Next(0,10);
       Console.Write(array[i,j] + "  ");
    }
    Console.WriteLine();
}

double summ = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
       summ = summ + array[j,i]; 
       break;         
    }
}
Console.WriteLine("Среднее арифметическое 1 столбца: " + summ/array.GetLength(1));




