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
        public Matrixx Aorigin = new Matrixx();
        public Matrixx Borigin = new Matrixx();
        public Matrixx C = new Matrixx();
        public int Digits = 3;
        public double Determinant;
        public char Cstate;
        public char RanIntReal;
        public char RanMatrixAorB;

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
            lblOperator.Text = "";
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
            ResizeControls();
        }

        private void tbMatrix2_TextChanged(object sender, EventArgs e)
        {
            B = GetMatrixFromTb(ref lblMsgB, tbMatrix2);
            ResizeControls();
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
                    C = Sum(A, B);
                    Cstate = 'm';
                    break;
                case "A - B":
                    C = Sub(A, B);
                    Cstate = 'm';
                    break;
                case "A * B":
                    C = Multiplication(A, B);
                    Cstate = 'm';
                    break;
                case "det(A)":
                    Determinant = Det(A);
                    Cstate = 's';
                    break;
                case "det(B)":
                    Determinant = Det(B);
                    Cstate = 's';
                    break;
                default:
                    break;
            }
            UpdateTbxs();
        }

        private void cbbOperation_TextChanged(object sender, EventArgs e)
        {
            switch (cbbOperation.Text)
            {
                case "A + B":
                    lblOperator.Text = "+";
                    break;
                case "A - B":
                    lblOperator.Text = "-";
                    break;
                case "A * B":
                    lblOperator.Text = "*";
                    break;
                default:
                    lblOperator.Text = string.Empty;
                    break;
            }
            ResizeControls();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Digits = (int) numericUpDown1.Value;
                if (((A.DimI == B.DimI)&(A.DimJ == B.DimJ) & (cbbOperation.Text == "A + B" || cbbOperation.Text == "A - B")) || (A.DimJ == B.DimI) & 
                    cbbOperation.Text == "A * B")
                {
                    switch (cbbOperation.Text)
                    {
                        case "A + B":
                            C = Sum(A, B);
                            Cstate = 'm';
                            break;
                        case "A - B":
                            C = Sub(A, B);
                            Cstate = 'm';
                            break;
                        case "A * B":
                            C = Multiplication(A, B);
                            Cstate = 'm';
                            break;
                        case "det(A)":
                            Determinant = Det(A);
                            Cstate = 's';
                            break;
                        case "det(B)":
                            Determinant = Det(B);
                            Cstate = 's';
                            break;
                        default:
                            break;
                    }
                }
                
                UpdateTbxs();

            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (RanMatrixAorB)
                {
                    case 'A':
                        Aorigin = RandomMatrix(int.Parse(tbRanMatrixM.Text), int.Parse(tbRanMatrixN.Text), RanIntReal, int.Parse(tbRanMatrixRanFrom.Text),
                            int.Parse(tbRanMatrixRanTo.Text));
                        tbMatrix1.Text = Aorigin.GetAllValues(Digits);
                        break;
                    case 'B':
                        Borigin = RandomMatrix(int.Parse(tbRanMatrixM.Text), int.Parse(tbRanMatrixN.Text), RanIntReal, int.Parse(tbRanMatrixRanFrom.Text),
                            int.Parse(tbRanMatrixRanTo.Text));
                        tbMatrix2.Text = Borigin.GetAllValues(Digits);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                //ignored;
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
            lblMsgA.Left = pnlMatrix.Width / 6 - 10 - lblMsgA.Width / 2;
            lblMsgB.Left = 3 * pnlMatrix.Width / 6 - 10 - lblMsgB.Width / 2;
        }
        
        private Matrixx StrToMtrx(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                var substr = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                var matrix = new Matrixx(substr.Length, substr[0].Trim().Split(' ').Length);
                var subSplit = substr[0].Trim().Split(' ');
                for (int i = 0; i < substr.Length; i++)
                {
                    for (int j = 0; j < subSplit.Length; j++)
                    {
                        matrix.Data[i, j] = double.Parse(!string.IsNullOrWhiteSpace(substr[i].Trim().Split(' ')[j])
                            ? substr[i].Trim().Split(' ')[j] : "0");
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
                    string[] matrixInputTextSplitSecondary = matrixInputTextSplit[i].Trim().Split(' ');
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
                        label.Text = "error";
                        label.ForeColor = Color.Red;
                    }
                }
                return new Matrixx(1, 1);
            }
        }

        private void UpdateTbxs()
        {
            if (Cstate == 'm')
            {
                tbMatrix3.Text = C.GetAllValues(Digits);
            }
            else if (Cstate == 's')
            {
                tbMatrix3.Text = Determinant.ToString();
            }
            tbMatrix1.Text = Aorigin.GetAllValues(Digits);
            tbMatrix2.Text = Borigin.GetAllValues(Digits);

        }

        private Matrixx RandomMatrix(int m, int n, char num, int? from, int? to)
        {
            var rdm = new Random();
            var matrix = new Matrixx(m, n);
            if (!from.HasValue || !to.HasValue)
            {
                from = -10;
                to = 10;
            }
            var scale = to - from;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (num == 'r')
                    {
                        var sign = Math.Sign(rdm.Next());
                        matrix.Data[i, j] = Convert.ToDouble(from + rdm.NextDouble() * scale);
                    }
                    else if (num == 'i')
                    {
                        matrix.Data[i, j] = rdm.Next((int)from, (int)to);
                    }
                }
            }
            return matrix;
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
            MessageBox.Show("Dimension 2 of A is not the same as Dimension 1 of B!");
            return new Matrixx();
        }

        private static double Det(Matrixx a)
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

        private void chbSetReal_Click(object sender, EventArgs e)
        {
            RanIntReal = 'r';
            chbSetInteger.Checked = false;
            chbSetReal.Checked = true;
        }

        private void chbSetInteger_Click(object sender, EventArgs e)
        {
            RanIntReal = 'i';
            chbSetReal.Checked = false;
            chbSetInteger.Checked = true;
        }

        private void cbSelectA_Click(object sender, EventArgs e)
        {
            RanMatrixAorB = 'A';
            cbSelectB.Checked = false;
        }

        private void cbSelectB_Click(object sender, EventArgs e)
        {
            RanMatrixAorB = 'B';
            cbSelectA.Checked = false;
        }
    }
}
