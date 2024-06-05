
using Lab3;

PolarCoordinates polar = new PolarCoordinates(5, Math.PI / 4);
var cartesian = polar.ToCartesian();
Console.WriteLine($"Polar to Cartesian: x = {cartesian.x}, y = {cartesian.y}");

polar.FromCartesian(cartesian.x, cartesian.y);
Console.WriteLine($"Cartesian to Polar: radius = {polar.Radius}, theta = {polar.Theta}");

CylindricalCoordinates cylindrical = new CylindricalCoordinates(5, Math.PI / 4, 10);
var cartesianCyl = cylindrical.ToCartesian();
Console.WriteLine($"Cylindrical to Cartesian: x = {cartesianCyl.x}, y = {cartesianCyl.y}, z = {cartesianCyl.z}");

cylindrical.FromCartesian(cartesianCyl.x, cartesianCyl.y, cartesianCyl.z);
Console.WriteLine($"Cartesian to Cylindrical: radius = {cylindrical.Radius}, theta = {cylindrical.Theta}, z = {cylindrical.Z}");