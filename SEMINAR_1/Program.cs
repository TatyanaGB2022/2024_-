// Задание 1. Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

/* int firstNamber = 16;
int secondNamber = 4;
if (firstNamber == secondNamber * secondNamber)
{
  Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
} 
*/

// string str = Console.ReadLine();
// int number = Convert.ToInt32(str);
// System.Console.WriteLine(number + 10);


// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number + 10);

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(number + 10);

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

System.Console.Write("Введите первое число: ");
int firstNamber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNamber = Convert.ToInt32(Console.ReadLine());

if(firstNamber == secondNamber * secondNamber)
{
Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
}