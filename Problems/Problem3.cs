using System;

namespace Red.Euler.Problems;

public class Problem3 : Problem
{
  public Problem3() : base(3, "Largest prime factor", "What is the largest prime factor of the number 600851475143?")
  {}

  public override long Solve()
  {
    long n = 600851475143;
    long factor = 2;
    while (n > 1)
    {
      if (n % factor == 0)
      {
        n /= factor;
      }
      else
      {
        factor++;
      }
    }
    return factor;
  }
}
