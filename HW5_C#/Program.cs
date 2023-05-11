// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] numArr = new int[]{345,897,568,234};

// int count = 0;

// for (int i = 0; i < numArr.Length; i++)
// {
//     if (numArr[i] % 2 == 0)
//         count++;   
// }
// Console.WriteLine(String.Join(",", numArr));
// Console.WriteLine("Количество чётных чисел " + count );



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] numArr = new int[]{3,7,23,12};
// int result =0;
// for (int i = 1; i < numArr.Length; i+=2)
// {
//     // if (numArr[i] % 2 == 0)
//     {
//         result = result + numArr[i];
//     }
// }

// Console.WriteLine(result);




// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] numArr = new double[5];

for (int i = 0; i < numArr.Length; i++)
{
    numArr[i] = new Random ().NextDouble() + new Random().Next(1,100);
}
Console.WriteLine(String.Join(" / ", numArr));

double min = numArr [0];
double max = numArr [0];
for (int i = 0; i < numArr.Length; i++)
{
    if (numArr[i] < min)
    {
        min = numArr[i];
    }
     if (numArr[i] > max)
    {
        max = numArr[i];
    }
}
double res = max - min;

Console.WriteLine("Минимальное число " + min);
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("Разница " + res );
