
string b = Console.ReadLine();
int a = int.Parse(b);

int count = 1;
while(a>count)
{
if(count%2==0)
{
Console.Write(count);
}
count++;
}