namespace AdventOfCode;

public class Day_02 : BaseDay
{
    private readonly string _input;

    public Day_02()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1() => Part1();
    public override ValueTask<string> Solve_2() => Part2();

    private ValueTask<string> Part1()
    {
        var lines = _input.Split("\n");

        var position = 0;
        var depth = 0;

        foreach (var line in lines)
        {
            var splitCommand = line.Split(" ");

            var command = splitCommand[0];
            var value = int.Parse(splitCommand[1]);

            switch (command)
            {
                case "forward":
                    position += value;
                    break;
                case "down":
                    depth += value;
                    break;
                case "up":
                    depth -= value;
                    break;
            }
        }

        return new ValueTask<string>((position * depth).ToString());
    }

    private ValueTask<string> Part2()
    {
        var lines = _input.Split("\n");

        var position = 0;
        var depth = 0;
        var aim = 0;

        foreach (var line in lines)
        {
            var splitCommand = line.Split(" ");

            var command = splitCommand[0];
            var value = int.Parse(splitCommand[1]);

            switch (command)
            {
                case "forward":
                    position += value;
                    depth += aim * value;
                    break;
                case "down":
                    aim += value;
                    break;
                case "up":
                    aim -= value;
                    break;
            }
        }

        return new ValueTask<string>((position * depth).ToString());
    }
}