int Num, cnt = 0;
 Num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[Num];
for (int i = 0; i < Num; i++)
{
  arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < Num-1; i++)
{
  if(arr[i] != arr[i+1])
  {
    cnt++;
  }

}
System.Console.WriteLine();
System.Console.WriteLine(cnt+1);

