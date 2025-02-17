using System;

namespace Red.Euler.Problems;

public class Problem10 : Problem
{
  public Problem10() : base(10, "Summation of primes", "Find the sum of all the primes below two million.")
  {
  }

  override public long Solve()
  {
    long sum = 0;
    for (var i = 2; i < 2000000; i++)
    {
      if (i.IsPrime())
      {
        sum += i;
      }
    }
    return sum;
  }
}
