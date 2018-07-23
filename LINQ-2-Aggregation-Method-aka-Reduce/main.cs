using System;
using System.Linq; // class extension

class MainClass {
  public static void Main (string[] args) {
    int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    Console.WriteLine (numbers.Sum() == 55);
    Console.WriteLine (numbers.Average() == 5.5);
    Console.WriteLine (numbers.Max() == 10);
    Console.WriteLine (numbers.Min() == 1);
    Console.WriteLine (numbers.Count() == 10);
    Console.WriteLine (numbers.First() == 1);
    Console.WriteLine (numbers.Last() == 10);

    Console.WriteLine(numbers.Aggregate(0, (memo, n) => memo + n) == 55); // Sum
    Console.WriteLine(numbers.Aggregate((memo, n) => memo + n) == 55);    // Sum
    Console.WriteLine(numbers.Aggregate((memo, n) => memo + 1) == 10);    // Count
    Console.WriteLine(numbers.Aggregate((memo, n) => n > memo ? n : memo) == 10); // Max
    Console.WriteLine(numbers.Aggregate(int.MaxValue, (memo, n) => n < memo ? n : memo) == 1); // Min
    
    var str = new [] {"a", "b", "c", "d"};
    Console.WriteLine(str.GetType().ToString());
    // var csv = str.Aggregate();
    Console.WriteLine(str.Aggregate( (memo, b) => memo + "," + b) == "a,b,c,d");
  }
}