using System;

namespace Red.Euler.Problems;

public class Problem12 : Problem
{
  readonly int numberOfDivisors = 500;
  public Problem12() : base(12, "Highly divisible triangular number", "What is the value of the first triangle number to have over five hundred divisors?")
  {
  }

  public override long Solve()
  {
    var triangleNumber = 0;
    var index = 1;
    while (true)
    {
      triangleNumber += index;
      var divisors = CountDivisors(triangleNumber);
      if (divisors > numberOfDivisors)
      {
        return triangleNumber;
      }
      index++;
    }
  }

  private int CountDivisors(int triangleNumber)
  {
    var divisors = 0;
    for (var i = 1; i <= Math.Sqrt(triangleNumber); i++)
    {
      if (triangleNumber % i == 0)
      {
        divisors += 2;
      }
    }
    return divisors;
  }
}
