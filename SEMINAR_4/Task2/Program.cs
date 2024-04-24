
// void PrintArray(int[] myArray) //void ничего не возвращает. Функция занимается выводом, а не расчетом значений
// {
//   for (int i = 0; i < myArray.Length; i ++)
//   {
//     System.Console.Write(myArray[i] + " ");
//   }
//   System.Console.WriteLine();
// }

// int[] array = { 1, 5, 6, 7, 3, 4, 2 };
// int[] array2 = { 1, 23652, 23, 235, 25, 63, 74 };

// PrintArray(array);
// PrintArray(array2);


////1. Генерируем массив и выводим его. Затем добавляем второй массив

// void Main()
// {
//   System.Console.Write("Введите число: "); //вводим число
//   int arraySize = Convert.ToInt32(Console.ReadLine()); //принимаем это число из терминала

//   int[] array = new int[arraySize]; // генерируем число
//   Random rand = new Random();

//   for (int i = 0; i < array.Length; i++) //запускаем цикл 
//     array[i] = rand.Next(0, 10);

//   for (int i = 0; i < array.Length; i++)
//     System.Console.Write(array[i] + " ");// выводит этот массив
// System.Console.WriteLine();

//   System.Console.Write("Введите размер второго массива: ");
//   int arraySize2 = Convert.ToInt32(Console.ReadLine());

//   int[] array2 = new int[arraySize2]; 

//   for (int i = 0; i < array2.Length; i++) //запускаем цикл 
//     array2[i] = rand.Next(0, 10);

//   for (int i = 0; i < array2.Length; i++)
//     System.Console.Write(array2[i] + " ");// выводит этот массив

// }

// Main();


///// 2. то, что делали выше сделаем с использованием фунцкций
///метод Main всегда наверху и на виду
void Main()
{
  int arraySize = ReadInt("Введите размер массива: "); // вместо строки 22
  int[] array = GenerateArray(arraySize, 0, 10);// вместо строк с 25 по 29
  PrintArray(array); //вместо строк 32,33 

  int arraySize2 = ReadInt("Введите размер второго массива: "); // вместо строки 22 Введите размер второго массива: "
  int[] array2 = GenerateArray(arraySize2, 100, 1000);// вместо строк с 25 по 29
  /// arraySize2 - это количество элементов
  PrintArray(array2); //вместо строк 32,33 
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
