﻿//Задача 9: Показать последнюю цифру трехзначного числа
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