// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите натуральное число B");
// int B = Convert.ToInt32(Console.ReadLine());

// double res = 1;

// for (int i = 1; i <= B; i++)
// {
//     res = Math.Pow(A, B);  
// }

// Console.WriteLine(res);




// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int num)
// {
    
//     int count = Convert.ToString(num).Length;
//     int temp = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//       temp = num - num % 10;
//       result = result + (num - temp);
//       num = num / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(num);
// Console.WriteLine(sumNumber);

// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(randomArray[i] + " , ");
}
