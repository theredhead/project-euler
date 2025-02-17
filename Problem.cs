namespace Red.Euler;

public interface IProblem {
  int Number { get; }
  string Name { get; }
  string Description { get; }
  long Solve();
}

public abstract class Problem : IProblem {
  public int Number { get; }
  public string Name { get; }
  public string Description { get; }

  public Problem(int number, string name, string description)
  {
    Number = number;
    Name = name;
    Description = description;
  }

  abstract public long Solve();
}