using Red.Euler.Problems;

namespace Red.Euler;

public class ProjectEulerProgram
{

  public static void Main()
  {
    var solver = new ProblemSolver();

    var problems = new IProblem[] {
      new Problem1(),
      new Problem2(),
      new Problem3(),
      new Problem4(),
      new Problem5(),
      new Problem6(),
      new Problem7(),
      new Problem8(),
      new Problem9(),
      new Problem10(),
      new Problem11(),
      new Problem12(),
      new Problem13(),
      new Problem14(),
      new Problem15(),
      new Problem16(),
      new Problem17(),
    };

    foreach (var problem in problems)
    {
      solver.Solve(problem);
    }
    Console.WriteLine();
  }
}