Console.WriteLine("Введите N");
int val2 = 0;
while (val1 != 0)
{
 int o = val1 % 10;
 val1 =val1 / 10;
 val2 = val2 * 10 + o;
}
Console.WriteLine(val2);
Console.WriteLine(t == val2);
