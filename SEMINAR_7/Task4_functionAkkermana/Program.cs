int A(int m, int n)
{
  if(m == 0) //еслм м равно 0, то она возвращает тото
  return n + 1; // дописать самим
  else if (n == 0)
  return A(m-1, 1);
  else 
  return A(m-1, A(m, n-1)); //и что возвращает
}
System.Console.WriteLine(A(2,2));
//не вводить больше 3 3 иначе переполнится стэк