// Задание 2. Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

void Main()
{
  int arraySize = ReadInt("Введите размер массива: ");
  int[] array = GenerateArray(arraySize, 15, 28);
  PrintArray(array);
  System.Console.WriteLine(CountNumbers(array));
}

int CountNumbers(int[] myArray)
{
  int count = 0;
  foreach (int number in myArray) // позволяет перебрать все цифры в массиве
      if (number % 7 == 0 && number % 10 == 1) //number %7 == 0 делится ли наше число без остатка и является ли последняя цифра нашего числа единицей
      count++;
  return count;
}

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
    tempArray[i] = rand.Next(minRange, maxRandge);

  return tempArray;
}

int ReadInt(string msg) //функция занимается только чтением массива. Чтение чисел вынесли в отдельный метод
{
  System.Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

Main();