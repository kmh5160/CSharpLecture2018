using System;
using System.Collections;
using System.Collections.Generic;

public class Person {
  public string Name { get; set; }
  public override string ToString() { return Name; }
}

public class People : IEnumerable<Person> {
  public List<Person> list { get; set; }
  public IEnumerator<Person> GetEnumerator() { return list.GetEnumerator(); }
  // public IEnumerator<Person> GetEnumerator() { return new PersonEnumerator(list); }
  IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

  private class PersonEnumerator : IEnumerator<Person> {
    int position = -1;
    List<Person> list;

    public PersonEnumerator(List<Person> list) { this.list = list; }

    public Person Current { 
      get{ return list[position]; }
    }
    object IEnumerator.Current {
      get { return Current; }
    }
    public bool MoveNext() {
      if (position < list.Count - 1) {
        position++;
        return true;
      } else
        return false;
    }
    public void Reset() { position = -1; }
    public void Dispose() { }
  }
}

class MainClass {
  public static void Main (string[] args) {
    People p = new People();
    p.list = new List<Person>() {
      new Person() {Name="ctkim"},
      new Person() {Name="WonLee"},
      new Person() {Name="JJ"}
    };

    foreach(var person in p)
      Console.WriteLine (person.Name);
  }
}