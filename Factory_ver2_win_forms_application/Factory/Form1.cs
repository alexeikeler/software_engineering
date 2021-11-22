using System;
using System.Windows.Forms;
using AngouriMath;
using ScottPlot;

namespace Factory
{
    public partial class Form1 : Form
    {
        IntegrationTypeCreator typeCreator;
        Point pointForIntegration;
        Point pointForGraph;

        public Form1()
        {
            InitializeComponent();
            user_input_rtb.Text = "x*sin(x)";
            graph_bound_a.Text = "-20";
            graph_bound_b.Text = "20";
            a_value_box.Text = "3,5";
            b_value_box.Text = "7,5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void main_plot_Load(object sender, EventArgs e)
        {

        }


        #region

        private void getPoints()
        {
            pointForGraph = new Point(
               double.Parse(graph_bound_a.Text),
               double.Parse(graph_bound_b.Text)
               );

            pointForIntegration = new Point(
                double.Parse(a_value_box.Text),
                double.Parse(b_value_box.Text)
                );
        }
        private void integrate_button_Click(object sender, EventArgs e)
        {
            getPoints();
            
            typeCreator = new Direct(user_input_rtb.Text,
                pointForIntegration,
                pointForGraph,
                main_plot);

            IntegrationProduct integrationProduct = typeCreator.Create();

            textBoxForIntegralRes.Text = integrationProduct.result;
        }
        private void rectangle_method_Click(object sender, EventArgs e)
        {
            getPoints();

            typeCreator = new Rectangles(user_input_rtb.Text,
                pointForIntegration,
                pointForGraph,
                main_plot);

            IntegrationProduct integrationProduct = typeCreator.Create();
            textBoxForIntegralRes.Text = integrationProduct.result;

        }

        private void trapezoidal_method_Click(object sender, EventArgs e)
        {
            getPoints();

            typeCreator = new Trapezoid(
                user_input_rtb.Text,
                pointForIntegration,
                pointForGraph,
                main_plot);

            IntegrationProduct integrationProduct = typeCreator.Create();
            textBoxForIntegralRes.Text = integrationProduct.result;
        }

        #endregion
    }
}
