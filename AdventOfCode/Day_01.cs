namespace AdventOfCode;

public class Day_01 : BaseDay
{
    private readonly string _input;

    public Day_01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1() => Part1();
    public override ValueTask<string> Solve_2() => Part2();

    private ValueTask<string> Part1()
    {
        var increasing = 0;
        var lines = _input.Split("\n").Select(int.Parse).ToArray();

        for (var i = 1; i < lines.Length; i++)
        {
            if (lines[i] > lines[i - 1])
            {
                ++increasing;
            }
        }
        
        return new ValueTask<string>(increasing.ToString());
    }

    private ValueTask<string> Part2()
    {
        var increasing = 0;
        var lines = _input.Split("\n").Select(int.Parse).ToArray();

        for (var i = 0; i < lines.Length; i++)
        {
            if (i + 3 > lines.Length - 1)
            {
                break;
            }

            if (lines[i] < lines[i + 3])
            {
                ++increasing;
            }
                
        }
        
        return new ValueTask<string>(increasing.ToString());
    }
}
