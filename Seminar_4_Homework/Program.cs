// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());

// int GetNumDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }
// Console.WriteLine(GetNumDegree(a, b));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numS = Convert.ToString(num);
// int GetSum()
// {
//     int res = 0;
//     int size = numS.Length;
//     for (int i = 0; i < size; i++)
//     {
//         res += num % 10;
//         num /= 10;
//     }
//     return res;
// }
// Console.WriteLine();
// Console.WriteLine(GetSum());



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// GetArray();

// void GetArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//         Console.Write(array[i] + " ");
//     }
// }