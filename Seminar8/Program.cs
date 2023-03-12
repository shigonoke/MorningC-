//  Seminar8
//   Задача. Задать двухмерный массив и написать программу которая поменяет местами 
// первую и последнюю строки массива.(любые 2 строки массива)Преобразующий метод.
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
//              array[i,j] = new Random().Next(minValue, maxValue +1);  //заполнение массива
    
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


// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >=0 && row1 < array.GetLength(0) && //проверка что номера строк соответствуют
//     row2 >= 0 && row2 < array.GetLength(0) &&
//     row1 != row2)
//     {
//      for(int j = 0; j < array.GetLength(1); j++)//пошли по столбцам
//      {
//        int temp = array[row1, j];//замена с 45-47 строку
//        array[row1, j] = array[row2, j];
//        array[row2, j] = temp;
//      }   
//     } 
// }
// int[,] newArray = GreateRandom2dArray(); //сгенерировать
// Show2dArray(newArray);

// Console.Write("Input a first row for changing: ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Input a second row for changing: ");
// int r2 = Convert.ToInt32(Console.ReadLine()) -1;

// ChangeRows(newArray, r1, r2);
// Show2dArray(newArray);

// Задача1 в залах
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//(менять отн-но диагонали)

// int[,] CreateRandom2dArray() {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array) {
//     for(int i = 0; i < array.GetLength(0); i++) {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void TransposeArray(int[,] array) {
//     if (array.GetLength(0) == array.GetLength(1)) {
//         for(int i = 0; i < array.GetLength(0); i++)
//             for(int j = i; j < array.GetLength(1); j++) {
//                 int tmp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = tmp;
//             }
//     } else
//         Console.WriteLine("Unable to transpose array");
// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// TransposeArray(newArray);
// Show2dArray(newArray);

// Задача2 в залах Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// int[,] CreateRandom2dArray() {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array) {
//     for(int i = 0; i < array.GetLength(0); i++) {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] FindMinPosition(int[,] array) {
//     int[] result = new int[2];
    
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             if (array[i, j] < array[result[0], result[1]]) {
//                 result[0] = i;
//                 result[1] = j;
//             }

//     return result;
// }

// int[,] RemoveRowAndColumn(int[,] array, int row, int col) {
//     int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
//     for(int i = 0, newI = 0; i < array.GetLength(0); i++)
//         if (i != row) {
//             for(int j = 0, newJ = 0; j < array.GetLength(1); j++)
//                 if (j != col) {
//                     result[newI, newJ] = array[i, j];
//                     newJ++;
//                 }
//             newI++;    
//         }

//     return result;
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);

// int[] minPosition = FindMinPosition(array);

// int[,] newArray = RemoveRowAndColumn(array, minPosition[0], minPosition[1]);

// Show2dArray(newArray);