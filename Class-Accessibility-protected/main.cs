using System;


class Point {
  protected int x; // 내 자식은 접근이 가능하게 된다.
  protected int y;
}


class DerivedPoint : Point {
  public static void Main (string[] args) {
    DerivedPoint depoint = new DerivedPoint();
    depoint.x = 10;
  }
}