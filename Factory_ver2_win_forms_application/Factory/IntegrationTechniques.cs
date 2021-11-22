using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngouriMath;
using ScottPlot;

namespace Factory
{
    public abstract class IntegrationProduct
    {
        public abstract string result { get;  set; }
        public abstract string Integrate();
        public abstract void RepresentResult();
    }

    class DirectIntegration : IntegrationProduct
    {
        Entity f;
        Point pointForIntegration;
        Point pointForGraph;
        FormsPlot plot;
        
        public override string result { get; set; }

        public DirectIntegration(string f, FormsPlot plot, Point pointForIntegration, Point pointForGraph)
        {
            this.f = f;
            this.pointForGraph = pointForGraph;
            this.pointForIntegration = pointForIntegration;
            this.plot = plot;

            result = Integrate();
            RepresentResult();
        }

        public override string Integrate()
        {
            Entity antider = f.Integrate("x").InnerSimplified;
            double res = 0.0;

            try
            {
                res = (double)(antider.Substitute("x", pointForIntegration.b).EvalNumerical() -
                                      antider.Substitute("x", pointForIntegration.a).EvalNumerical());
            }
            catch
            {
                throw new ArgumentException($"Antiderivative {antider} doesn't exist in point {pointForIntegration.a} or {pointForIntegration.b}");
            }

            return Math.Round(res, 3).ToString();

        }


        public override void RepresentResult()
        {
            plot.Plot.Clear();

            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            List<double> areaToFillX = new List<double>();
            List<double> areaToFillY = new List<double>();

            double offset = 0.1;
            
            for (double currentPoint = pointForGraph.a; currentPoint <= pointForGraph.b; currentPoint += offset)
            {

                xs.Add(currentPoint);

                try
                {
                    ys.Add((double)f.Substitute("x", currentPoint).EvalNumerical());
                }
                catch
                {
                    throw new ArgumentException($"Function {f} doesn't exist in point {currentPoint}!");
                }

                //area to fill
                if ((currentPoint >= pointForIntegration.a) && (currentPoint < pointForIntegration.b + 0.1))
                {
                    areaToFillX.Add(currentPoint);
                    areaToFillY.Add((double)f.Substitute("x", currentPoint).EvalNumerical());

                }

            }

            plot.Plot.AddScatter(xs.ToArray(), ys.ToArray(), markerSize: 0);
            plot.Plot.AddFill(areaToFillX.ToArray(), areaToFillY.ToArray());

            plot.Plot.AddHorizontalLine(0.0, color: System.Drawing.Color.Black);
            plot.Plot.AddVerticalLine(0.0, color: System.Drawing.Color.Black);

            plot.Plot.AddVerticalLine(pointForIntegration.a, color: System.Drawing.Color.Red, style: ScottPlot.LineStyle.Dot);
            plot.Plot.AddVerticalLine(pointForIntegration.b, color: System.Drawing.Color.Red, style: ScottPlot.LineStyle.Dot);

            //plot.Plot.SetAxisLimits(point.a, point.b);

            plot.Refresh();
        }
    }

    class RectanglesMethodIntegration: IntegrationProduct
    {
        Entity f;
        Point pointForIntegration;
        Point pointForGraph;
        FormsPlot plot;

        public override string result { get; set; }
        double h = 0.2;

        public RectanglesMethodIntegration(string f, FormsPlot plot, Point pointForIntegration, Point pointForGraph)
        {
            this.f = f;
            this.pointForIntegration = pointForIntegration;
            this.pointForGraph = pointForGraph;
            this.plot = plot;

            result = Integrate();
            RepresentResult();
        }


        public override string Integrate()
        {
            double tempa = pointForIntegration.a;
            double tempb = pointForIntegration.b;  
            double sum = 0.0;

            while (tempa <= tempb)
            {
                sum += (double)f.Substitute("x", tempa).EvalNumerical();
                tempa += h;
            }

            sum *= h;
            return sum.ToString();

        }

        public override void RepresentResult()
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();
            
            
            while(pointForIntegration.a < pointForIntegration.b + h)
            {
                xs.Add(pointForIntegration.a);
                ys.Add((double)f.Substitute("x", pointForIntegration.a).EvalNumerical());
                

                pointForIntegration.a += h;
            }
   
          
            plot.Plot.AddScatterStep(xs.ToArray(), ys.ToArray(), color:System.Drawing.Color.Red, label: "Метод прямоугольников");
            plot.Plot.Legend();
            plot.Refresh();
        }


    }

    class TrapezoidMethodIntegration: IntegrationProduct
    {
        Entity f;
        Point pointForIntegration;
        Point pointForGraph;
        FormsPlot plot;

        double h = 0.2;
        public override string result { get; set; }


        public TrapezoidMethodIntegration(string f, FormsPlot plot, Point pointForIntegration, Point pointForGraph)
        {
            this.f = f;
            this.pointForIntegration= pointForIntegration;
            this.pointForGraph = pointForGraph;
            this.plot = plot;

            result = Integrate();
            RepresentResult();

        }

        public override string Integrate()
        {
            double tempa = pointForIntegration.a;
            double tempb = pointForIntegration.b;
            
            double sum = 0.0;
            double h = 0.2;

            while(tempa <= tempb)
            {
                sum +=( (double)f.Substitute("x", tempa).EvalNumerical() + (double)f.Substitute("x", tempa + h).EvalNumerical() )/ 2;
                tempa += h;
            }
            sum *= h;
            return sum.ToString();
        }

        public override void RepresentResult()
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();


            while (pointForIntegration.a < pointForIntegration.b + h)
            {
                xs.Add(pointForIntegration.a);
              //  ys.Add((double)f.Substitute("x", pointForIntegration.a).EvalNumerical());
                
                ys.Add(((double)f.Substitute("x", pointForIntegration.a).EvalNumerical() +
                        (double)f.Substitute("x", pointForIntegration.a + h).EvalNumerical()) / 2
                        );
                pointForIntegration.a += h;
            }


            plot.Plot.AddScatterStep(xs.ToArray(), ys.ToArray(), color: System.Drawing.Color.Green, label: "Метод трапеций") ;
            plot.Plot.Legend();
            plot.Refresh();
        }
    }


}



   
