// https://www.csharp-examples.net/
using System;
using System.Collections.Generic;

public class MyComparer : IComparer<int>
{
    public int Compare(int x, int y) { return x.CompareTo(y); }
}

class MainClass {
  public static void Main (string[] args) {
    // var listA = new List<int>() { 8, 3, 2 };
    // var listB = new List<int>(listA);
    // listA.Add(5);

    var listA = new List<int>() { 8, 3, 2 };
    var listB = new List<int>() { 5, 7 };
    listA.AddRange(listB);

    foreach( var l in listA ){
      Console.Write(l);
    }
    Console.WriteLine();

    Console.WriteLine(listA.BinarySearch(7) == 4);
    Console.WriteLine(listA.BinarySearch(7, new MyComparer() ) == 4);
    Console.WriteLine(listA.BinarySearch(1, 3, 5, new MyComparer() ) == 3);
    Console.WriteLine(listA.Contains(3));
    Console.WriteLine(listA.Contains(6));

    var conv = new Converter<int, decimal>(x => (decimal)(x+1));
    var listC = listA.ConvertAll<decimal>(conv);
    foreach( var l in listC ){
      Console.Write(l);
    }
    Console.WriteLine();
    
  }
}