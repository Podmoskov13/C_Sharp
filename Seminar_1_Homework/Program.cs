// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
 
Console.WriteLine("Введите число");
int number1=Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите число");
int number2=Convert.ToInt32(Console.ReadLine());
 
if(number1>number2)
{
Console.WriteLine("Число " + number1 + " больше");
Console.WriteLine("Число " + number2 + " меньше");
}
else
{
Console.WriteLine("Число " + number2 + " больше");
Console.WriteLine("Число " + number1 + " меньше");
}
 
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
 
Console.WriteLine("Введите число");
int number01=Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите число");
int number02=Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите число");
int number03=Convert.ToInt32(Console.ReadLine());
 
int max = number01;
 
if(number02>max) max = number02;
if(number03>max) max = number03;
{
Console.WriteLine(max);
}
 
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
 
Console.WriteLine("Введите число");
int number001=Convert.ToInt32(Console.ReadLine());
 
if(number001 % 2 ==0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
 
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5-> 2,4
// 8 -> 2, 4, 6, 8
 
Console.WriteLine("Введите число");
int number0001=Convert.ToInt32(Console.ReadLine());
 
int evenNumber= 2;
 
if(number0001 > 1)
{
while(evenNumber <= number0001)
{
Console.Write(evenNumber + " ");
evenNumber = evenNumber + 2;
}
}