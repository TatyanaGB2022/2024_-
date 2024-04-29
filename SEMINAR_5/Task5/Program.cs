// Задание 3. Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

void Main()
{
  int row = ReadInt("Введите количество строк: "); //1. сколько будет строк
  int column = ReadInt("Введите количество столбцов: ");  //1. сколько будет столбцов
  int[,] myMatrix = GenerateMatrix(row, column, 0, 9);
  PrintMatrix(myMatrix);
  PrintArray(FindAvarages(myMatrix));
}

void PrintArray(double[] array)
{
  System.Console.WriteLine("[" + string.Join("\t", array) + "]");
}

double[] FindAvarages(int[,] matrix)
{
  double[] avarages = new double[matrix.GetLength(0)];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      avarages[i] += matrix[i, j];
    }
    avarages[i] = Math.Round(avarages[i] / matrix.GetLength(1), 2);
  }

  return avarages;
}

void PrintMatrix(int[,] matrix) //5. выводит матрицу
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write(matrix[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}

int[,] GenerateMatrix(int row, int col, int minRange, int maxRange) //2. создаем метод, который сгенерирует массив
{
  int[,] tempMatrix = new int[row, col]; //3. создаем временную матрицу
  Random rand = new Random(); //4. создаем одну единственную ячейку, в которой будет проходить генерация чмсла

  for (int i = 0; i < tempMatrix.GetLength(0); i++) //
    for (int j = 0; j < tempMatrix.GetLength(1); j++)
      tempMatrix[i, j] = rand.Next(minRange, maxRange + 1);

  return tempMatrix;
}

int ReadInt(string msg) //1. принимаем размер нашего массива
{
  System.Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

Main();

