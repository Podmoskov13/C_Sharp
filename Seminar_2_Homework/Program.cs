﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
 
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Вторая цифра числа {num} - это {num = (num /10) %10}");
 

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 
// int num = new Random().Next(10, 40000);
 
// if(num > 99 && num < 1000)
// {
// Console.WriteLine($"Третья цифра числа {num} - это {num= num %10}");
// }
// else if (num > 999 && num < 10000)
// {
// Console.WriteLine($"Третья цифра числа {num} - это {num= (num /10) %10}");
// }
// else if (num > 9999 && num < 40001)
// {
// Console.WriteLine($"Третья цифра числа {num} - это {num= (num /100) %10}");
// }
// else
// {
// Console.WriteLine("Третьей цифры нет");
// }
 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
 
// int num = new Random().Next(0, 10);
 
// if(num > 0 && num < 6)
// {
// Console.WriteLine("День номер " + num + "\nЭто не выходной");
// }
// else if (num > 5 && num < 8)
// {
// Console.WriteLine("День номер " + num + "\nЭто выходной");
// }
// else
// {
// Console.WriteLine("Такого дня недели нет");
// }