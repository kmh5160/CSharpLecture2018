using System;
using System.Collections.Generic;

public static class Exclass {

  // public static string Stringify<T>(this List<T> list) {
  //   string s = string.Empty;
  //   for(int i = 0; i < list.Count; i++)
  //     s += i != list.Count-1 ? list[i] + " " : list[i].ToString();
  //   return s;
  // }

  // public static string Stringify(this int[] list) {
  //   string s = string.Empty;
  //   for(int i = 0; i < list.Length; i++)
  //     s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
  //   return s;
  // }

  public static string Stringify<T>(this IEnumerable<T> list) {
    string s = string.Empty;
    foreach(var v in list) {
      s += v.ToString() + " ";
    }
    if (s.Length > 0)
      s = s.Substring(0, s.Length-1);
    return s;
  }

  class Student {
    public string Name;
    public int[] Scores;

    public override string
  }  
}

class MainClass {
  public static void Main (string[] args) {
    List<int> list = new List<int> { 8, 3, 2 };
    Console.WriteLine (list.Stringify() == "8 3 2");

    int[] array = list.ToArray();
    Console.WriteLine (array.Stringify() == "8 3 2");

    Console.WriteLine( "lecture".Stringify() == "l e c t u r e");
    Console.WriteLine( (new char[] { 'l', 'e', 'c' }).Stringify() == "l e c");
    Console.WriteLine( (new int[] { 1 }).Stringify() == "1");

    List<Student> students = new List<Student>() {
      new Student() { Name="ctkim", Scores = new int[] { 100, 70, 90, 77, 88 } },
      new Student() { Name="ctkim", Scores = new int[] { 100, 70, 90, 77, 88 } },
      new Student() { Name="ctkim", Scores = new int[] { 100, 70, 90, 77, 88 } },
      new Student() { Name="ctkim", Scores = new int[] { 100, 70, 90, 77, 88 } },
      new Student() { Name="ctkim", Scores = new int[] { 100, 70, 90, 77, 88 } },
    };
    Console.WriteLine( students.Stringify() == )
  }
}