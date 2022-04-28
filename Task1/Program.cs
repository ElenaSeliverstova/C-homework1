// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.Write("Введите целое число 1 =>");
int num1 = int.Parse(Console.ReadLine ());
Console.Write("Введите целое число 2 =>");
int num2 = int.Parse(Console.ReadLine ());
if(num1>num2) Console.WriteLine("Число 1 больше числа 2");
if(num2>num1) Console.WriteLine("Число 2 больше числа 1");

