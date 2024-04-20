// Задание 1. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа
//должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// 1-й способ, как задать массив: int[] array = { 1, 55, 7, 12, 14 }

// // 2-й способ: 
// int[] array = new int[4]; // задали размер массива
// /// или так задем 
// //      int size = Convert.ToInt32(Concole.ReadLine());
// //      int[] array = new int[size];

// System.Console.WriteLine("Введите значения массива: "); //эту строку можно не писать 
// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write($"{i}-й элемент массива: ");  /// можно  так ($"{i + 1}-й элемент массива:");
//   array[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i] + " ");
// }


//3-й способ с генерацией случайных чисел

// System.Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 10); // От 0 до 9
// }

// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i] + " ");
// }

// решение задачи
// System.Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// Random rand = new Random();  //выделение ячейки оперативной памяти под генерацию случайных чисел и убрали ее из цикла

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = rand.Next(0, 10); // От 0 до 9
// }

// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i] + " ");
// }

// System.Console.Write("\nВведите искомое число: ");//\n - это перенос на новую строку
// int number = Convert.ToInt32(Console.ReadLine()); // примем от пользователя число, которое он ищет

// bool numberIsFinder = false; //объявляем булевую переменную, которая свидетельствует о том, нашли ли мы значение или не нашли

// for (int i = 0; i < array.Length; i++)  //проходимся по длине всего массива и начинаем сравнивать с введеным пользователем значением
//   if (array[i] == number) /// если они одинаковые,
//   {
//     numberIsFinder = true; //то мы булевое значение меняем на истину
//     break;// и завершаем наш цикл
//   }
// if (numberIsFinder) //если мы ниразу не зайдем в наше ветвление, то переменная numberIsFinder так и останется со значением false
//                     // и это будеи говорить о том, что числе не было найдено
//                     //numberIsFinder переменная уже хранит true или false, поэтому сравнивать ее безсмыслено
// {
//   System.Console.WriteLine("Yes"); //в итоге проверяем чему равна наша переменная. Если она истина, то да, если ложь, то нет
// }
// else
// {
//   System.Console.WriteLine("No");
// }



// Задание 2. Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// System.Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// Random rand = new Random();  //выделение ячейки оперативной памяти под генерацию случайных чисел и убрали ее из цикла

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = rand.Next(-10, 11);
// }

// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i] + "\t"); // \t - табуляция
// }

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] *= -1; //придаем обратное значение (меняем положительное на отрицательное и наоборот)
// }

// System.Console.WriteLine(); //добавим вывод пустой строки, чтобы все не слипалось
// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i] + "\t"); // \t - табуляция
// }

// Задача 3. Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// System.Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// Random rand = new Random();  //выделение ячейки оперативной памяти под генерацию случайных чисел и убрали ее из цикла

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = rand.Next(-10, 11);
// }

// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i] + " "); // \t - табуляция
// }

// int[] newArray = new int[array.Length / 2]; //создаем новый массив это размер старого массива деленный на два

// for (int i = 0; i < newArray.Length; i++)  //теперь заполняем новый массив
// //если у нас три элемента, то и итераций будет три
// {
//   newArray[i] = array[i] * array[array.Length - 1 - i]; //умножаем на последний элемент array.Length -1 - i (i становится 
//больше с каждой итерацией)
//например [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары) //i=0, 1, 2
// array[7-1-0] -> array[6];
// array[7-1-1] -> array[5];
// array[7-1-2] 
// }

// System.Console.WriteLine(); //добавим отступ
// for (int i = 0; i < newArray.Length; i++)
// {
//   System.Console.Write(newArray[i] + " ");
// }


// Задаа 4. Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд числа 
// должен располагаться на 0-м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

//можно задать от пользователя System.Console.Write("Введите размер массива: ");
//   int size = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(100, 1000); // генерируем трехзначное число
System.Console.WriteLine("Сгенерированное число: " + number);

int[] array = new int[3]; // объявляем массив на три элемента

for (int i = 0; i < array.Length; i++) // запускаем цикл, в котором 
{
  array[i] = number % 10;  //каждому элементу присаиваем значение деления по модулю на 10 от нашего числа
  number /= 10; //и чтобы переходить к следующей цифре нашего числа мы делим его на 10
}
for (int i = 0; i < array.Length; i++)
{
  System.Console.Write(array[i] + " ");
}

