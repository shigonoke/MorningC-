// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int GetSum(int a)
// {
//     int sum = 0;

//     for(int current = 1; current <=a; current++)
//     {
//         sum +=current;
//     }
//     return sum;

// }

// Console.Write("Input a number:");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(number);
// Console.WriteLine($"Sum of numbers from 1 to {number} is {result}");

//  Задача1 в зале2 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int GetDigit(int number) метод кот-ый принимает число кот-ый введет польз-ль
// {
// int digit = 0; переменная которая хранит кол-во цифр в числе
// if (number == 0) digit = 1; пока не равно 0,делим на 10, прибавляем 1
// while (number != 0) 
// {
//     number = number / 10;
//     digit++;
// }   
// return digit;
// }
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int digit = GetDigit(num);
// Console.WriteLine($"Count of digits in number {num} is {digit}");

// Задача2 в зале2 Напишите программу, которая принимает на вход число N и выдаёт произведение 
// чисел от 1 до N.

// int GetFactorial(int number)
// {
//     int factorial = 1;
//     for (int current = 2; current <= number; current++) factorial *= current;
//     return factorial;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = GetFactorial(number);
// Console.WriteLine($"Factorial of number {number} is {result}");
// МАССИВЫ
// Создать метод который будет генерировать массив заполнять его случайными числами

// int[]  CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++ ) 
//        array[i] = new Random().Next(minValue, maxValue + 1);  

//     return array; 
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); 

//     Console.WriteLine(); 
// }


// Console.Write("Введите колличество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);








