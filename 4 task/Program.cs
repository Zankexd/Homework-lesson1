int a = new Random().Next(1,50);
int b = new Random().Next(1,50);
int c = new Random().Next(1,50);


Console.Write (a+",");
Console.Write (b+",");
Console.Write (c+",");

int max = a;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;



Console.WriteLine("max="+max);

