using System;

delegate void Callback();

class LivingEntity {
  public float health = 100;
  public virtual void TakeDamage(float damage){
    health -= damage;
    Console.WriteLine("HP: " + health);
  }
}

class Enemy : LivingEntity {
  public event Callback OnDeath;

  public override void TakeDamage(float damage) {
    if (damage >= health) {
      OnDeath();
      health = 0;
    } else
      base.TakeDamage(damage);
  }

  public void DrawEffect() {
    Console.WriteLine("Death effect");
  }
}

class Player : LivingEntity {
  public int XP { get; private set; } = 100;
  public override void TakeDamage(float damage) {
    if (damage >= health) {
      Console.WriteLine("Revive");
      health = 100;
    } else
      base.TakeDamage(damage);
  }
  public void IncreaseExp() {
    XP += 50;
    Console.WriteLine("Add user's XP point: " + XP);
  }
}

class MainClass {
  public static void Main (string[] args) {
    Enemy e = new Enemy();
    Player p = new Player();

    e.OnDeath += p.IncreaseExp;
    e.OnDeath += e.DrawEffect;

    Console.WriteLine(p.XP == 100);
    e.TakeDamage(120);
    Console.WriteLine(p.XP == 150);

    // e.OnDeath(); // error
  }
}