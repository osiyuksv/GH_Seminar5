// выводить есть ли заданное число в массиве
int[] arr = {6, 7, 19, 345, 3};

Console.WriteLine("введите число N");
int num = int.Parse(Console.ReadLine());
bool  res = false;

for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == num) res = true;
  }

if(res) Console.WriteLine("да");
else Console.WriteLine("нет");
