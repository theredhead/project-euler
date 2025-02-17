using System;

namespace Red.Euler.Problems;

public class Problem17 : Problem
{
  public Problem17() : base(17, "Number letter counts", "If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?")
  {
  }

  public override long Solve()
  {
    var sum = 0;
    for (var i = 1; i <= 1000; i++)
    {
      var s = NumberToWords(i);
      Console.WriteLine($"{i} => [{s}]");
      sum += s.Replace("-", "").Replace(" ", "").Length;
    }
    return sum;
  }

  private string NumberToWords(int i)
  {
    string result = "";

    if (i == 1000)
    {
      result = "one thousand";
    }
    else if (i >= 100)
    {
      var hundreds = i / 100;
      var tens = i % 100;
      if (tens == 0)
      {
        result = NumberToWords(hundreds) + " hundred";
      }
      else
      {
        result = NumberToWords(hundreds) + " hundred and " + NumberToWords(tens);
      }
    }
    else if (i >= 90)
    {
      result = "ninety " + NumberToWords(i - 90);
    }
    else if (i >= 80)
    {
      result = "eighty " + NumberToWords(i - 80);
    }
    else if (i >= 70)
    {
      result = "seventy " + NumberToWords(i - 70);
    }
    else if (i >= 60)
    {
      result = "sixty " + NumberToWords(i - 60);
    }
    else if (i >= 50)
    {
      result = "fifty " + NumberToWords(i - 50);
    }
    else if (i >= 40)
    {
      result = "forty " + NumberToWords(i - 40);
    }
    else if (i >= 30)
    {
      result = "thirty " + NumberToWords(i - 30);
    }
    else if (i >= 20)
    {
      result = "twenty " + NumberToWords(i - 20);
    }
    else result = i switch
    {
      0 => "",
      1 => "one",
      2 => "two",
      3 => "three",
      4 => "four",
      5 => "five",
      6 => "six",
      7 => "seven",
      8 => "eight",
      9 => "nine",
      10 => "ten",
      11 => "eleven",
      12 => "twelve",
      13 => "thirteen",
      14 => "fourteen",
      15 => "fifteen",
      16 => "sixteen",
      17 => "seventeen",
      18 => "eighteen",
      19 => "nineteen",
      _ => throw new ArgumentOutOfRangeException(nameof(i), i, "Number out of range")
    };

    return result.Trim();
  }
}
