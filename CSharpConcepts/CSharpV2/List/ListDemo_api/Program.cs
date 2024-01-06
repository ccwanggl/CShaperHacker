// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

List<int> list = new List<int>();
for (int i = 0; i < 100; i++)
{
    list.Add(i);
    Console.WriteLine($"{list.Count}/{list.Capacity}");
}
Console.WriteLine(String.Join(",", list));
