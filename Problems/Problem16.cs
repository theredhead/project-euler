using System;

namespace Red.Euler.Problems;

public class Problem16 : Problem
{
  public Problem16() : base(16, "Power digit sum", "What is the sum of the digits of the number 2^1000?")
  {
  }

  public override long Solve()
  {
    var number = new System.Numerics.BigInteger(2);
    number = System.Numerics.BigInteger.Pow(number, 1000);
    var sum = 0;
    foreach (var digit in number.ToString())
    {
      sum += int.Parse(digit.ToString());
    }
    return sum;
  }
}
