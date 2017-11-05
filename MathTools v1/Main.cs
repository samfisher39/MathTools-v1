using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Plotting_Try;
using System.Runtime.InteropServices;

namespace MathTools_v1
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
            integrator.TopLevel = false;
            integrator.AutoScroll = true;
            pnlMain.Controls.Add(integrator);
            var obj = (MatrixCalc)Application.OpenForms["MatrixCalc"];
            obj?.Close();
            pictureBox1.Hide();
            integrator.Show();
        }

        private void matrixCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var matrixcalc = new MatrixCalc();
            matrixcalc.TopLevel = false;
            matrixcalc.AutoScroll = true;
            pnlMain.Controls.Add(matrixcalc);
            var obj = (IntegralCalc)Application.OpenForms["IntegralCalc"];
            obj?.Close();
            pictureBox1.Hide();
            matrixcalc.Show();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}
