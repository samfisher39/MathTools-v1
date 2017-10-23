namespace MathTools_v1
{
    partial class MatrixCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTools = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.tbMatrix3 = new System.Windows.Forms.TextBox();
            this.tbMatrix2 = new System.Windows.Forms.TextBox();
            this.tbMatrix1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMsgB = new System.Windows.Forms.Label();
            this.lblMsgA = new System.Windows.Forms.Label();
            this.pnlMatrix.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTools.Location = new System.Drawing.Point(0, 233);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(416, 80);
            this.pnlTools.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMatrix.Controls.Add(this.tbMatrix3);
            this.pnlMatrix.Controls.Add(this.tbMatrix2);
            this.pnlMatrix.Controls.Add(this.tbMatrix1);
            this.pnlMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatrix.Location = new System.Drawing.Point(0, 50);
            this.pnlMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(416, 143);
            this.pnlMatrix.TabIndex = 3;
            // 
            // tbMatrix3
            // 
            this.tbMatrix3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbMatrix3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMatrix3.ForeColor = System.Drawing.Color.White;
            this.tbMatrix3.Location = new System.Drawing.Point(268, 0);
            this.tbMatrix3.Multiline = true;
            this.tbMatrix3.Name = "tbMatrix3";
            this.tbMatrix3.Size = new System.Drawing.Size(148, 143);
            this.tbMatrix3.TabIndex = 2;
            // 
            // tbMatrix2
            // 
            this.tbMatrix2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbMatrix2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMatrix2.ForeColor = System.Drawing.Color.White;
            this.tbMatrix2.Location = new System.Drawing.Point(134, 0);
            this.tbMatrix2.Multiline = true;
            this.tbMatrix2.Name = "tbMatrix2";
            this.tbMatrix2.Size = new System.Drawing.Size(134, 143);
            this.tbMatrix2.TabIndex = 1;
            this.tbMatrix2.TextChanged += new System.EventHandler(this.tbMatrix2_TextChanged);
            // 
            // tbMatrix1
            // 
            this.tbMatrix1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbMatrix1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMatrix1.ForeColor = System.Drawing.Color.White;
            this.tbMatrix1.Location = new System.Drawing.Point(0, 0);
            this.tbMatrix1.Multiline = true;
            this.tbMatrix1.Name = "tbMatrix1";
            this.tbMatrix1.Size = new System.Drawing.Size(134, 143);
            this.tbMatrix1.TabIndex = 0;
            this.tbMatrix1.TextChanged += new System.EventHandler(this.tbMatrix1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblEquals);
            this.panel1.Controls.Add(this.lblOperator);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 26);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 26);
            this.panel1.TabIndex = 2;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.ForeColor = System.Drawing.Color.Cyan;
            this.lblEquals.Location = new System.Drawing.Point(264, 4);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(18, 19);
            this.lblEquals.TabIndex = 4;
            this.lblEquals.Text = "=";
            this.lblEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.Cyan;
            this.lblOperator.Location = new System.Drawing.Point(130, 4);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(18, 19);
            this.lblOperator.TabIndex = 3;
            this.lblOperator.Text = "+";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Cyan;
            this.lblC.Location = new System.Drawing.Point(328, 4);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 19);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Cyan;
            this.lblB.Location = new System.Drawing.Point(191, 4);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 19);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Cyan;
            this.lblA.Location = new System.Drawing.Point(55, 4);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 19);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblMsgB);
            this.panel2.Controls.Add(this.lblMsgA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 40);
            this.panel2.TabIndex = 4;
            // 
            // lblMsgB
            // 
            this.lblMsgB.AutoSize = true;
            this.lblMsgB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgB.ForeColor = System.Drawing.Color.Cyan;
            this.lblMsgB.Location = new System.Drawing.Point(179, 11);
            this.lblMsgB.Name = "lblMsgB";
            this.lblMsgB.Size = new System.Drawing.Size(60, 19);
            this.lblMsgB.TabIndex = 1;
            this.lblMsgB.Text = "lblMsgB";
            // 
            // lblMsgA
            // 
            this.lblMsgA.AutoSize = true;
            this.lblMsgA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgA.ForeColor = System.Drawing.Color.Cyan;
            this.lblMsgA.Location = new System.Drawing.Point(42, 10);
            this.lblMsgA.Name = "lblMsgA";
            this.lblMsgA.Size = new System.Drawing.Size(61, 19);
            this.lblMsgA.TabIndex = 0;
            this.lblMsgA.Text = "lblMsgA";
            // 
            // MatrixCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(416, 313);
            this.Controls.Add(this.pnlMatrix);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(416, 292);
            this.Name = "MatrixCalc";
            this.Text = "MatrixCalc";
            this.Resize += new System.EventHandler(this.MatrixCalc_Resize);
            this.pnlMatrix.ResumeLayout(false);
            this.pnlMatrix.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.TextBox tbMatrix2;
        private System.Windows.Forms.TextBox tbMatrix1;
        private System.Windows.Forms.TextBox tbMatrix3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMsgB;
        private System.Windows.Forms.Label lblMsgA;
    }
}