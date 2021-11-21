using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath;
using ScottPlot;

namespace Factory
{
    public partial class Form1 : Form
    {
        Function functionBody;
        Point point;
        double a;
        double b;
        
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void main_plot_Load(object sender, EventArgs e)
        {

        }

        private void integrate_button_Click(object sender, EventArgs e)
        {
            a = double.Parse(a_value_box.Text);
            b = double.Parse(b_value_box.Text);
            point = new Point(a, b);

            functionBody = new AnalysisByIntegration(user_input_rtb.Text);
            ConreteOperations integration = functionBody.Analyse();
            
            double res = integration.Eval(point);
            integration.RepresentResult(main_plot, point);

            textBoxForIntegralRes.Text = res.ToString();


        }

        private void differentiate_button_Click(object sender, EventArgs e)
        {

        }

        private void EvalDerivativeAtPoint_a_Click(object sender, EventArgs e)
        {

        }
    }
}
