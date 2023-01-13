// Simple struct
public struct Point
{
    private double _x;
    private double _y;
    public Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double X => _x;
    public double Y => _y;
}

// Support for comparison
public struct PointX : IEquatable<PointX>
{
    private double _x;
    private double _y;
    public PointX(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double X => _x;
    public double Y => _y;

    public override bool Equals(object? o) => o is PointX p && this.Equals(p);
    public bool Equals(PointX o) => this.X == o.X && this.Y == o.Y;
    public override int GetHashCode() => HashCode.Combine(X, Y);

    public static bool operator ==(PointX a, PointX b) => a.Equals(b);
    public static bool operator !=(PointX a, PointX b) => !(a == b);
}

// Immutable, used read-only with auto-properties to reduce the clutter
public readonly struct PointI
{
    public PointI(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }
    public double DistanceFromOrigin() => Math.Sqrt(X * X + Y * Y);
}

// A read-only struct in a read-only property, no defensive copying here
// https://levelup.gitconnected.com/defensive-copy-in-net-c-38ae28b828
public class LocationData
{
    public LocationData(string label, PointI location)
    {
        Label = label;
        Location = location;
    }

    public string Label { get; }
    public PointI Location { get; }
}