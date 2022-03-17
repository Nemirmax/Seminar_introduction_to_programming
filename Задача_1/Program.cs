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

Console.WriteLine("Ввести число в диапазоне от 10 до 99");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN >= 10 & numberN <= 99) {
    int FirstDigit = numberN % 10;
    int SecondDigit = numberN /10;

}