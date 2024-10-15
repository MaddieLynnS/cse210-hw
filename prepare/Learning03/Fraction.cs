public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //would just like to say that I'm inclined to agree with the article.
    //I read it and I feel like this a program where you might not want public
    //getters and setters. They could be achieved with other methods.
    public int GetTop() {
        return _top;
    }
    public void SetTop(int newTop) {
        _top = newTop;
    }

    public int GetBottom(){
        return _bottom;
    }
    public void SetBottom(int newBottom) {
        _bottom = newBottom;
    }


    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue() {
        //double answer = _top/_bottom;
        return (double)_top/(double)_bottom;
    }



}