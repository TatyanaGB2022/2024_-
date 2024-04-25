//1. Метод CONCAT - все элементы конкатинирует и возвращвет все это в качестве строки
//2. Метод Join - объединяет все элементы в строку через заданные разделители

using System.Runtime.InteropServices;

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
  // int number = 0;

  // foreach (int value in array)
  // {
  //   number *= 10;
  //   number += value;
  // }

  return Convert.ToInt32(string.Concat(array));
}

void PrintArray(int[] arrayForPrint) 
{
  // for (int i = 0; i < arrayForPrint.Length; i++)
  //   System.Console.Write(arrayForPrint[i] + " "); 
  // System.Console.WriteLine();
  System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]"); // выводит все эл-ты через запятую
}

int[] GenerateArray(int size, int minRange, int maxRandge) 
{
  int[] tempArray = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
    tempArray[i] = rand.Next(minRange, maxRandge + 1); 

  return tempArray;
}

int ReadInt(string msg) 
{
  System.Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

Main();

