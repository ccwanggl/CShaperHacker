// See https://aka.ms/new-console-template for more information

Type t = typeof(int);
Console.WriteLine(t.Namespace);
Console.WriteLine(t.FullName);
Console.WriteLine(t.Name);


int c = t.GetMethods().Length;
foreach(var mi in t.GetMethods())
{
    Console.WriteLine(mi.Name);
}


Console.WriteLine(c);
