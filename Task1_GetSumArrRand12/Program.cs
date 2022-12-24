// найти сумму отрицательных и положительных элементов 
// рандомного массива с 12 элементами в диапазоне [-9, 9]
int[] arr0 = new int[12];
int sumplus = 0;
int summinus = 0;

  for (int i = 0; i < arr0.Length; i++)
  {
    arr0[i] = new Random().Next(-9, 10);

    if(arr0[i] > 0) 
    {
      sumplus += arr0[i];
    }
      else summinus += arr0[i];
  }

Console.WriteLine(String.Join((", "), (arr0)));
Console.WriteLine(sumplus);
Console.WriteLine(summinus);

