
using System;
public class Circle
{
    public float _radiusOfCircle;

    public Circle(float radiusOfCircle)
    {
        _radiusOfCircle = radiusOfCircle;
    }

    public double AreaOfCircle()
    {
        return 3.142 * _radiusOfCircle * _radiusOfCircle;
    }

    public double PerimeterOfCircle()
    {
        return 2 * 3.142 * _radiusOfCircle;
    }
}