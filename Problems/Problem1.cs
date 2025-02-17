namespace Red.Euler.Problems;

public class Problem1 : Problem {
  private readonly long lowerLimit = 0;
  private readonly long upperLimit = 1000;
  private readonly long[] actors = {3, 5};

  public Problem1() : base(1, "Multiples of 3 or 5", "Find the sum of all the multiples of 3 or 5 below 1000.")
  {
  }

  private bool isultipleOfActor(long n) {
    return actors.Any(actor => n % actor == 0);
  }

  public override long Solve() {
    long sum = 0;
    for (var n = lowerLimit; n < upperLimit; n++) {
      if (isultipleOfActor(n)) {
        sum += n;
      }
    }
    return sum;
  }
}