// Seminar6 Одномерные массивы
//   Задача Вывести массив в обратном порядке
  
// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
// int[] array = new int[size];

// for(int i = 0; i < size; i++)
// array[i] = new Random().Next(minValue, maxValue + 1);
// return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); 
//     Console.WriteLine();
// }

// void ReverseArray(int[] array)
// {
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreatRandomArray(size, min, max);
// ShowArray(newArray);
// ReverseArray(newArray);
// ShowArray(newArray);


// Задача в залах1
// Напишите программу которая принимает на вход 3 числа и проверяет может ли существовать 
// треугольник со сторонами такой длины.(Одна сторона д.б меньше суммы 2-ух других, метод bool) 
// 1 вариант
// bool CheckTria (int a, int b, int c)
// {
// if(a < (b + c) && b < (a+c) && c < (a + b)) return true;
// return false;
// }
// Console.Write("Input a number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// bool result =CheckTria (a,b, c);
// if (result) Console.WriteLine ( "Треугольник есть");
// else Console.WriteLine ( "Треугольника нет");
// 2 вариант
// bool TriangleCheck(int a, int b, int c)
// {
// return a < b + c && b < a + c & c < a + b;
// }
// Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (TriangleCheck(a, b, c)) Console.WriteLine("Yes, triangle exist");
// else Console.WriteLine("Triangle not found");
// Задача в залах2
// Не используя рекурсию вывести первые N чисел Фибоначчи. Первые числа a и b.
// (Каждый новый элемент в ряду Фибоначчи формируется из суммы 2-ух предидущих элементов) Size это N
// int [] Fibonachi (int size, int a, int b)
// {
// int[] arr = new int [size];
// arr [0] = a;
// arr [1] = b;
// for(int i = 2; i < arr.Length; i++)
// {
//     arr [i] = arr [i - 1] + arr [i-2];
// }
// return arr;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console. WriteLine();
// }
// Console.Write("Input a size: ");
// int size = Convert. ToInt32(Console.ReadLine());
// Console.Write("Input a number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int [] result = Fibonachi (size, a, b);
// ShowArray(result);

// Задача в залах3
// Написать программу которая будет создавать копию заданного массива с 
// помощью поэлементного копирования.

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
// int[] array = new int[size];

// for(int i = 0; i < size; i++)
// array[i] = new Random().Next(minValue, maxValue + 1);
// return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); 
//     Console.WriteLine();
// }

// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }
// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreatRandomArray(size, min, max);
// ShowArray(newArray);
// ShowArray(CopyArray(newArray));
// Задача в залах4*
// Напишите программу которая будет преобразовывать десятичное число в двоичное
// (Метод берет int  и возвращает строку)