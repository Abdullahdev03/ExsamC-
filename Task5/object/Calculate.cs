Calculator calc = new Calculator();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
var zarb = calc.Multiple( a,  b);
var tacsim = calc.Division(a, b);

System.Console.WriteLine(zarb);
System.Console.WriteLine(tacsim);