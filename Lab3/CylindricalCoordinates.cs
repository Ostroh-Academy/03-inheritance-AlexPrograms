namespace Lab3;

public class CylindricalCoordinates : PolarCoordinates
{
    public double Z { get; private set; }
    
    public CylindricalCoordinates(double radius, double theta, double z)
        : base(radius, theta)
    {
        Z = z;
    }


    public void SetCylindricalCoordinates(double radius, double theta, double z)
    {
        SetPolarCoordinates(radius, theta);
        Z = z;
    }
    
    public void SetCartesianCoordinates(double x, double y, double z)
    {
        base.SetCartesianCoordinates(x, y);
        Z = z;
    }


    public (double x, double y, double z) ToCartesian()
    {
        var (x, y) = base.ToCartesian();
        return (x, y, Z);
    }


    public void FromCartesian(double x, double y, double z)
    {
        base.FromCartesian(x, y);
        Z = z;
    }
}