using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTools_v1
{
    public partial class MatrixCalc : Form
    {
        public MatrixCalc()
        {
            InitializeComponent();
        }

        #region Events
        private void MatrixCalc_Resize(object sender, EventArgs e)
        {
            tbMatrix1.Width = pnlMatrix.Width / 3;
            tbMatrix2.Width = pnlMatrix.Width / 3;
            tbMatrix3.Width = pnlMatrix.Width / 3;
            lblA.Left = pnlMatrix.Width / 6 - 10;
            lblOperator.Left = pnlMatrix.Width / 3 - 10;
            lblB.Left = 3 * pnlMatrix.Width / 6 - 10;
            lblEquals.Left = 2 * pnlMatrix.Width / 3 - 10;
            lblC.Left = 5 * pnlMatrix.Width / 6 - 10;
        }
        #endregion

        #region Methods
        //private void 
        #endregion
    }
}
