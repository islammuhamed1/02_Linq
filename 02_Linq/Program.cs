using _02_Linq.Files;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using static _02_Linq.ListGenerator;
namespace _02_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            //Q1
            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);
            //Q2
            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 1000);
            //Console.WriteLine(result?.ProductName ?? "Not Found");
            //Q3
            //int[] Arr = { 5,4,1,3,9,8,6,7,2,0};
            //var result = Arr.Where( n => n > 5).ElementAt(1);
            //Console.WriteLine(result);
            #endregion
            #region LINQ - Aggregate Operators
            //Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(i => i % 2 == 1);
            //Console.WriteLine(result);
            //Q2
            //var result = CustomersList.Select(c => new
            //{
            //    c.CustomerName,
            //    OrderCount = c.Orders.Count(),
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Q3
            //var result = ProductsList.Select(p => new
            //{
            //    Category = p.Category,
            //    NumberOfProducts = ProductsList.Count(c => c.Category == p.Category),
            //}).ToHashSet();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            //Q5
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Sum(w => w.Length);

            //Console.WriteLine(result);
            //Q6
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Min(w => w.Length);
            //Console.WriteLine(result);


            //Q7
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Max(w => w.Length);
            //Console.WriteLine(result);

            //Q8
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = (int)words.Average(w => w.Length);

            //Console.WriteLine(result);

            //Q9
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    UnitInStock = p.Sum(s => s.UnitsInStock),
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q10
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    Price = p.Min(p => p.UnitPrice),
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q11   

            //Q12
            //var result = ProductsList.GroupBy(p => p.Category)
            //                         .Select(g => g
            //                         .Where(p => p.UnitPrice == g.Max(p => p.UnitPrice)));

            //foreach (var group in result)
            //{
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"Category : {item.Category} , Price : {item.UnitPrice} , ProductName : {item.ProductName}");
            //    }
            //}

            //Q13
            //var result = ProductsList.GroupBy(p => p.Category)
            //                         .Select(g => g.OrderByDescending(p => p.UnitPrice).First());

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Product: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            //Q14
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    AvgPrice = p.Average(i => i.UnitPrice),
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Set Operators
            //Q1
            //var result = ProductsList.Select(p => p.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Q2
            //var result = ProductsList.Select(p => p.ProductName[0])
            //                         .Union(CustomersList
            //                         .Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q3
            //var result = ProductsList.Select(p => p.ProductName[0])
            //                         .Union(CustomersList
            //                         .Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4
            //var result = (from p in ProductsList select p.ProductName.First())
            //             .Distinct()
            //            .Except(from c in CustomersList select c.CustomerName.First());
            //Console.WriteLine(string.Join(", ", result));

            //Q5
            //var result = ProductsList.Select(p => p.ProductName[^3..])
            //                         .Concat(CustomersList
            //                         .Select(c => c.CustomerName[^3..]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Set Quantifiers
            //Q1
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Any(w => w.Contains("ei"));

            //Console.WriteLine(result);

            //Q2
            //var result = ProductsList.GroupBy(p => p.Category)
            //                         .Where(c => c.Any(p => p.UnitsInStock == 0))
            //                         .Select(p => p);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var p in item)
            //        Console.WriteLine(p);
            //}
            //Q3
            //var result = ProductsList.GroupBy(p => p.Category)
            //                         .Where(c => c.All(p => p.UnitsInStock > 0))
            //                         .Select(p => p);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var p in item)
            //        Console.WriteLine(p);
            //}
            #endregion
            #region LINQ - Partitioning Operators
            //Q1

            //var result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q2
            //var result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, i) => n > i);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, i) => n > i);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ – Grouping Operators
            //Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var number in result)
            //{
            //    Console.WriteLine($"Numbers with remainder of {number.Key} when divided by 5");

            //    foreach (var n in number)
            //        Console.WriteLine(n);
            //}

            //Q2
            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //var result = lines.GroupBy(w => w[0]);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var n in item)
            //        Console.WriteLine(n);
            //}


            //Q3
            //string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            //var result = Arr.GroupBy(w => w.Trim(), new EquailityComparer());

            //foreach (var item in result)
            //{
            //    foreach (var word in item)
            //        Console.WriteLine(word);
            //}
            #endregion
        }
        class EquailityComparer : IEqualityComparer<string>
        {
            public bool Equals(string? x, string? y)
            {
                return Sort(x) == Sort(y);
            }

            public int GetHashCode([DisallowNull] string obj)
            {
                return Sort(obj).GetHashCode();
            }

            string Sort(string obj)
            {
                var word = obj.ToCharArray();
                Array.Sort(word);
                return new string(word);
            }
        }
    }
}
