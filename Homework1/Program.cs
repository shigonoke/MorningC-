//Homework1 Урок 1. Знакомство с языком программирования С#

// Task 1. Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// int max = 0;
// int min = 0;
// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 > num2)
// {
//     max = num1;
//     min = num2;
// }
// else
// {
//     max = num2;
//     min = num1;
// }
// Console.WriteLine($"max = {max} и min = {min}");

// Task 2. Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
// из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int max = 0;
// Console.Write("Input a first number: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Input a second number: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Input a third number: ");
//  int num3 = Convert.ToInt32(Console.ReadLine());

//  if(num1 > max)
// {
//     max = num1;
// }
// if(num2 > max)
// {
//     max = num2;
// }
// if(num3 > max)
// {
//     max = num3;
// }

// Console.WriteLine("max -> " + max);

//  Task3. Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Insert number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int remDiv = number % 2;

// if(remDiv == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// Task 4. Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Insert number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(number > 1)
// {
//     while(evenNumber <= number)
//     {
//         Console.Write(evenNumber + ",");
//         evenNumber = evenNumber + 2;
//     }
// }
 



