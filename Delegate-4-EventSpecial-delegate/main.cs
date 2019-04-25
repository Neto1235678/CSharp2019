using System;

// delegate void GameEvent();

class LivingEntity {
  public float health = 100;
  public virtual void TakeDamage(float damage) {
    health -= damage;
    Console.WriteLine("HP: " + health);
  }
}

class Enemy : LivingEntity { // Action return -> void, 파라미터 X
  public event Action OnDeath; //event는 특별한 델리게이터, 등록 삭제는 문제가 없다. 다만 혼자 쓰는 것을 방지

  public override void TakeDamage(float damage) {
    if(damage >= health) {
      OnDeath();
      health = 0;
    }
    else {
    base.TakeDamage(damage);
    }
  }

  public void DrawEffect() {
    Console.WriteLine("Death effect");
  }
}

class Palyer : LivingEntity {
  public int XP {get; private set;} = 100;
  public override void TakeDamage(float damage) {
    if(damage >= health) {
      Console.WriteLine("Revive");
      health = 100;
    }
    else {
      base.TakeDamage(damage);
    }
  }
  
  public void IncreaseExp() {
    XP += 50;
    Console.WriteLine("Add user's " + XP);
  }
}

class MainClass {
  public static void Main (string[] args) {
    Enemy e = new Enemy();
    Palyer p = new Palyer();

    e.OnDeath += e.DrawEffect;
    e.OnDeath += p.IncreaseExp;

    Console.WriteLine(p.XP == 100);
    e.TakeDamage(120);
    Console.WriteLine(150);
     
  }
}