using System;

namespace Red.Euler.Problems;

public class Problem15 : Problem
{
  private readonly int gridSize = 20;
  public Problem15() : base(15, "Lattice paths", "How many such routes are there through a 20×20 grid?")
  {
  }

  public override long Solve()
  {
    var grid = new long[gridSize + 1, gridSize + 1];
    for (var i = 0; i <= gridSize; i++)
    {
      grid[i, gridSize] = 1;
      grid[gridSize, i] = 1;
    }
    for (var y = gridSize - 1; y >= 0; y--)
    {
      for (var x = gridSize - 1; x >= 0; x--)
      {
        grid[y, x] = grid[y + 1, x] + grid[y, x + 1];
      }
    }
    return grid[0, 0];
  }
}
