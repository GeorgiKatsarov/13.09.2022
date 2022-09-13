using System.Linq;

string[] strings = Console.ReadLine().Split();
Action<string> printStrings = (x) => Console.WriteLine(x);
strings.ToList().ForEach(x => printStrings(x));