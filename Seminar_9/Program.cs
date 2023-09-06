// Задача 63: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
 
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
 
// int startNum=1;
 
// Console.WriteLine(PrintNumbers(startNum,num));
 
// string PrintNumbers(int start, int end)
// {
// if(start==end)
// {
// return start.ToString();
// }
// return (start+ " "+ PrintNumbers(start+1,end));
// }


 
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
 
// Console.WriteLine("Введите начальное число: ");
// int num1 = int.Parse(Console.ReadLine());
 
// Console.WriteLine("Введите конечное число: ");
// int num2 = int.Parse(Console.ReadLine());
 
// if (num1 < num2)
// {
// Console.WriteLine(PrintNumbers(num1,num2));
// }
// else
// {
// Console.WriteLine("Ввод некорректный!");
// }
 
// string PrintNumbers(int start, int end)
// {
// if(start==end)
// {
// return start.ToString();
// }
// return (start+ " "+ PrintNumbers(start+1,end));
// }
 
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
 
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
 
// Console.WriteLine(PrintNumbers(num));
 
// int PrintNumbers(int num)
// {
// if(num<=0)
// {
// return 0;
// }
// return (num%10+PrintNumbers(num/10));
// }
 
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
 
// Console.WriteLine("Введите число A: ");
// int num1 = int.Parse(Console.ReadLine());
 
// Console.WriteLine("Введите число B: ");
// int num2 = int.Parse(Console.ReadLine());


 
// System.Console.WriteLine(PrintNumbers(num1, num2));
 
// double PrintNumbers(int num1, int num2)
// {
// if(num2==1)
// {
// return num1;
// }
// if (num2==0)
// {
// return 1;
// }
 
 
// if(num2<0)
// {
// double n =1/( Math.Pow(num1, num2));
// return n ;
// }
// return(num1*PrintNumbers(num1,num2-1));
// }
 
// Дополнительно 
 
// Console.Write("Введите первую размерность первого массива: ");
// int rowsOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую размерность первого массива: ");
// int columsOne = Convert.ToInt32(Console.ReadLine());
// int[,] matrixOne = new int[rowsOne, columsOne];
// Console.Write("Введите первую размерность второго массива: ");
// int rowsTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую размерность второго массива: ");
// int columsTwo = Convert.ToInt32(Console.ReadLine());
// int[,] matrixTwo = new int[rowsTwo, columsTwo];
// if (rowsOne == columsTwo)
// {
// int[,] matrixThree = new int[rowsOne, columsTwo];
// void InputArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = new Random().Next(10, 100);
// }
// }
// }
 
// void PrintArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if (j == 0)
// {
// System.Console.Write("[");
// }
// System.Console.Write(array[i, j]);
// if (j == array.GetLength(1) - 1)
// {
// System.Console.Write("]");
// }
// else
// {
// System.Console.Write("; ");
// }
// }
// System.Console.WriteLine();
// }
// }
// void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
// for (int j = 0; j < resultMatrix.GetLength(1); j++)
// {
// int sum = 0;
// for (int k = 0; k < firstMatrix.GetLength(1); k++)
// {
// sum += firstMatrix[i, k] * secomdMartrix[k, j];
// }
// resultMatrix[i, j] = sum;
// }
// }
// }
// InputArray(matrixOne);
// InputArray(matrixTwo);
// PrintArray(matrixOne);
// System.Console.WriteLine();
// PrintArray(matrixTwo);
// System.Console.WriteLine();
// MultiplyMatrix(matrixOne, matrixTwo, matrixThree);
// PrintArray(matrixThree);
// }
// else
// {
// System.Console.WriteLine
// ("Ошибка! Нельзя найти произведение двух заданных матриц, так как количество строк первой матрицы не равно количеству строк второй!");
// }