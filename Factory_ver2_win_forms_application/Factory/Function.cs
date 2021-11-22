
using ScottPlot;

namespace Factory
{
    public abstract class IntegrationTypeCreator
    {
        abstract public IntegrationProduct Create();
    }

    class Direct : IntegrationTypeCreator
    {
        string f;
        Point pointForIntegration;
        Point pointForGraph;
        FormsPlot plot;

        public Direct(string f, Point pointForIntegration, Point pointForGraph, FormsPlot plot)
        {
            this.f = f;
            this.pointForIntegration = pointForIntegration;
            this.pointForGraph = pointForGraph;
            this.plot = plot;
        }

        public override IntegrationProduct Create()
        {
            return new DirectIntegration(f, plot, pointForIntegration, pointForGraph);
        }
    }

    class Rectangles: IntegrationTypeCreator
    {
        string f;
        Point pointForIntegration;
        Point pointForGraph;
        FormsPlot plot;

        public Rectangles(string f, Point pointForIntegration, Point pointForGraph, FormsPlot plot)
        {
            this.f = f;
            this.pointForIntegration = pointForIntegration;
            this.pointForGraph = pointForGraph;
            this.plot = plot;
        }

        public override IntegrationProduct Create()
        {
            return new RectanglesMethodIntegration(f, plot, pointForIntegration, pointForGraph);
        }
    }


    class Trapezoid: IntegrationTypeCreator
    {
        string f;
        Point pointForIntegration;
        Point pointForGraph;
        FormsPlot plot;

        public Trapezoid(string f, Point pointForIntegration, Point pointForGraph, FormsPlot plot)
        {
            this.f = f;
            this.pointForIntegration = pointForIntegration;
            this.pointForGraph = pointForGraph;
            this.plot = plot;
        }

        public override IntegrationProduct Create()
        {
            return new TrapezoidMethodIntegration(f, plot, pointForIntegration, pointForGraph);
        }
    }
   

}


