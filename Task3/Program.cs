// Задача 3: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите целое число =>");
int num = int.Parse(Console.ReadLine ());
        if ((num % 2) == 0)
        {
            Console.WriteLine("четное");
        }
        else
        {
            Console.WriteLine("нечетное");
        }
        
