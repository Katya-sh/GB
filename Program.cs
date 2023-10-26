// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string rec(int n, int count)
// {
//     if (n == 0) 
//     {
//         return "";
//     }
//     return rec(n - 1, count +1) + $"{count}";
// }

// Console.Write("Введите элемент: "); 
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// Console.WriteLine(rec(n, count));




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// string rec(int m, int n)
// {
//     if (n != 0)
//         return rec(m + 1, n - 1);
//     return $"{m} ";
    
// }

// Console.Write("Введите элемент: "); 
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите элемент: "); 
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(m, n));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int A(int m, int n)
// {
//    if (m == 0) return n + 1;
//     else if (n == 0) return A(m - 1, 1);
//     else return A(m - 1, A(m, n - 1));
    
// }

// Console.Write("Введите элемент: "); 
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите элемент: "); 
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(A(m, n));


