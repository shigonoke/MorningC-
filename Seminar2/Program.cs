// Задача Программа которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;
//     int result = hundreds * 10 + units;

//     return result;   //возвращает
// }

// int randNumber = new Random().Next(100,1000); //Принимает на вход 2 аргумента, нижний и верхний предел

// int newNumber = CutNumber(randNumber);
// Console.WriteLine($"New version of {randNumber} is {newNumber}");


// Задача 2 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно a и b.

// bool IsMultiplyed( int num, int div1, int div2)
// {
//     if(num % div1 == 0 && num % div2 == 0 ) 
       
//   return true;
//     else
//         return false;
//  }
//     // 2 вариант
    // bool IsMultiplyed( int num, int div1, int div2)
    // {
    //     return num % div1 == 0 && num % div2 ==0;
    // }
// Console.Write("Input a number for checking: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a first divider: ");
// int divider1 = Convert. ToInt32(Console.ReadLine());
// Console.Write("Input a second divider: ");
// int divider2 = Convert. ToInt32(Console.ReadLine());
//  bool result = IsMultiplyed(number, divider1, divider2);
//  Console.WriteLine(result);можно так
//    if(result) 
//     Console.WriteLine($"Your number {number} is divisible by the {divider1} and {divider2}");   
//    else
//     Console.WriteLine($"Your number {number} is not divisible by the {divider1} and {divider2}");
//   Задача в залах Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//   и показывает наибольшую цифру числа.
// int GetMaxNumber(int num)
// {
//     int dozens = num / 10;
//     int units = num % 10;
    
//     if (dozens >= units)
//         return dozens;
//     else
//         return units;
// }

// int randNumber = new Random().Next(10,100);

// Console.WriteLine(randNumber);
// Console.Write(GetMaxNumber(randNumber));


// Задача в залах Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.


// bool IsQuard( int num1, int num2)
// {
//     if (num1*num1 == num2)
//         return true;
//     if (num2*num2 == num1)
//         return true;

//         return false;
// }

// Console.Write("Input a first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool result = IsQuard(num1,num2);
// Console.Write(result);

