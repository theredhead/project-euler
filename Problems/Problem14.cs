using System;

namespace Red.Euler.Problems;

public class Problem14 : Problem
{
  private readonly long limit = 1000000;
  public Problem14() : base(14, "Longest Collatz sequence", "Which starting number, under one million, produces the longest Collatz sequence?")
  {
  }

  public override long Solve()
  {
    long max = 0;
    long maxCount = 0;
    for (long i = 1; i < limit; i++)
    {
      long count = 0;
      long n = i;
      while (n != 1)
      {
        if (n % 2 == 0)
        {
          n /= 2;
        }
        else
        {
          n = 3 * n + 1;
        }
        count++;
      }
      if (count > maxCount)
      {
        maxCount = count;
        max = i;
      }
    }
    return max;
  }
}
