// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// System.Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//   int leftDigit = number / 100;  //если это не писать
//   int rightDigit = number % 10;   //если это не писать
//   System.Console.WriteLine(leftDigit + "" + rightDigit);  // то здесь Console.WriteLine(number / 100 + "" + number % 10);
// }
// else
// {
//   System.Console.WriteLine("Введено не трехзначное число!");
// }

//второй способ

// System.Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//   int leftDigit = number / 100;
//   int rightDigit = number % 10;
//                      //System.Console.WriteLine(leftDigit + "" + rightDigit); 
//   int result = leftDigit * 10 + rightDigit;
//   System.Console.WriteLine(result);
// }
// else
//   {
//     System.Console.WriteLine("Введено не трехзначное число!");
//   }

// Задание 2. Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152    487 разделить на 10 получится 48 (48 десятков)/ J48 % остаток от деления на 10 будет 8
// 254 => 5^4 = 625
// 617 => 1

// System.Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//   int middleDigit = number / 10 % 10;
//   int rightDigit = number % 10;
//   int result = 1;

//   for (int i = 0; i < rightDigit; i++)
//   {
//     result *= middleDigit; //или result = result * rightDigit
//   }
//   System.Console.WriteLine(result);
// }
// else
// {
//   System.Console.WriteLine("Введено не трехзначное число!");
// }


// Задание 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// System.Console.Write("Введите первое число: ");
// int firsNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firsNumber%secondNumber==0)
// {
//   System.Console.WriteLine($"{firsNumber}, {secondNumber} => yes");
// }
// else
// {
//   System.Console.WriteLine($"{firsNumber}, {secondNumber} => no, {firsNumber%secondNumber}");
// }

// Задание 4* Напишите программу, которая выводит третью с конца цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет
// 15 мин

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99)
// {
//   System.Console.WriteLine(number % 1000 / 100);
// }
// else
// {
//   System.Console.WriteLine("Третьей цифры нет!");
// }


//если считать слева направо третье число
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
  while (number > 999) // ИЛИ for( ; number > 999; )
    number /= 10;

  System.Console.WriteLine(number % 10);
}
else
{
  System.Console.WriteLine("Третьей цифры нет!");
}
