using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using OxyPlot;
using OxyPlot.Series;

namespace Plotting_Try
{
    public partial class IntegralCalc : Form
    {

        #region vars
        public ExpressionString expressi = new ExpressionString();
        public double a = 0;
        public double b = 100;
        public double dx;
        public double v;
        public alglib.autogkstate s;
        public alglib.autogkreport rep;
        public PlotModel myModel = new PlotModel { Title = "Integrating this" };
        #endregion
        
        #region Inizializing
        public IntegralCalc()
        {
            this.InitializeComponent();
        }
        #endregion

        #region Methods
        public void FunctionInt(double x, double xminusa, double bminusx, ref double y, object obj)
        {

            Expression e = new Expression(expressi.expression, EvaluateOptions.IgnoreCase) {Parameters = {["x"] = x}};
            object result = e.Evaluate();
            y = Convert.ToDouble(result);
        }
        public void Evaluate()
        {
            expressi.expression = textBox1.Text;
            alglib.autogksmooth(a, b, out s);
            alglib.autogkintegrate(s, FunctionInt, null);
            alglib.autogkresults(s, out v, out rep);
            rtbIntegralInfo.Text = v.ToString();
        }
        public double Function(double x)
        {
            expressi.expression = textBox1.Text;
            Expression e = new Expression(expressi.expression, EvaluateOptions.IgnoreCase);
            e.Parameters["x"] = x;
            object result = e.Evaluate();
            return Convert.ToDouble(result);
        }
        private void UpdateDx()
        {
            dx = (b - a) / 1000;
        }
        #endregion

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDx();
            rtbData.Text = String.Empty;
            myModel.Series.Clear();
            myModel.Series.Add(new FunctionSeries(Function, a, b, dx, "x^3/(exp(x)-1"));
            plot1.InvalidatePlot(true);
            plot1.Model = myModel;

            //for (int i = Convert.ToInt32(a); i < b / dx; i++)
            //{
            //    var temp = Convert.ToDouble(i) * dx;
            //    rtbData.Text += "     " + string.Format("{0:0.00}", temp) + "   |   " + string.Format("{0:0.00}", Function(temp)) + Environment.NewLine;
            //}
            Evaluate();
        }

        private void btnSetA_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tbA.Text);
        }

        private void btnSetB_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(tbB.Text);
        }
        #endregion
    }
}
