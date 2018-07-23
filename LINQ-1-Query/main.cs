using System;
using System.Collections.Generic;
using System.Linq;

public class Student {
  public string Name { get; set; }
  public int Height { get; set; }
  public List<int> Scores { get; set; }
  public override string ToString() { return Name; }
}

class MainClass {
  public static void Main (string[] args) {
    List<Student> list = new List<Student> {
      new Student() { Name = "ctkim", Height=175, Scores = new List<int>() { 100, 70, 90, 77, 88 }},
      new Student() { Name = "Steve", Height=167, Scores = new List<int>() { 77, 60, 90, 77, 55 }},
      new Student() { Name = "Brown", Height=180, Scores = new List<int>() { 30, 61, 91, 100, 57 }},
      new Student() { Name = "Won",   Height=171, Scores = new List<int>() { 100, 100, 91, 100, 100 }},
      new Student() { Name = "JJ",    Height=165, Scores = new List<int>() { 10, 100, 9, 100, 100 }},
    };

    // List version
    List<Student> ss1 = list.FindAll( s => s.Height < 175 );
    Console.WriteLine(ss1.Stringify() == "Steve Won JJ");
    
    // LINQ version
    var ss2 = from student in list                // list: must be IEnumerable<T> type
             where student.Height < 175           // condition
             select student;                      // ss2: IEnumerable<Student>
    Console.WriteLine(ss2.Stringify() == "Steve Won JJ");

    // even
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var evens = from n in numbers
                where n%2 == 0
                select n;                         // evens: IEnumerable<int>
    Console.WriteLine(evens.Stringify() == "2 4 6 8 10");

    evens = numbers.Where(n => n%2 == 0).Select(n => n);
    Console.WriteLine(evens.Stringify() == "2 4 6 8 10");

    var ss3 = from student in list
             where student.Height < 175
             orderby student.Height
             select student;
    Console.WriteLine(ss3.Stringify() == "JJ Steve Won");

    var ss4 = from student in list
             where student.Height < 175
             orderby student.Height descending
             select student;
    Console.WriteLine(ss4.Stringify() == "Won Steve JJ");

    var ss5 = from student in list
             where student.Height < 175
             orderby student.Height descending
             select student.Name;
    Console.WriteLine(ss5.Stringify() == "Won Steve JJ");

    var ss6 = from student in list
             where student.Height < 175
             orderby student.Height
             select new { Name=student.Name, InchHeight=student.Height * 0.383 };
    Console.WriteLine(ss6.Stringify());

    var ct = new {Name="ctkim", Height=170};
    Console.WriteLine(ct.Name);
    // <>__AnonType1`2[System.String,System.Int32]
    Console.WriteLine(ct.GetType().ToString());

    // 숙제 평균 80이상, 최소 점수 60점 이상 뽑
    var hw = from student in list
             where student.Scores.Average() >= 80 && student.Scores.Min() >= 60
             select student;
    Console.WriteLine("합격자 : " + hw.Stringify());
  }
}

public static class ExClass {
  public static string Stringify<T>(this IEnumerable<T> list) {
    string s = string.Empty;
    foreach(var v in list)
      s += v.ToString() + " ";
    if (s.Length > 0)
      s = s.Substring(0, s.Length-1);
    return s;
  }
}