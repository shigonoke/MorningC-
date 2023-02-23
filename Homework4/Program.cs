// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponentiation(int numberA, int numberB)
// {
//     int result = 1;

//     for(int current = 1; current <=numberB; current++)
//     {
//         result = result * numberA;
//     }
//     return result;

// }

// Console.Write("Ведите число A:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите число B:");
// int numberB = Convert.ToInt32(Console.ReadLine());


// int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumber(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number = number / 10;
//     }  
//     return sum;
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = SumNumber(number);
// Console.WriteLine($"Сумма чисел  {number} равна {sum}");

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Prompt (string message)
// {
// System.Console.Write (message); 
// string ReadInput = System.Console.ReadLine();
// int result = int.Parse(ReadInput); 
// return result;
// }

// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
// int[] array = new int[Length]; 
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
// {
//     array[i] = random.Next(minValue, maxValue + 1);
// }
//     return array;
// }
// void PrintArray(int[] array)
// {
// System.Console. Write("{");
// for (int i = 0; i < array.Length - 1; i++)
// {
// System.Console.Write($"{array[i]}, "); 
// }
// System.Console.Write($"(array[array.Length - 1]"); 
// System.Console. WriteLine("]");
// }
// int length = Prompt("Длина массива: ");
// int min = Prompt("Начальное значение, для диапазона случайного числа: ");
// int max = Prompt("Конечное значение, для диапазона случайного числа:");
// int[] array = GenerateArray(length, min, max);
// PrintArray(array);
