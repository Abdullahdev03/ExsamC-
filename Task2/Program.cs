int Num,maks, minm;
 Num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[Num];
for (int i = 0; i < Num; i++)
{
  arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < Num-1; i++)
{
  maks = Math.Max(arr[i], arr[i + 1]);
}
for (int i = 0; i < Num-1; i++)
{
  minm = Math.Min(arr[i], arr[i + 1]);
}
for (int i = minm; i < maks; i++)
{
 System.Console.WriteLine(arr[i]); 
}



