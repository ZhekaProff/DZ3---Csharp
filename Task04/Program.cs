// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число а: ");
int a =  int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите нужную степень: ");
int b =  int.Parse(Console.ReadLine() ?? "0");
int summa = 1;
for ( int i = 1; i <= b; i++) 
     summa = summa * a;    
Console.WriteLine($"С {summa}");
