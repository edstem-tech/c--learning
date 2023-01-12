class Triangle : Shape
{
    public int Hypotenuese { get; set; }

    // Polymorphism
    public override double CalculateArea()
    {
        return 0.5 * Width * Height;
    }
}
