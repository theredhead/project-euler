using System;

namespace Red.Euler;

public static class Extensions
{
  public static bool IsPrime(this double i) => IsPrime((long)i);
  public static bool IsPrime(this int i) => IsPrime((long)i);
  public static bool IsPrime(this long i)
  {
      if (i < 2)
      {
          return false;
      }
      if (i == 2)
      {
          return true;
      }
      if (i % 2 == 0)
      {
          return false;
      }
      for (int j = 3; j <= Math.Sqrt(i); j += 2)
      {
          if (i % j == 0)
          {
              return false;
          }
      }
      return true;
  }
}
