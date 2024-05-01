// Задание 3. Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

//Метод проверяющий на гласные
// void Main()
// {
//   System.Console.WriteLine(isConsonant('a'));
// }

// void PrintConsonant(string str)
// {

// }

// bool isConsonant(char c)
// {
//   return "bcdfghjklmnpqrstvxz".Contains(c);
// }

// Main();

void Main()
{
  System.Console.Write("Введите текст: ");
  string? str = Console.ReadLine();
  PrintConsonant(str);
}

void PrintConsonant(string? str)
{
  if (str!.Length < 1) return; //условие остановки
char tempChar = char.ToLower(str[0]); //перевод исходной буквы в нижний регистр и сохнение ее в отдельную переменную tempChar
  if (isConsonant(tempChar))  //если tempChar является согласной буквой, то 
    System.Console.Write(str[0] + " ");   //тогда выводим наш элемент оригинальной строки str[0]

  PrintConsonant(str[1..]); //вызываем метод и в качестве строки передаем ту же самую строчку, но только в диапазоне 
                            //без первого нулевого элемента. Таким образом наша строчка будет терять первый символ и так мы будем перемещаться 
                            //по всему слову
}

bool isConsonant(char c)
{
  return "bcdfghjklmnpqrstvxzw".Contains(c);
}

Main();