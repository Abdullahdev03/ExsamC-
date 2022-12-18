

int FindMinimum(int a,int b,int c,int d)
{
  int minm;
  minm = a;
  if(b < minm){minm = b;}
  if(c < minm){minm = c;}
  if(d < minm){minm = d;}
  return minm;
}
int a,b,c,d;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindMinimum(a,b,c,d));