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

// System.Console.Write("Введите первое число: ");
// int firstNamber = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int secondNamber = Convert.ToInt32(Console.ReadLine());

// if(firstNamber == secondNamber * secondNamber)
// {
// Console.WriteLine("yes");
// }
// else
// {
//   Console.WriteLine("no");
// }


// System.Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber)
// {
// Console.WriteLine("a = " + firstNumber + ", b = " + secondNumber + " => да");
// }
// else
// {
// Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => нет"); //или такой вариант
// }

// Задание 2. Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = -number;
while(i <= number) //когда переменная-счетчик станет больше, чем переменная number, то цикл остановится
{
  System.Console.Write(i + " ");
  i++;  //или i = i + 1 или i += 1
}