namespace AdventOfCode.Models;

public class LkVector2
{
    public static readonly LkVector2 Zero = new(0, 0);
    public static readonly LkVector2 Right = new(1, 0);
    public static readonly LkVector2 Up = new(0, 1);
    public static readonly LkVector2 Left = new(-1, 0);
    public static readonly LkVector2 Down = new(0, -1);

    public LkVector2()
    {
    }

    public LkVector2(decimal x, decimal y)
    {
        X = x;
        Y = y;
    }

    public decimal X { get; set; }
    public decimal Y { get; set; }

    public override string ToString()
    {
        return $"({X:0.##}, {Y:0.##})";
    }

    public bool Equals(LkVector2 other)
    {
        return other != null && X == other.X && Y == other.Y;
    }

    public static LkVector2 operator +(LkVector2 a, LkVector2 b)
    {
        if (a == null && b == null) return null;
        if (a == null) return b;
        if (b == null) return a;
        return new(a.X + b.X, a.Y  + b.Y);
    }
    public static LkVector2 operator -(LkVector2 a, LkVector2 b)
    {
        if (a == null) return null;
        if (b == null) return a;
        return new(a.X - b.X, a.Y  - b.Y);
    }
    public static LkVector2 operator *(LkVector2 v, decimal d) => new(decimal.Round(v.X * d, 4, MidpointRounding.AwayFromZero), decimal.Round(v.Y * d, 4, MidpointRounding.AwayFromZero));
    public static LkVector2 operator *(LkVector2 v, int i) => new(decimal.Round(v.X * i, 4, MidpointRounding.AwayFromZero), decimal.Round(v.Y * i, 4, MidpointRounding.AwayFromZero));
    public static LkVector2 operator *(int i, LkVector2 v) => v * i;
    public static LkVector2 operator *(decimal d, LkVector2 v) => v * d;
    public static LkVector2 operator /(LkVector2 v, decimal d) => new(v.X / d, v.Y / d);

}
