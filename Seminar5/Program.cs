//  Задача Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных элементов массива.(аналитический метод)  

// int[]  CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++ ) 
//        array[i] = new Random().Next(minValue, maxValue + 1);  

//     return array; 
// }
// с 4 по 12 строку генерировать массив
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " "); 

//     Console.WriteLine(); 
// }
// с 14 по 20 строку выводить массив
// int GetNegativeSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//     if(array[i] < 0)
//         sum += array[i];
//     return sum;
// }

// Console.Write("Введите колличество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// с 32 по 37 строку шапка с базовыми запросами
// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int result = GetNegativeSum(newArray);
// Console.WriteLine("Сумма отрицательных элементов: " + result);
// строка 39-40 генерация массива
// Задача1 в залах Напишите программу замены элементов массива: положительные элементы замените на
//  соответствующие отрицательные, и наоборот.(преобразующий метод)
// int[] replaceElements(int[] array) 
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] *= -1;
//     return array;
// }
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
// int[] newarray = CreatRandomArray(12, -9, 9);
// ShowArray(newarray);
// ShowArray(replaceElements(newarray));


// Задача2 в залах Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число 
// в массиве.(аналитический метод,булевый bool'да' или 'нет') не до конца задача работает
// bool findElement(int[] array, int element) 
// {
//     for(int i = 0; i < array.Length; i++)
//         if (array[i] == element)
//             return true; 
// return false;
// }
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
// Console.Write("Введите число для поиска:");
// int element = Convert.ToInt32(Console.ReadLine());
// bool elementexists = findElement(array, element);
// if (elementexists)
//     Console.WriteLine("Число {element} есть в массиве");
// else
//     Console.WriteLine("Числа {element} нет в массиве");
// Задача3 в залах Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [a,b]. ()

// int NumberOfElements(int[] array, int start, int end) 
// {
//     int result = 0;

// for (int i = 0; i < array.Length; i++)
//     if (array[i] >= start && array[i] <= end)
//         result++;
// return result;
// }
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

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное запрашиваемое число: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное запрашиваемое число: ");
// int end = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreatRandomArray(size, min, max);
// ShowArray(newArray);
// int number = NumberOfElements(newArray, start, end);
// Console.WriteLine($"В новом массиве есть запрошенный номер {number} между {start} и {end}");