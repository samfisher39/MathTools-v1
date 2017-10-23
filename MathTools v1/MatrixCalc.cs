using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTools_v1
{
    public partial class MatrixCalc : Form
    {
        #region vars
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Matrixx A = new Matrixx();
        public Matrixx B = new Matrixx();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Initializers
        public MatrixCalc()
        {
            InitializeComponent();
            ResizeControls();
            lblMsgA.Text = "not a matrix";
            lblMsgB.Text = "not a matrix";
        }
        #endregion

        #region Events
        private void MatrixCalc_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void tbMatrix1_TextChanged(object sender, EventArgs e)
        {
            A = GetMatrixFromTb(ref lblMsgA, tbMatrix1);
            tbMatrix3.Text = A.GetAllValues();
        }
        private void tbMatrix2_TextChanged(object sender, EventArgs e)
        {
            B = GetMatrixFromTb(ref lblMsgA, tbMatrix1);
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

        #region Methods
        private void ResizeControls()
        {
            tbMatrix1.Width = pnlMatrix.Width / 3;
            tbMatrix2.Width = pnlMatrix.Width / 3;
            tbMatrix3.Width = pnlMatrix.Width / 3;
            lblA.Left = pnlMatrix.Width / 6 - 10 - lblA.Width / 2;
            lblOperator.Left = pnlMatrix.Width / 3 - 10;
            lblB.Left = 3 * pnlMatrix.Width / 6 - 10 - lblB.Width / 2;
            lblEquals.Left = 2 * pnlMatrix.Width / 3 - 10;
            lblC.Left = 5 * pnlMatrix.Width / 6 - 10;
        }
        
        private Matrixx StrToMtrx(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                var _str = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                var matrix = new Matrixx(_str.Length, _str[0].Split(' ').Length);
                var subSplit = _str[0].Split(' ');
                for (int i = 0; i < _str.Length; i++)
                {
                    for (int j = 0; j < subSplit.Length; j++)
                    {
                        matrix[i, j] = double.Parse(!string.IsNullOrWhiteSpace(_str[i].Split(' ')[j])
                                ? _str[i].Split(' ')[j]
                                : "0");
                    }
                }
                return matrix;
            }
            else{return new Matrixx();}
        }

        private Matrixx GetMatrixFromTb(ref Label label, TextBox tb)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            string matrixInputText = regex.Replace(tb.Text, " ");
            if (String.IsNullOrEmpty(matrixInputText) || String.IsNullOrWhiteSpace(matrixInputText))
            {
                label.Text = "error";
                label.ForeColor = Color.Red;
                return new Matrixx(1, 1);
            }
            else
            {
                string[] matrixInputTextSplit = matrixInputText.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;

                for (int i = 0; i < matrixInputTextSplit.Length; i++)
                {
                    string[] matrixInputTextSplitSecondary = matrixInputTextSplit[i].Split(' ');
                    if (i == 0) count = matrixInputTextSplitSecondary.Length;
                    else if (count != matrixInputTextSplitSecondary.Length)
                    {
                        label.Text = "error";
                        label.ForeColor = Color.Red;
                        break;
                    }
                    for (int j = 0; j < matrixInputTextSplitSecondary.Length; j++)
                    {
                        if (String.IsNullOrEmpty(matrixInputTextSplitSecondary[j])
                            || String.IsNullOrWhiteSpace(matrixInputTextSplitSecondary[j]))
                        {
                            label.Text = "error";
                            label.ForeColor = Color.Red;
                            break;
                        }
                        label.Text = "valid";
                        label.ForeColor = Color.MediumSpringGreen;
                    }
                }
                if (label.Text == "valid")
                {
                    try
                    {
                        Matrixx A = new Matrixx();
                        return StrToMtrx(tbMatrix1.Text);
                    }
                    catch
                    {
                        label.Text = "error";
                        label.ForeColor = Color.Red;
                    }
                }
                return new Matrixx(1, 1);
            }
            ResizeControls();
        }


        #endregion

    }
}
