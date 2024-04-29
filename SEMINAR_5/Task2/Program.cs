// Задание 1. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти 
// элементы на их квадраты.
// Пример
// 2 3 4 3       4 3 16 3
//  4 3 4 1 =>   4 3 4 1
//  2 9 5 4      4 9 25 4

void Main()
{
  int row = ReadInt("Введите количество строк: ");
  int column = ReadInt("Введите количество столбцов: ");
  int[,] myMatrix = GenerateMatrix(row, column, 0, 9);
  PrintMatrix(myMatrix);

}

void PrintMatrix(int[,] matrix)
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

int[,] GenerateMatrix(int row, int col, int minRange, int maxRange)
{
  int[,] tempMatrix = new int[row, col];
  Random rand = new Random();

  for (int i = 0; i < tempMatrix.GetLength(0); i++)
    for (int j = 0; j < tempMatrix.GetLength(1); j++)
      tempMatrix[i, j] = rand.Next(minRange, maxRange + 1);

  return tempMatrix;
}

int ReadInt(string msg)
{
  System.Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

Main();
