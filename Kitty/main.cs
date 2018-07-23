using System;

class Kitty {
  public enum CatTribute { Topaz, Jaguar, Crazy, RoyalPurple };

  public string name;
  public string owner;
  public int id;
  public CatTribute[] CatTributes;
  public Kitty[] children;
  public Kitty[] parents;
}

class MainClass {
  public static void Main (string[] args) {
    Kitty kt = new Kitty();
    kt.name = "Founder #3";
    kt.owner = "0x243fdfsfd2fd";
    kt.id = 3;
    kt.CatTributes = new Kitty.CatTribute[10];
    kt.CatTributes[0] = Kitty.CatTribute.Topaz;
    kt.CatTributes[1] = Kitty.CatTribute.Jaguar;
    kt.children = new Kitty[10];
    kt.children[0] = new Kitty();
    kt.children[0].name = "Genesis";

    Console.WriteLine(kt.name == "Founder #3");
    Console.WriteLine(kt.CatTributes[0]);
    Console.WriteLine(kt.children[0].name == "Genesis");
  }
}