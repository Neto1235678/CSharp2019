using System;

   

class MainClass {

    public static void Main (string[] args) {

      Card hg = new Card(6, 3, "기사", "I'm Knight!!!", "18/100", 960, 109, 120, 1.1, "지상", "보통" , "근접", "1초" );
      hg.rarity = Card.Rarity.Common;
      hg.type = Card.Type.Troop;
      Console.WriteLine("레벨" + hg.Level + " " + hg.Name + "\n" + "\n" + "코스트" + hg.ElixirCost + ", " + "희귀도: " + "유형: "  + "\n" + "         " + hg.rarity + "  " +hg.type + "\n" + "\n" + "         "+ hg.Explanation + "\n" + "\n" + hg.ElixirBar + "\n" + "\n" + "Hp" + "       " + "초당피해량" + "\n" + hg.HitPoints + "      " + hg.DamagePerSecond + "\n" + "\n" + "피해량" + "  " + " 공격속도" + "\n" + hg.AreaDamage + "      " + hg.HitSpeed + "\n" + "\n" + "공격대상" + "" + " 속도" + "\n" + hg.Taget + "     " + hg.RunSpeed + "\n" + "\n" + "사정거리" + "" + " 배치시간" + "\n" + hg.Range + "     " + hg.DeployTime);
  }  

}

public class Card{

    /*public enum Rarity{ Common, Rare, Epic, Legendary}; // 등급
    public int Level; // 레벨
    public string Explanation;// 내용
    public enum Name{Knight, Wizard}; // 이름
    public enum Type{Troop, Building, Spell}; // 유형
    public int ElixirCost; // 엘릭서

    public enum Range{RangeNum, Melee}; // 사정거리
    public enum Target{Ground, AirAndGround, Building}; // 공격 대상
    public enum PublicAbility{ HitPoints, HitSpeed, UniyCount};
    public enum UniyAbility{};
    public enum BuildingAbility{};
    public enum SpellAbility{};
    public enum CopyMagicCardAbility{};
    public enum Attack{AreaDamage, DamagePerSecond};
    public enum Time{DeployTime};
    public enum RunSpeed{Slow = 45, Medium = 60, Fast = 75, VeryFast = 90};*/

    public enum Rarity{ Common = 0, Rare = 1, Epic = 2, Legendary = 3}; // 등급
    public Rarity rarity;
    public int Level; // 레벨
    public string ElixirBar;
    public string Explanation;// 내용
    public string Name; // 이름
    public enum Type{Troop = 0, Building = 1, Spell = 2}; // 유형
    public Type type;
    public int ElixirCost; // 엘릭서

    public string Range; // 사정거리
    public string Taget; // 공격 대상
    public int HitPoints;
    public double HitSpeed;
    public int UniyCount;
    public int AreaDamage;
    public int DamagePerSecond;
    public string DeployTime;
    public string RunSpeed;
 
 public Card(int _level, int _elixircost, string _name, string _explanation, string _elixirbar, int _hitpoints, int _damagepersecond, int _areadamage, double _hitspeed, string _taget, string _runspeed , string _range, string _deploytime){
//, int _range, string _taget, int _hitpoints, int _hitspeed, int _uniycount, int _areadamage, int _damagepersecond, int _deploytime, int _runspeed
  
  this.Level = _level;
  this.Explanation = _explanation;
  this.Name = _name;
  this.ElixirCost = _elixircost;
  this.ElixirBar = _elixirbar;
  this.Range = _range;
  this.Taget = _taget;
  this.HitPoints = _hitpoints;
  this.HitSpeed = _hitspeed;
  // this.UniyCount = _uniycount;
  this.AreaDamage = _areadamage;
  this.DamagePerSecond = _damagepersecond;
  this.DeployTime = _deploytime;
  this.RunSpeed = _runspeed;
   
 }
}

// 기사 class 함수를 정의 해보자. 추상화로
// Bubble sort 짜오기 