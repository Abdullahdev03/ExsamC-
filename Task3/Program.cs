int Num,sum=1;
 Num = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= Num; i++)
{
  sum += Math.Pow(i,2);
}
  System.Console.WriteLine(sum);
