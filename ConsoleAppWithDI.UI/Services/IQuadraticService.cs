using System;
using ConsoleAppWithDI.UI.Entities;

namespace ConsoleAppWithDI.UI.Services
{
    public interface IQuadraticService
    {
        QuadraticRoots CalculateRoots(Double a, Double b, Double c);
    }
}