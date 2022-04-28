// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите целое число 1 =>");
int num1 = int.Parse(Console.ReadLine ());
Console.Write("Введите целое число 2 =>");
int num2 = int.Parse(Console.ReadLine ());
Console.Write("Введите целое число 3 =>");
int num3 = int.Parse(Console.ReadLine ());
if(num1>num2&num1>num3) Console.WriteLine("Число 1 максимальное");
if(num2>num1&num2>num3) Console.WriteLine("Число 2 максимальное");
if(num3>num1&num3>num2) Console.WriteLine("Число 3 максимальное");
