using System.Linq;

List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
Func<List<int>, int> func = c => c.Min();
Console.WriteLine(func(ints));