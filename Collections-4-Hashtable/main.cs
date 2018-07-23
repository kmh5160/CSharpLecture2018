using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    Hashtable ht = new Hashtable();
    ht.Add("txt", "notepad.exe");
    ht.Add("bmp", "paint.exe");
    ht.Add("dib", "paint.exe");
    ht["rtf"] = "wordpad.exe";
    Console.WriteLine (ht.Count == 4);

    try{
      ht.Add("txt", "winword.exe");
    } catch(Exception e) {
      Console.WriteLine("already exists: " + e.Message);
    }
    ht.Remove("bmp");
    Console.WriteLine(ht.ContainsKey("bmp") == false);
  }
}