using System;

class Stack<T> {
  T[] data;
  int top = -1;
  int size;

  public int Count{ get; private set; }

  public Stack(int size) {
    data = new T[size];
    this.size = size;
    Count = 0;
  }
  public void Push(T value){
    if (top == size - 1)
      return;
    data[++top] = value;
    Count++;
  }
  public T Pop(){
    if (top == -1)
      return (T)Convert.ChangeType(-1, typeof(T));// default(T);
    Count--;
    return data[top--];
  }
}

class MainClass {
  public static void Main (string[] args) {
    Stack<int> s = new Stack<int>(3);
    Console.WriteLine(s.Count == 0);
    s.Push(10);
    Console.WriteLine(s.Count == 1);
    s.Push(20);
    Console.WriteLine(s.Count == 2);
    s.Push(30);
    Console.WriteLine(s.Count == 3);
    s.Push(40);
    Console.WriteLine(s.Count == 3);
    Console.WriteLine(s.Pop() == 30);
    Console.WriteLine(s.Pop() == 20);
    Console.WriteLine(s.Pop() == 10);
    Console.WriteLine(s.Count == 0);
    Console.WriteLine(s.Pop() == -1); // empty
    //s.Count = 10; // error

    Stack<string> s2 = new Stack<string>(3);
    Console.WriteLine(s2.Count == 0);
    s2.Push("one");
    Console.WriteLine(s2.Count == 1);
    s2.Push("two");
    Console.WriteLine(s2.Count == 2);
    s2.Push("three");
    Console.WriteLine(s2.Count == 3);
    s2.Push("four");
    Console.WriteLine(s2.Count == 3);
    Console.WriteLine(s2.Pop() == "three");
    Console.WriteLine(s2.Pop() == "two");
    Console.WriteLine(s2.Pop() == "one");
    Console.WriteLine(s2.Count == 0);
    Console.WriteLine(s2.Pop() == "-1"); // empty
  }
}