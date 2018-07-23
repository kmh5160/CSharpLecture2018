using System;

class MainClass {

  class Book {
    // 1
    string title;
    public string GetTitle() { return title; };
    public void SetTitle(string title) {this.title = title};

    // 2
    public string Title {
      get {
        return title;
      }
      set {
        title = value;
      }
    }

    // 3
    public string Title { get; private set; }

    // public string Title {
    //   get {
    //     Console.WriteLine("get()"); return title;
    //   }
    //   set {
    //     title = value != "" ? value : "N/A";
    //   }
    // }
  }
  public static void Main (string[] args) {
    Book b = new Book();
    b.Title = "TLOR";
    Console.WriteLine(b.Title == "TLOR");
    b.Title = "";
    Console.WriteLine(b.Title == "N/A");
  }
}