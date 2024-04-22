// <тип_возвращаемого_значения> <название_функции> (принимаемые аргументы)
// {
//   тело функции
// }

double Function(int firstValue, int secondValue, int thirdValue)
{
  double res = Math.Round(Math.Pow(firstValue, secondValue) * Math.Sqrt(thirdValue) / (firstValue + secondValue), 3);
  return res; //оператор return говорит, что все вычисления завершены и мы возвращаем результат, например в строку 23
}

int a = 7;
int b = 8;
int c = 12;

int a1 = 8;
int b1 = 4;
int c1 = 9;

double result = Math.Round(Math.Pow(a, b) * Math.Sqrt(c) / (a + b), 3);
System.Console.WriteLine(result);

double result1 = Function(a, b, c); //1331323,764
System.Console.WriteLine(result1);

double result2 = Function(a1, b1, c1);
System.Console.WriteLine(result2);

double result3 = Function(5, b1, 1);
System.Console.WriteLine(result3);