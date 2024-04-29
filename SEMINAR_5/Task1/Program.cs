//Основной скелет для написания программы (создание двумерного массива)

void Main()
{
  int row = ReadInt("Введите количество строк: "); //1. сколько будет строк
  int column = ReadInt("Введите количество столбцов: ");  //1. сколько будет столбцов
  int[,] myMatrix = GenerateMatrix(row, column, 0, 9);
  PrintMatrix(myMatrix);
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

