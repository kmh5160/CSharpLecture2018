using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    var names = new List<string>() { "john", "Tom", "Peter" };

    string s = string.Empty;
    foreach(var name in names)
      s += name + " ";
    Console.WriteLine (s == "John Tom Peter");

    s = string.Empty;
    var e = names.GetEnumerator();
    while( e.MoveNext() ) {
      s += e.Current + " ";
    }
    Console.WriteLine ( s == "John Tom Peter");
  }
}