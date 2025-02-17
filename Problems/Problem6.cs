using System;

namespace Red.Euler.Problems;

public class Problem6 : Problem
{
  public Problem6() : base(6, "Sum square difference", "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.")
  {
  }

    public override long Solve()
    {
        long sumOfSquares = 0;
        long squareOfSum = 0;
        for (var i = 1; i <= 100; i++)
        {
            sumOfSquares += i * i;
            squareOfSum += i;
        }
        squareOfSum *= squareOfSum;
        return squareOfSum - sumOfSquares;
    }
}
