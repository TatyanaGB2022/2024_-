// Задание 3. Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231
// не более 8 - потому что тип int может хранить значений такое число 2147483647, размер числа не больше 10
//System.Console.WriteLine(int.MaxValue);


void Main()
{
  int arraySize = ReadInt("Введите размер массива: ");

  if (arraySize > 8)
  {
    System.Console.WriteLine("Вы ввели слишком большое число! ");
    return;
  }

  int[] array = GenerateArray(arraySize, 0, 9);
  PrintArray(array);

  System.Console.WriteLine(FromArrayToNumber(array));
}

int FromArrayToNumber(int[] array)
{
  int number = 0;

  foreach (int value in array)
  {
    number *= 10;
    number += value;
  }

  return number;
}

//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     number += array[i];
//     number *= 10;
//   }
//   number += array[array.Length - 1];
//   return number;
// }

void PrintArray(int[] arrayForPrint) //функция занимается только выводом массива
{
  for (int i = 0; i < arrayForPrint.Length; i++)
    System.Console.Write(arrayForPrint[i] + " "); //выводим все элеметны arrayForPrint через разделитель
  System.Console.WriteLine();
}

int[] GenerateArray(int size, int minRange, int maxRandge) //функция занимается только генерацией массива
{
  int[] tempArray = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
    tempArray[i] = rand.Next(minRange, maxRandge + 1); //это как буд-то к 9 прибавили 1. то есть верхняя граница будет 10 

  return tempArray;
}

int ReadInt(string msg) //функция занимается только чтением массива. Чтение чисел вынесли в отдельный метод
{
  System.Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

Main();