using System;
using System.Collections.Generic;

public static class Exclass {

  public class Student {
    public string Name { get; set; }
    public List<int> Scores { get; set; }
  }

  public static string Stringify<T>(this IEnumerable<T> list) {
    string s = string.Empty;
    foreach(var v in list) {
      s += v.ToString() + " ";
    }
    if (s.Length > 0)
      s = s.Substring(0, s.Length-1);
    return s;
  }

}

class MainClass {
  public static void Main (string[] args) {
    List<Student> students = new List<Student>() {
      new Student() { Name="ctkim", Scores = new int[] { 100, 70, 90, 77, 88 } },
      new Student() { Name="Steve", Scores = new int[] { 77, 60, 90, 77, 55 } },
      new Student() { Name="Brown", Scores = new int[] { 30, 61, 91, 100, 57 } },
      new Student() { Name="Won",   Scores = new int[] { 100, 100, 91, 100, 100 } },
      new Student() { Name="JJ",    Scores = new int[] { 10, 100, 91, 100, 100 } }
    };

    List<Student> nonRepeaters =
      list.FindAll(student => student.Scores.TrueForAll(score => score >= 60));
    Console.WriteLine(nonRepeaters.Stringify() == "ctkim Won");
    List<Student> repeaters =
      list.FindAll(student => !student.Scores.TrueForAll(score => score >= 60));
    Console.WriteLine(repeaters.Stringify() == "Steve Brown JJ");

    // students.ForEach( students.Scores => {
    //   if ( students.Find(students.Scores => students.Scores >= 65) != 0 ) {
    //     nonRepeaters.Add(students.Name);
    //   };
    // });

    // 60점 미만의 낙제생 리스트(이름) 구하기:
    // 낙제생이 아닌 사람들 리스트(이름) 구하기:
    // Test:
    // List<Student> nonRepeaters;
    // List<Student> repeaters;
    // Console.WriteLine (nonRepeaters.Stringify() == "ctkim Won");
    // Console.WriteLine (repeaters.Stringify() == "Steve Brown")
  }
}