// выводить есть ли заданное число в массиве
int[] arr = {6, 7, 19, 345, 3};

Console.WriteLine("введите число N");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == num) sum ++;
  }

if(sum > 0) Console.WriteLine("да");
else Console.WriteLine("нет");
