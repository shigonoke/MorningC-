// Seminar3
// Задача Программа по заданному номеру четверти показывает диапазон возможных кооординат точек 
// в этой четверти
//  void ShowDiapozone(int guad)
//  {
//     if(guad == 1) Console.WriteLine("x > 0 and y > 0");
//     else if(guad == 2) Console.WriteLine("x < 0 and y > 0");
//      else if(guad == 3) Console.WriteLine("x < 0 and y < 0");
//       else if(guad == 4) Console.WriteLine("x > 0 and y < 0");
//       else Console.WriteLine("Некорректный ввод");
//  }

//  Console.Write("Введи номер четверти: ");
//  int guadrant = Convert.ToInt32(Console.ReadLine());

//  ShowDiapozone(guadrant);

//Задача(зал1) Напишите программу которая принимает на вход коордитнаты некой точки x и y не нулевые и 
//выдает номер четверти плоскости в которой находится эта точка

// int getQuarter(int x, int y)
//  {
//     if (x > 0 && y > 0)
//         return 1;
//     if (x < 0 && y > 0)
//         return 2;
//     if (x < 0 && y < 0)
//         return 3;
//     if (x > 0 && y < 0)
//         return 4;

//     return -1;
//  }
// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());


// int quarter = getQuarter(x, y);
// if (quarter > 0)
//     Console.WriteLine($"point is in {quarter} quarter");
// else
//     Console.WriteLine($"point is not in quarters");


//Задача(зал2) Программа принимает на вход  координаты двух точек и находит расстояние между ними. 

//  double getDistance(double xa, double ya, double xb, double yb) 
// {
//     return Math.Sqrt((xb-xa) * (xb-xa) + (yb-ya) * (yb-ya));
// }

// Console.Write("Введите координату X первой точки: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y первой точки: ");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координату X второй точки: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Расстояние между точками: " + Math.Round(getDistance(xa, ya, xb, yb), 2));

//Задача(зал3) Программу которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

//  void squareTable(int n) 
//  {
//     int currentNumber = 1;
//     while (currentNumber <= n) 
//     {
//         Console.WriteLine(currentNumber + "-" + (currentNumber * currentNumber));
//     currentNumber++;
//     }
//  }
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 0)
//     squareTable(n);
// else
//     Console.Write("Введите число больше 0");

