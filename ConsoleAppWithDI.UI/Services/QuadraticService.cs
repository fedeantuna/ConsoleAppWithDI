using System;
using ConsoleAppWithDI.UI.Entities;

namespace ConsoleAppWithDI.UI.Services
{
    public class QuadraticService : IQuadraticService
    {
        public QuadraticRoots CalculateRoots(Double a, Double b, Double c)
        {
            var discriminant = Math.Pow(b, 2) - (4 * a * c);


            
            if (discriminant < 0)
            {
                return null;
            }
            
            var quadraticRoots = new QuadraticRoots();


            if (discriminant ==  0)
            {
                quadraticRoots.FirstRoot = quadraticRoots.SecondRoot = ((- b) + (Math.Sqrt(discriminant))) / (2 * a);
            }
            else
            {
                quadraticRoots.FirstRoot = ((- b) + (Math.Sqrt(discriminant))) / (2 * a);
                quadraticRoots.SecondRoot = ((- b) - (Math.Sqrt(discriminant))) / (2 * a);
            }


            return quadraticRoots;
        }
    }
}