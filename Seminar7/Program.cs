//Семинар7. Двухмерные массивы. Задача. Задайте двухмерный массив размером m на n 
//заполненый случайными целыми числами

// int[,] GreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // имя,размерность,диапазон

//     int[,] array = new int[rows, columns]; // выделили память под массив//
//     for(int i = 0; i < rows; i++)  //внешний цикл переходить по строкам//
//         for(int j = 0; j < columns; j++)  // внутр цикл в рамках одной строки будет проходиться по элементам
//              array[i,j] = new Random().Next(minValue, maxValue);  //заполнение массива
    
// return array;//возвращаем массив
// } 

//  void Show2dArray(int[,] array) //вывод массива
//  {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//             Console.WriteLine(); //переход на следующую строку
//     }
//     Console.WriteLine(); //строка отступа от послед данных
//  }

// Console.Write("Input a number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = GreateRandom2dArray(rows, columns, minValue, maxValue + 1); //сгенерировать
// Show2dArray(newArray); //вывести 
//Чтобы было меньше аргументов в массиве можно так сделать


// int[,] GreateRandom2dArray() 
// {
// Console.Write("Input a number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns]; // выделили память под массив//

//     for(int i = 0; i < rows; i++)  //внешний цикл переходить по строкам//
//         for(int j = 0; j < columns; j++)  // внутр цикл в рамках одной строки будет проходиться по элементам
//              array[i,j] = new Random().Next(minValue, maxValue);  //заполнение массива
    
// return array;//возвращаем массив
// } 

//  void Show2dArray(int[,] array) //вывод массива
//  {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//             Console.WriteLine(); //переход на следующую строку
//     }
//     Console.WriteLine(); //строка отступа от послед данных
//  }

// int[,] newArray = GreateRandom2dArray(); //сгенерировать
// Show2dArray(newArray);

// Задача в залах Задайте двумерный массив размера m на n, каждый элемент в
// массиве находится по формуле: Aij = i + j. Выведите полученный массив на экран.
//  int[,] CreateArray (int rows, int columns)
//  {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//     array[i,j] = i + j;
//     return array;
//  }
//  Console.Write("Input a quantity of rows: ");
//  int rows = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Input a quantity of columns: ");
//  int columns = Convert.ToInt32(Console.ReadLine());
//  int[,] newArray = CreateArray (rows, columns);
//  Show2dArray(newArray);

//Задача2 в залах

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадрат
// int[,] ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//         for (int j = 0; j < array.GetLength(1); j += 2)
//             array[i,j] *= array[i,j];
//     return array;
// }
// int[,] newArray = CreatRandom2dArray();
// Show2dArray(newArray);
// ChangeArray(newArray);
// Show2dArray(newArray);

//Задача3 в залах

// int GetSumDiagonal(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
//         result += array[i, i];
//     return result;
// }
// int[,] newArray = CreatRandom2dArray();
// Show2dArray(new Array);
// Console.WriteLine(GetSumDiagonal(newArray)); 
