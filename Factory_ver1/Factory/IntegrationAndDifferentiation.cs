using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngouriMath;

namespace Factory
{
    public abstract class ConreteOperations 
    {
        abstract public void RepresentResult(ScottPlot.FormsPlot plot, Point point);
        abstract public double Eval(Point point);
    }

    class IntegrationAnlysis : ConreteOperations
    {
        Entity f;

        public IntegrationAnlysis(string f)
        {
            this.f = f;
        }

        public override double Eval(Point point)
        {
            Entity antider = f.Integrate("x").InnerSimplified;
            double res = (double)(antider.Substitute("x", point.b).EvalNumerical() -
                                   antider.Substitute("x", point.a).EvalNumerical()
                                   );

            return Math.Round(res, 3);

        }
         
        public override void RepresentResult(ScottPlot.FormsPlot plot, Point point)
        {
            plot.Plot.Clear();
            
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            List<double> areaToFillX = new List<double>();
            List<double> areaToFillY = new List<double>();

            double offset = 0.1;
            double destPoint = 20.0;

            for(double currentPoint = -destPoint; currentPoint <= destPoint; currentPoint+= offset)
            {

                xs.Add(currentPoint);
                ys.Add((double) f.Substitute("x", currentPoint).EvalNumerical());

                if((currentPoint >= point.a) && (currentPoint < point.b+0.1))
                {
                    areaToFillX.Add(currentPoint);
                    areaToFillY.Add((double)f.Substitute("x", currentPoint).EvalNumerical());

                }

            }

            double [] xsarr = xs.ToArray();
            double [] ysarr = ys.ToArray();
            double[] toFillX = areaToFillX.ToArray();
            double[] toFillY = areaToFillY.ToArray();

            plot.Plot.AddScatter(xsarr, ysarr,markerSize: 0);
            plot.Plot.AddFillAboveAndBelow(toFillX, toFillY);

            plot.Plot.AddHorizontalLine(0.0, color:System.Drawing.Color.Black);
            plot.Plot.AddVerticalLine(0.0, color: System.Drawing.Color.Black);

            
            plot.Plot.AddVerticalLine(point.a,color:System.Drawing.Color.Red, style: ScottPlot.LineStyle.Dot);
            plot.Plot.AddVerticalLine(point.b,color:System.Drawing.Color.Red, style:ScottPlot.LineStyle.Dot);

            //plot.Plot.SetAxisLimits(point.a, point.b);

            plot.Refresh();
        }
    }

    class DifferentiationAnalysis : ConreteOperations
    {
        Entity f;

        public DifferentiationAnalysis(string f)
        {
            this.f = f;
        }
        public override double Eval(Point point)
        {
            double res = 0.0;

            var solutions;
        }
        public override void RepresentResult(ScottPlot.FormsPlot plot, Point point)
        {

        }
    }

}
