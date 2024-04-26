// Задание 1. Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

void Main()
{
  int arraySize = ReadInt("Введите размер массива: ");
  int[] array = GenerateArray(arraySize, 0, 50);
  PrintArray(array);
  System.Console.WriteLine(CountPrimes(array));

}

int CountPrimes(int[] array)
{
  int count = 0;
  foreach (int number in array)
    if (isPrime(number))
      count++;

  return count;
}

bool isPrime(int number) //являестя ли наше число простым
{
  if (number < 2) return false; //если наш number < 2,то тогда возвращаем ложь, потому что все отрицательные числа, нолики
                                //  и единички не простые

  for (int i = 2; i <= Math.Sqrt(number); i++)//идти будет пока переменная счетчикменьше либо равна квадратному корню от 
                                              //числа, которое мы проверяем
    if (number % i == 0)// если переменная number делится на переменную счетчик и без остатка, то тогда возвращаем ложь
      return false;

  return true;
}


void PrintArray(int[] arrayForPrint)
{
  // for (int i = 0; i < arrayForPrint.Length; i++)
  //   System.Console.Write(arrayForPrint[i] + " "); 
  // System.Console.WriteLine();
  System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]"); // выводит все эл-ты через запятую
}

int[] GenerateArray(int size, int minRandge, int maxRandge)
{
  int[] tempArray = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
    tempArray[i] = rand.Next(minRandge, maxRandge + 1);

  return tempArray;
}

int ReadInt(string msg)
{
  System.Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

Main();