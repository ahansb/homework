//Problem 4. Triangle surface
//Write methods that calculate the surface of a triangle by given:
//  Side and an altitude to it;
//  Three sides;
//  Two sides and an angle between them;
//Use System.Math.


using System;
class TriangleSurface
{
    static double surface = new double();
    static void Main()
    {
        double a = 2;
        double h = 2;
        double b = 3;
        double c = 4;
        double alfa = 30;




        double surfaceOne = SurfBySideAltitude(a, h);
         
        double surfaceTwo = SurfByThreeSides(a, b, c);
         
        double surfaceThree = SurfByTwoSidesAngle(a, b, alfa);

        Console.WriteLine("{0}, {1}, {2:F2}",surfaceOne,surfaceTwo,surfaceThree);


    }

    static double SurfByTwoSidesAngle(double a, double b, double alfa)
    {
        surface = (a * b * Math.Sin(alfa)) / 2;
        return surface;
    }

    static double SurfByThreeSides(double a, double b, double c)
    {
        surface = (a + b + c) / 2;
        return surface;
    }

    static double SurfBySideAltitude(double a, double h)
    {

        surface = a * h / 2;
        return surface;
    }
}