using System.Collections.Generic;

namespace LeetCodeExercise_String;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<int> l1 = new List<int>();
        l1.Add(1);
        l1.Add(2);
        l1.Add(3);
        l1.Add(4);
        l1.Add(5);
        l1.Add(6);
        string s= string.Join("->", l1);
        Console.WriteLine(s);
        Console.WriteLine(l1.Count);
        l1.RemoveAt(l1.Count - 1);
        Console.WriteLine(s);
        Console.WriteLine(l1.Count);
        Console.ReadKey();
    }
}

