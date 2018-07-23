using System;

class Node {
  public string data;
  public Node next;
}

class LinkedList {
  Node head, tail;

  public int Count { get; private set; }

  public LinkedList() {
    head = tail = null;
  }
  public void AddFirst(string obj) {
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
    if (head == null)
      head = tail = newNode;
    else {
      newNode.next = head;
      head = newNode;
    }
    Count++;
  }
  public void AddLast(string obj) {
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
    if (head == null)
      head = tail = newNode;
    else {
      tail.next = newNode;
      tail = newNode;
    }
    Count++;
  }
  public string RemoveFirst() {
    if (head == null)
      return string.Empty;
    else {
      string v = head.data;
      head = head.next;
      Count--;
      return v;
    }
  }
  public string RemoveLast() {
    if (head == null)
      return string.Empty;
    else {
      string v = tail.data;
      //head = head.next;
      Count--;
      return v;
    }
  }
  public string Stringify() {
    Node current = head;
    string s = "";
    while(current != null) {
      s += current.data;
      current = current.next;
    }
    return s;
  }
  public string ReverseStringify() {
    Node current = tail;
    string s = "";
    while(current != null) {
      s += current.data;
      current = current.next;
    }
    return s;
  }
}

class MainClass {
  public static void Main (string[] args) {
    LinkedList list = new LinkedList();
    list.AddLast("one");
    Console.WriteLine(list.Stringify() == "one");
    list.AddLast("two");
    Console.WriteLine(list.Stringify() == "onetwo");
    list.AddLast("three");
    Console.WriteLine(list.Stringify() == "onetwothree");
    Console.WriteLine(list.ReverseStringify());
    Console.WriteLine(list.RemoveLast());
    Console.WriteLine(list.Count == 2);
    list.AddFirst("four");
    Console.WriteLine(list.Stringify());

    Console.WriteLine(list.RemoveFirst() == "one");
    Console.WriteLine(list.Stringify() == "twothree");
    list.RemoveFirst();
    list.RemoveFirst();
    Console.WriteLine(list.Stringify() == string.Empty);
    Console.WriteLine(list.Count == 0);
  }
}

// AddFirst();
// AddLast();
// RemoveFirst();
// RemoveLast();
// ReverseStringify();
// Double Linked list;