using System.Linq;

List<string> list = Console.ReadLine().Split().ToList();
list.RemoveAll(s => string.IsNullOrWhiteSpace(s));
Action<string> printStrings = (x) => Console.WriteLine("Sir "+x);
list.ForEach(x => printStrings(x));