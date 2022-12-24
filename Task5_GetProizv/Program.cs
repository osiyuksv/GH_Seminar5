// в рандомном массиве выводить 
// произведение зеркальных пар элементов
Console.WriteLine("Введите длину массива");
int lehgth1 = Convert.ToInt32(Console.ReadLine());
int[] arr0 = new int[lehgth1];

int length = arr0.Length / 2 + arr0.Length % 2;
int[] arr1 = new int[length];

  for (int i = 0; i < arr0.Length; i++)
  {
    arr0[i] = new Random().Next(1, 10);
  }

Console.WriteLine(String.Join((", "), (arr0)));


 for (int j = 0; j < length; j++)
  {
    arr1[j] = arr0[j] * arr0[arr0.Length - 1 - j];
    Console.Write(arr1[j] + " ");
  }
Console.WriteLine();
Console.WriteLine(String.Join((", "), (arr1)));
  