using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public class QuadraticService : IQuadraticService
    {
       
        public double _m;
        public double _resp1;
        public double _resp2;

        public double GetQuadratic(double a, double b, double c)
        {
            //  _m = Math.Pow(b, 2);
            //  return _resp1 = (-b + (Math.Sqrt(_m - 4 * a * c))) / 2 * a;
            return _resp1 = (-b + Math.Sqrt(b * b -4 * a * c)) / (2 * a);

        }

        public double GetQuadratic2(double a, double b, double c)
        {
           // _m = Math.Pow(b, 2);
           // return _resp2 = (-b - (Math.Sqrt(_m - 4 * a * c))) / 2 * a;
            return _resp2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

        }
    }
}
