//Задача 9: Показать последнюю цифру трехзначного числа
//Задача 11: Дано число из отрезка [10,99].Показать наибольшую цифру числа
//Задача 12: Удалить вторую цифру трехначного числа
//Задача 14: Найти третью цифру числа или сообщить что ее нет
//Задача 16: Дано число, обозначающее день недели.Выяснить, является ли новер дня недели выходным

//Задача 9:
// int fnumber =new Random().Next(100,1000);
// Console.Write($"Последняя цифра числа{fnumber}");
// int a = fnumber % 10;
// Console.Write($"равна {a}");

// Console.Write ("Введите число: ");
// int fnumber = Convert.ToInt32(Console.ReadLine());
// // Console.Write($"Последняя цифра числа{fnumber}");
// if (fnumber >= 100 & fnumber <= 999) {
//     int ld = fnumber % 10;
//     Console.WriteLine($ "Последняя цифра{ld}");

// }

//string numer = Convert.ToString(new Random().Next(100,1000));
//Console.WriteLine(numer);
//ConsoleWriteLine(numer.Substring(2));

//Задача 11: 

// Console.WriteLine("Ввести число в диапазоне от 10 до 99");
// int numberN = Convert.ToInt32(Console.ReadLine());
// if (numberN >= 10 & numberN <= 99) {
//     int FirstDigit = numberN % 10;
//     int SecondDigit = numberN /10;
//     if (FirstDigit >= SecondDigit){
//         Console.WriteLine ("Числа равны");
//     }else if (FirstDigit > SecondDigit){
//         Console.WriteLine("Первое наибольшее");
//     }else{
//         Console.WriteLine("Второе наибольшее");
//     }

// }

//Задача 12: Удалить вторую цифру трехзначного числа

// int a = new Random().Next(100,1000);
// Console.WriteLine(a);
// int first = a/100;
// int last = a%10;
// Console.WriteLine($"{first}, {last}");

//Задача 14: Найти третью цифру числа или сообщить что ее нет.

// Console.Write("Введите число: ");
//  string strl = Console.ReadLine();
//   if (strl.Length>2)
//  {
//     strl = strl.Substring(2,1);
//  }
// else
// {
//     Console.WriteLine("Третьей цифры в числе нет");
// }
 

//  Console.WriteLine(strl);

//Задача 18: Дано число, обозначающее день недели.Выяснить, является ли новер дня недели выходным

// Console.Write("Введите число дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if((num>0)&& (num<6))
// {
//     Console.WriteLine("Это рабочий день!");
// }
// else if (num==6 || num==7)
// {
//     Console.WriteLine("Ура, выходной!");
// }
// else
// {
//     Console.WriteLine("Неверный номер дня!");
// }

// 10. Показать вторую цифру трёхзначного числа

// Console.Clear();
// System.Console.WriteLine();
// int number = new Random().Next(100, 1000);

// System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

// System.Console.WriteLine(); 

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Console.Clear();
// System.Console.WriteLine();

// int Number1 = 50;
// int Number2 = 8;
// int result = 0;

// int MultipleNumber()
// {
//     result = Number1 % Number2;
//     return result;
// }

// MultipleNumber();

// System.Console.WriteLine();
// if (result == 0) System.Console.WriteLine($"Число {Number1} кратно числу {Number2}");
// else
// {
//     Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
// }
// System.Console.WriteLine();

// 24. Найти кубы чисел от 1 до N

// Console.Clear();
// System.Console.WriteLine();

// System.Console.Write("Введите число:   ");
// string writeN = Console.ReadLine();
// int N = Convert.ToInt32(writeN);


// int[] GetCubeTable(int N)
// {
//     int[] cubs = new int[N + 1];
//     for (int i = 1; i < cubs.Length; i++)
//     {
//         cubs[i] = i * i * i;
//     }
//     return cubs;
// }

// void PrintCubs(int[] array)
// {
//     for (int i = 1; i < array.Length; i++)
//     {
//         System.Console.Write($"{i} ^ 3 = ");
//         System.Console.WriteLine(array[i]);
//     }
// }

// int[] CubeTable = GetCubeTable(N);
// PrintCubs(CubeTable);

// Являается ли число палинромом
// решение проверяет как числа, так и текстовые значения

// Console.Clear();
// System.Console.WriteLine();

// System.Console.WriteLine("Введите текст или число:");
// string writeTxt = Console.ReadLine();
// string txtToCheck = writeTxt.ToLower().Replace(" ",""); // для проверки переводим знаки в нижний регистр и убираем пробелы
// int length = txtToCheck.Length;
// string result = "не является";

// bool IsPalindrome(string p)
// {
//     int count = 0;
//     while (count <= length)
//     {
//         if (txtToCheck[count] != txtToCheck[length - 1]) return false;
//         length--;
//         count++;
//     }
//     return true;
// }

// if (IsPalindrome(txtToCheck)) result = "является";
// Console.WriteLine($"Введенное значение {result} палиндромом");
// System.Console.WriteLine();
// Задача 25. Напишите цикл, который принимает на вход два числа (А и Б) и возводит
// число А в натуральную степень В
// Console.Clear();
// System.Console.WriteLine();

// int number = 2;
// int exponent = 10;

// int GetExponentiation(int number, int exponent)
// {
//     int count = 1;
//     int result = number;
//     while (count < exponent)
//     {
//         result = result * number;
//         count++;
//     }
//     return result;
// }

// int result = GetExponentiation(number, exponent);
// System.Console.WriteLine($"{number} ^ {exponent} = {result}");
// System.Console.WriteLine();

// 29. Задать массив из 8 элементов и вывести их на экран

// int N = 8;

// int[] SetArray(int x)
// {
//     int[] arr = new int[x];
//     for (int i = 0; i < x; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         System.Console.Write($"{array[i]} ");
// }

// PrintArray(SetArray(N));

// Задача 34. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
// Console.Clear();
// System.Console.WriteLine();

// int size = 20;

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintResult(int[] array)
// {
//     int even = 0;
//     int uneven = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//         if (array[i] % 2 == 0) even++;
//         else uneven++;
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
//     System.Console.WriteLine();
// }

// PrintResult(FillArray(size));

//  Задача 36. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// Console.Clear();

// int size = 20;

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void PrintArrayAndSum(int[] arr)
// {
//     int sum = 0;
//     System.Console.WriteLine();
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//         if (i % 2 > 0) sum += arr[i];
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
//     System.Console.WriteLine();
// }

// PrintArrayAndSum(FillArray(size));

// Задача 41. Посчитать, сколько чисел больше 0 введено с клавиатуры

// Console.Clear();
// System.Console.WriteLine();
// int volume = 10;                // колчество ввода чисел
// int count = 0;

// while (volume > 0)
// {
//     System.Console.Write("Введите число:   ");
//     string num = Console.ReadLine();
//     int number = Convert.ToInt32(num);
//     if (number > 0) count++;
//     volume--;
// }

// System.Console.WriteLine($"Количество чисел больше 0: {count}");

// Задача 47. Показать двумерный массив размером m×n заполненный вещественными числами

// Console.Clear();
// System.Console.WriteLine();

// double[,] GetTableDouble(int m, int n)
// {
//     double[,] table = new double[m, n];
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = new Random().NextDouble() * 100;
//         }
//     }
//     return table;
// }

// void PrintTable(double[,] tab)
// {
//     for (int i = 0; i < tab.GetLength(0); i++)
//     {
//         for (int j = 0; j < tab.GetLength(1); j++)
//         {
//             System.Console.Write(tab[i, j] + "    ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int m = 8;
// int n = 4;
// double[,] TableDouble = GetTableDouble(m, n);
// PrintTable(TableDouble);

// Задача 49. Задайте двухмерный массив.Замените элементы, у которых оба 
// индекса чётные на их квадраты

// Console.Clear();
// System.Console.WriteLine();

// int[,] GetArray(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// int[,] ChangeToSquareEvenIndex(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
//             else arr[i, j] = arr[i, j];
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) System.Console.Write($" {array[i, j]}   ");
//             else System.Console.Write($"{array[i, j]}   ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 10;
// int col = 20;
// int min = 1;
// int max = 10;

// int[,] mainArray = GetArray(row, col, min, max);
// PrintArray(mainArray);
// System.Console.WriteLine("--------");
// int[,] chagedArray = ChangeToSquareEvenIndex(mainArray);
// PrintArray(chagedArray);

// Задача 54. Задайте двухмерный массив.
// Написать программу, упорядочивания по убыванию элементы каждой строки 
// двумерного массива.
// 
// Console.Clear();
// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// int[,] SortRowAscending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int minPosition = j;                                            
//             for (int k = j + 1; k < array.GetLength(1); k++)                
//             {
//                 if (array[i, k] > array[i, minPosition]) minPosition = k;    
//             }
//             int tmp = array[i, j];                                          
//             array[i, j] = array[i, minPosition];                            
//             array[i, minPosition] = tmp;                                    
//         }

//     }
//     return array;
// }

// void PrintTable(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 4;
// int col = 7;
// int min = 10;
// int max = 100;

// int[,] table = GetMatrix(row, col, min, max);
// PrintTable(table);

// System.Console.WriteLine();
// int[,] rowSort = SortRowAscending(table);
// PrintTable(rowSort);

//  Задача 56. Задайте прямоугольный двухмерный массив.
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// int rowNumber(int[,] array)
// {
//     int index = 0;
//     int sum = 0;
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (i == 0) result = sum;
//         else if (sum < result)
//         {
//             result = sum;
//             index = i;
//         }
//     }
//     return index;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 5;
// int col = 8;
// int min = 1;
// int max = 10;

// int[,] matrix = GetMatrix(row, col, min, max);
// PrintMatrix(matrix);
// System.Console.WriteLine("---");
// int index = rowNumber(matrix);
// System.Console.WriteLine(index);
