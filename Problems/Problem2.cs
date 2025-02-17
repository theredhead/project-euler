using System;
using Microsoft.Win32;

namespace Red.Euler.Problems;

public class Problem2 : Problem
{
  private readonly long upperLimit = 4000000;
  public Problem2() : base(2, "Even Fibonacci numbers", "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.")
  {
  }

  public override long Solve()
  {
    long sum = 0;
    var fib = 1;
    var prev = 1;

    while (fib < upperLimit)
    {
      if (fib % 2 == 0)
      {
        sum += fib;
      }

      var temp = fib;
      fib += prev;
      prev = temp;
    }

    return sum;
  }
}
