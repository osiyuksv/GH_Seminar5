// заменить отрицательные элементы на положительные, и наоборот,
// в рандомном массиве с 12 элементами в диапазоне [-9, 10]
int[] arr0 = new int[12];

for (int i = 0; i < arr0.Length; i++)
  {
    arr0[i] = new Random().Next(-9, 10); 
  }
Console.WriteLine(String.Join((", "), (arr0))); 

for (int j = 0; j < arr0.Length; j++)
  {
    arr0[j] = -arr0[j];
  }
Console.WriteLine(String.Join((", "), (arr0)));
