using System;
using ConsoleAppWithDI.UI.Services;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppWithDI.UI
{
    public class EntryPoint
    {
        private readonly IQuadraticService _quadraticService;
        private readonly IConfiguration _configuration;

        public EntryPoint(IQuadraticService quadraticService, IConfiguration configuration)
        {
            this._quadraticService = quadraticService;
            this._configuration = configuration;
        }

        public void Run(String[] args)
        {
            var a = Double.Parse(this._configuration["PolynomialCoefficients:A"]);
            var b = Double.Parse(this._configuration["PolynomialCoefficients:B"]);
            var c = Double.Parse(this._configuration["PolynomialCoefficients:C"]);

            var quadraticRoots = this._quadraticService.CalculateRoots(a, b, c);

            Console.WriteLine($"Polynomial: {a}x^2 + {b}x + {c}");
            if (quadraticRoots == null)
            {
                Console.WriteLine("The roots are not reals");
            }
            else if (quadraticRoots.FirstRoot == quadraticRoots.SecondRoot)
            {
                Console.WriteLine($"The double root is {quadraticRoots.FirstRoot}");
            }
            else
            {
                Console.WriteLine($"The roots are: {quadraticRoots.FirstRoot} and {quadraticRoots.SecondRoot}");
            }
        }
    }
}