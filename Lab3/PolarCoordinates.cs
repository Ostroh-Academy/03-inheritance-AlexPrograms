namespace Lab3;

public class PolarCoordinates
{
    public double Radius { get; private set; }
    public double Theta { get; private set; } // Theta in radians
    
    public PolarCoordinates(double radius, double theta)
    {
        Radius = radius;
        Theta = theta;
    }
    
    public void SetPolarCoordinates(double radius, double theta)
    {
        Radius = radius;
        Theta = theta;
    }

    public void SetCartesianCoordinates(double x, double y)
    {
        Radius = Math.Sqrt(x * x + y * y);
        Theta = Math.Atan2(y, x);
    }

 
    public (double x, double y) ToCartesian()
    {
        double x = Radius * Math.Cos(Theta);
        double y = Radius * Math.Sin(Theta);
        return (x, y);
    }


    public void FromCartesian(double x, double y)
    {
        Radius = Math.Sqrt(x * x + y * y);
        Theta = Math.Atan2(y, x);
    }
}