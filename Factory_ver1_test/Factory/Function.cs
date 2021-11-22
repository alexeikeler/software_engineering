using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngouriMath;

namespace Factory
{
    public abstract class Function
    {
        string functionBody;
        abstract public ConreteOperations Analyse();
    }

    class AnalysisByIntegration : Function
    {
        string f;
        public AnalysisByIntegration(string f)
        {
            this.f = f;
        }

        public override ConreteOperations Analyse()
        {
            return new IntegrationAnlysis(f);
        }
    }

    class AnalysisByDifferentiation : Function
    {
        string f;

        public AnalysisByDifferentiation(string f)
        {
            this.f = f;
        }

        public override ConreteOperations Analyse()
        {
            return new DifferentiationAnalysis(f);
        }
    }

   public class Point
    {
        public double a { get; set; }
        public double b { get; set; }  
  
        public Point(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Point(double a)
        {
            this.a = a;
        }
    }
}


