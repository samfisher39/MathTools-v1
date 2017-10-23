using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
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
        }

        private void tbMatrix2_TextChanged(object sender, EventArgs e)
        {
            B = GetMatrixFromTb(ref lblMsgB, tbMatrix2);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch (cbbOperation.Text)
            {
                case "A + B":
                    tbMatrix3.Text = Sum(A, B).GetAllValues();
                    break;
                case "A - B":
                    tbMatrix3.Text = Sub(A, B).GetAllValues();
                    break;
                case "A * B":
                    tbMatrix3.Text = Multiplication(A, B).GetAllValues();
                    break;
                case "det(A)":
                    tbMatrix3.Text = Det(A).ToString();
                    break;
                case "det(B)":
                    tbMatrix3.Text = Det(B).ToString();
                    break;
                default:
                    MessageBox.Show("Select an operation!");
                    break;
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
                var substr = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                var matrix = new Matrixx(substr.Length, substr[0].Split(' ').Length);
                var subSplit = substr[0].Split(' ');
                for (int i = 0; i < substr.Length; i++)
                {
                    for (int j = 0; j < subSplit.Length; j++)
                    {
                        matrix[i, j] = double.Parse(!string.IsNullOrWhiteSpace(substr[i].Split(' ')[j])
                                ? substr[i].Split(' ')[j] : "0");
                    }
                }
                return matrix;
            }
            else{return new Matrixx();}
        }

        private Matrixx GetMatrixFromTb(ref Label label, TextBox tb)
        {
            int index = tb.SelectionStart;                                                          //-----------------
            tb.Text = tb.Text.Replace(".", ",");                                                    // | replace . with , and keep cursor position
            tb.SelectionStart = index;                                                              //-----------------
            RegexOptions options = RegexOptions.None;                                               //-----------------
            Regex regex = new Regex("[ ]{2,}", options);                                            // | remove extra whitespaces
            string matrixInputText = regex.Replace(tb.Text.Trim(' '), " ");                         //-----------------
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
                        return StrToMtrx(tb.Text);
                    }
                    catch
                    {
                        MessageBox.Show(matrixInputText);
                        label.Text = "error";
                        label.ForeColor = Color.Red;
                    }
                }
                return new Matrixx(1, 1);
            }
        }
        #endregion

        #region MatrixOps
        private Matrixx Sum(Matrixx a, Matrixx B)
        {
            var matrix = new Matrixx(a.DimI, a.DimJ);
            if (a.DimI == B.DimI & a.DimJ == B.DimJ)
            {
                for (int i = 0; i < a.DimI; i++)
                {
                    for (int j = 0; j < a.DimJ; j++)
                    {
                        matrix.Data[i, j] = a.Data[i, j] + B.Data[i, j];
                    }
                }
                return matrix;
            }
            MessageBox.Show("A and B don't have the same dimension!");
            return new Matrixx();
        }

        private Matrixx Sub(Matrixx a, Matrixx B)
        {
            var matrix = new Matrixx(a.DimI, a.DimJ);
            if (a.DimI == B.DimI & a.DimJ == B.DimJ)
            {
                for (int i = 0; i < a.DimI; i++)
                {
                    for (int j = 0; j < a.DimJ; j++)
                    {
                        matrix.Data[i, j] = a.Data[i, j] - B.Data[i, j];
                    }
                }
                return matrix;
            }
            MessageBox.Show("A and B don't have the same dimension!");
            return new Matrixx();
        }

        private Matrixx Multiplication(Matrixx a, Matrixx b)
        {
            var matrix = new Matrixx(a.DimI, b.DimJ);
            if (a.DimJ == b.DimI)
            {
                for (int i = 0; i < a.DimI; i++)
                {
                    for (int k = 0; k < b.DimJ; k++)
                    {
                        matrix.Data[i, k] = 0;
                        for (int j = 0; j < a.DimJ; j++)
                        {
                            matrix.Data[i, k] += a.Data[i, j] * b.Data[j, k];
                        }
                    }
                }
                return matrix;
            }
            MessageBox.Show("The 2nd dimension of A is not equal to the 1st dimension of B!");
            return new Matrixx();
        }

        private double Det(Matrixx a)
        {
            int n = int.Parse(System.Math.Sqrt(a.Data.Length).ToString());
            int nm1 = n - 1;
            int kp1;
            double p;
            double det = 1;
            for (int k = 0; k < nm1; k++)
            {
                kp1 = k + 1;
                for (int i = kp1; i < n; i++)
                {
                    p = a.Data[i, k] / a.Data[k, k];
                    for (int j = kp1; j < n; j++)
                        a.Data[i, j] = a.Data[i, j] - p * a.Data[k, j];
                }
            }
            for (int i = 0; i < n; i++)
                det = det * a.Data[i, i];
            return det;
        }
        #endregion
    }
}
