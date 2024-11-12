public abstract class Shape
{
    protected string _color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string newColor)
    {
        _color = newColor;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}