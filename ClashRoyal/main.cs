using System;

  class Card {
    public enum Type { Unit, Build, Magic };
    public enum Grade { Normal, Rare, Hero, Legend };

    public string name;
    public Type type;
    public Grade grade;
    public float attSpd;
    public string movSpd;
    public float time;
    public string range;
    public string target;
    public int elx_cost;
    public int unt_cost;
    
    public Card(string _name, float _attSpd, string _movSpd, float _time, string _range, string _target, int _elx_cost, int _unt_cost, Type _type, Grade _grade) {
    
      name = _name;
      attSpd = _attSpd;
      movSpd = _movSpd;
      time = _time;
      range = _range;
      target = _target;
      elx_cost = _elx_cost;
      unt_cost = _unt_cost;
      type = _type;
      grade = _grade;

    }

  }

class MainClass {

  public static void Main (string[] args) {
    Card knight = new Card("기사", 1.2f, "보통", 1, "근접", "지상", 3, 1, Card.Type.Unit, Card.Grade.Normal);
    Card wizard = new Card("마법사", 1.4f, "보통", 1, "5.5", "지상 및 공중", 1, 1, Card.Type.Unit, Card.Grade.Rare);
    Card cannon = new Card("대포", 0.8f, "", 1, "5.5", "지상", 1, 0, Card.Type.Build, Card.Grade.Normal);
    Card bow = new Card("대형 석궁", 0.25f, "", 3.5f, "11.5", "지상", 6, 0, Card.Type.Build, Card.Grade.Hero);
    Card fireball = new Card("파이어 볼", 0f, "", 0, "2.5", "", 4, 0, Card.Type.Magic, Card.Grade.Rare);

    Card[] cards = new Card[10];
    cards[0] = knight;
    cards[1] = wizard;
    cards[2] = cannon;
    cards[3] = bow;
    cards[4] = fireball;

    foreach(var c in cards) {
      Console.WriteLine(c.name + "\n공격속도 : " + c.attSpd + "\n이동속도 : " + c.movSpd + "\n배치시간 : " + c.time + "\n사정거리 : " + c.range + "\n공격대상 : " + c.target + "\n엘릭서비용 : " + c.elx_cost + "\n유닛수 : " + c.unt_cost + "\n희귀도 : " + c.grade + "\n유형 : " + c.type);
    }

    // Console.WriteLine(knight.type);

  }

}