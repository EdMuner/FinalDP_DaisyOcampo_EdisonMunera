using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public interface IQuadraticService
    {
        double GetQuadratic(double a, double b, double c);

        double GetQuadratic2(double a, double b, double c);
    }
}
