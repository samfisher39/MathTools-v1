using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plotting_Try;

namespace MathTools_v1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Events
        private void saveSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void integralCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var integrator = new IntegralCalc();
            integrator.Show();
        }

        private void matrixCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var matrixcalc = new MatrixCalc();
            matrixcalc.Show();
        }
        #endregion
    }
}
