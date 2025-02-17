using System;

namespace Red.Euler.Problems;

public class Problem7 : Problem
{
  private readonly int nthPrime = 10001;
  public Problem7() : base(7, "10001st prime", "What is the 10001st prime number?")
  { 
  }

  public override long Solve()
  {
      int n = nthPrime;
      int count = 0;
      int i = 1;
      while (true)
      {
          i++;
          if (i.IsPrime())
          {
              count++;
              if (count == n)
              {
                  return i;
              }
          }
      }
  }
}
