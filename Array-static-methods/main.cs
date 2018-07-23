using System;

class User {
  public string Name { get; set; }
  public int Age { get; set; }
  public User(string name, int age) {
    Name = name; Age = age;
  }
}

class MainClass {
  public static string Stringify(int[] list){
    string s = string.Empty;
    for(int i=0; i<list.Length; i++){
      s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
    }
    return s;
  }
  public static void Main (string[] args) {
    int[] scores = new int[] {2, 4, 5, 3, 6, 8, 1, 7};

    Console.WriteLine(scores.GetType().ToString() == "System.Int32[]");
    Console.WriteLine(scores.GetType().BaseType.ToString() == "System.Array");
    Console.WriteLine(Stringify(scores) == "2 4 5 3 6 8 1 7");

    Array.Sort( scores );
    Console.WriteLine(Stringify(scores) == "1 2 3 4 5 6 7 8");
    Array.Sort( scores, (x, y) => (y-x)/*y.CompareTo(x)*/ );
    Console.WriteLine(Stringify(scores) == "8 7 6 5 4 3 2 1");

    Console.WriteLine(1.CompareTo(2));
    Console.WriteLine(1.CompareTo(1));
    Console.WriteLine(2.CompareTo(1));

    User[] users = new User[3] {
      new User("Betty", 23),
      new User("Susan", 20),
      new User("Lisa", 25)
    };
    Array.Sort( users, (user1, user2) => user1.Age.CompareTo(user2.Age) );
    foreach(var user in users)
      Console.WriteLine(user.Name + user.Age + " ");
  }
}