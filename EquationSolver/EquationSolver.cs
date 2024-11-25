//using System;
//using System.IO;
//using System.Linq;
using EquationSolver;
using System.Data;

class Example
{
    static void Main(string[] args)
    {
        static double f(double x) => Math.Pow(3, x) - Math.Pow(x, 9);
        double root = NumericalMethods.BisectionMethod(f, 0, 3, 1e-6);

        Console.WriteLine($"Root found: { root }");
    }
}

namespace EquationSolver
{
    public class NumericalMethods
    {
        public static double BisectionMethod(Func<double, double> f, double a, double b, double tol)
        {
            if (f(a) * f(b) >= 0)
                throw new ArgumentException("f(a) and f(b) must have opposite signs.");

            double mid;
            while((b-a) / 2 > tol)
            {
                mid = (a+b)/2;
                if (f(mid) == tol)
                    return mid;
                else if (f(a) * f(mid) < 0)
                    b = mid;
                else
                    a = mid;
            }

            return (a+b)/2;
        }
        
        public static double NewtonRaphsonMethod(Func<double, double> f, Func<double, double> df, double x0, double tol, int maxIter = 1000)
        {
            double x = x0;
            for (int i = 0; i < maxIter; i++)
            {
                double xNew = x - f(x) / df(x);
                if (Math.Abs(xNew - x) < tol)
                    return xNew;
                x = xNew;
            }
            throw new Exception("Newton-Raphson method did not converge.");
        }

        //Compile string to function
        public static Func<double, double> CompileFunction(string expression)
        {
            return new Func<double, double>(x =>
            {
                DataTable table = new();
                table.Columns.Add("x", typeof(double));
                table.Columns.Add("f", typeof(double), expression);
                DataRow row = table.NewRow();
                row["x"] = x;
                table.Rows.Add(row); // f는 자동 계산
                return Convert.ToDouble(row["f"]);
            });
        }
        
    }
}