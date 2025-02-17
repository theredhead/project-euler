using System;

namespace Red.Euler.Problems;

public class Problem9 : Problem
{
  private const int target = 1000;

  public Problem9() : base(9, "Special Pythagorean triplet", "There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.")
  {
  }

    public override long Solve()
    {
        for (var a = 1; a < target; a++)
        {
            for (var b = a + 1; b < target; b++)
            {
                var c = target - a - b;
                if (a * a + b * b == c * c)
                {
                    return a * b * c;
                }
            }
        }
        return 0;
    }
}
