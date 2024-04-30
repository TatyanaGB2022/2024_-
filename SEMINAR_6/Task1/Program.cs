// Задание 1. Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

void Main()
{
  char[] chars = { 'a', 'b', 'c', 'd' }; //1. задали массив

  /* 1-й вариант решения, но его использовать запрещено условием задачи
  string str = new string(chars); // делаем из массива строку*/

  // 2-й вариант:
  //   string str = ArrayToString(chars); // 1. создаем строку str и выделяем ей пустое пространство ""
  //   System.Console.WriteLine(str); // 3. выводим и проверяем на работоспособность
  // }

  // string ArrayToString(char[] chars)
  // {
  //   string str = "";

  //   foreach (char letter in chars)
  //     str += letter;// 2. перебираем каждую букву 

  //   return str;
  // }


  //3-й вариант:
  //   string str = string.Concat(chars); // метод Concat все элементы массива любого типа склеивает в одну строчку
  //   System.Console.WriteLine(str); // 3. выводим и проверяем на работоспособность
  // }

  // string ArrayToString(char[] chars)
  // {
  //   string str = "";

  //   foreach (char letter in chars)
  //     str += letter;// 2. перебираем каждую букву 

  //   return str;
  // }


  // 4-й вариант:
  string str = string.Join("", chars); //если сделать ",  ", chars - то результат будет выводится через запятую и пробел
  System.Console.WriteLine(str); // 3. выводим и проверяем на работоспособность
}

string ArrayToString(char[] chars)
{
  string str = "";

  foreach (char letter in chars)
    str += letter;// 2. перебираем каждую букву 

  return str;
}

Main();