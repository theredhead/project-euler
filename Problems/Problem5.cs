using System;

namespace Red.Euler.Problems;

public class Problem5 : Problem
{
  public Problem5() : base(5, "Smallest multiple", "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?")
  {}

  public override long Solve()
  {
    long n = 20;
    while (true)
    {
      bool divisible = true;
      for (int i = 2; i <= 20; i++)
      {
        if (n % i != 0)
        {
          divisible = false;
          break;
        }
      }
      if (divisible)
      {
        return n;
      }
      n++;
    }
  }
}
