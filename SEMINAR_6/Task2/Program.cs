// Задание 2. На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

void Main()
{
  // 1-й вариант, но его нельзя использовать по условию задачи (ToCharArray() не использовать.)
  //   System.Console.Write("Введите текст: ");
  //   string? str = Console.ReadLine(); // знак вопроса говорит о том, что мы знаем, что там пустое значение NULL

  //   char[] chars = str!.ToCharArray();
  //   PrintArray(chars);
  // }

  // void PrintArray(char[] chars)
  // {
  //   System.Console.WriteLine("[" + string.Join(", ", chars) + "]");
  // }


  // 2-й вариант:
  System.Console.Write("Введите текст: ");
  string? str = Console.ReadLine(); // знак вопроса говорит о том, что мы знаем, что там пустое значение NULL
  char[] chars = StringToCharArray(str);
PrintArray(chars);
}

char[] StringToCharArray(string? str)
{
  char[] tempChars = new char[str!.Length];//объявляем пространство и задаем столько элементов, сколько в нашей
                                          //исходной строке. То есть сколько символов было в строке столько ячеек памяти будет в нашем временном массиве tempChars

  for (int i = 0; i < str.Length; i++)
    tempChars[i] = str[i];  //обращаемся к строке как к массиву. Такое обращение возвращает тип данных char
  return tempChars;
}


void PrintArray(char[] chars)
{
  System.Console.WriteLine("[" + string.Join(", ", chars) + "]");
}
Main();