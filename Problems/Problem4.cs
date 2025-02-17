using System;

namespace Red.Euler.Problems;

public class Problem4 : Problem
{
  public Problem4() : base(4, "Largest palindrome product", "Find the largest palindrome made from the product of two 3-digit numbers.")
  {
  }

  private bool IsPalindrome(long n) {
      var s = n.ToString();
      for (var i = 0; i < s.Length / 2; i++) {
          if (s[i] != s[s.Length - i - 1]) {
              return false;
          }
      }
      return true;
  }
  public override long Solve()
  {
      long max = 0;
      for (var i = 100; i < 1000; i++)
      {
          for (var j = 100; j < 1000; j++)
          {
              var product = i * j;
              if (IsPalindrome(product) && product > max)
              {
                  max = product;
              }
          }
      }
      return max;
  }
}
