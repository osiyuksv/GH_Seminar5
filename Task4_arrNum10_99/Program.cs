// в рандомном массиве выводить сколько 
// элементов в диапазоне 10-99
int[] arr0 = new int[12];
int count = 0;

  for (int i = 0; i < arr0.Length; i++)
  {
    arr0[i] = new Random().Next(1, 1000);

    if((arr0[i] > 10) && (arr0[i] < 100)) count ++;
  }

Console.WriteLine(String.Join((", "), (arr0)));
Console.WriteLine(count);

