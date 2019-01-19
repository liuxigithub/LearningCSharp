/*if语句*/
using System;

namespace if_ts {
  class if_me {
    static public void Main(string[] args) {
      double x, y;
      Console.WriteLine("input x: (0<=x<=300)");
      x = Convert.ToDouble((Console.ReadLine()));
      if (x<=100)
        y = x;
      else if (x>100&&x<200)
        y = 100;
      else
        y = 300 - x;
      Console.WriteLine("y = {0}",y);
      Console.ReadLine();

    }
  }
}
