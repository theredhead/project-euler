using System.Diagnostics;

namespace Red.Euler;
public class ProblemSolver 
{
  public void Solve(IProblem problem)
  {
    var sw = new Stopwatch();
    sw.Start();
    var result = problem.Solve();
    var timeTaken = sw.ElapsedMilliseconds;
    sw.Stop();
    Console.WriteLine($"Problem #{problem.Number}: The result of {problem.Name} is {result} and took {timeTaken}ms to solve.");
  }
}