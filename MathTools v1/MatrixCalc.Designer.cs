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
            this.tbMatrix1 = new System.Windows.Forms.TextBox();
            this.tbMatrix2 = new System.Windows.Forms.TextBox();
            this.tbMatrix3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.pnlMatrix.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTools.Location = new System.Drawing.Point(0, 184);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(402, 83);
            this.pnlTools.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Controls.Add(this.tbMatrix3);
            this.pnlMatrix.Controls.Add(this.tbMatrix2);
            this.pnlMatrix.Controls.Add(this.tbMatrix1);
            this.pnlMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatrix.Location = new System.Drawing.Point(0, 50);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(402, 134);
            this.pnlMatrix.TabIndex = 3;
            // 
            // tbMatrix1
            // 
            this.tbMatrix1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMatrix1.Location = new System.Drawing.Point(0, 0);
            this.tbMatrix1.Multiline = true;
            this.tbMatrix1.Name = "tbMatrix1";
            this.tbMatrix1.Size = new System.Drawing.Size(134, 134);
            this.tbMatrix1.TabIndex = 0;
            // 
            // tbMatrix2
            // 
            this.tbMatrix2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMatrix2.Location = new System.Drawing.Point(134, 0);
            this.tbMatrix2.Multiline = true;
            this.tbMatrix2.Name = "tbMatrix2";
            this.tbMatrix2.Size = new System.Drawing.Size(134, 134);
            this.tbMatrix2.TabIndex = 1;
            // 
            // tbMatrix3
            // 
            this.tbMatrix3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMatrix3.Location = new System.Drawing.Point(268, 0);
            this.tbMatrix3.Multiline = true;
            this.tbMatrix3.Name = "tbMatrix3";
            this.tbMatrix3.Size = new System.Drawing.Size(134, 134);
            this.tbMatrix3.TabIndex = 2;
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(402, 26);
            this.panel1.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(55, 4);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(191, 4);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 20);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(328, 4);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 20);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(130, 4);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(20, 20);
            this.lblOperator.TabIndex = 3;
            this.lblOperator.Text = "+";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquals
            // 
            this.lblEquals.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(264, 4);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(20, 20);
            this.lblEquals.TabIndex = 4;
            this.lblEquals.Text = "=";
            this.lblEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatrixCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 267);
            this.Controls.Add(this.pnlMatrix);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(416, 292);
            this.Name = "MatrixCalc";
            this.Text = "MatrixCalc";
            this.Resize += new System.EventHandler(this.MatrixCalc_Resize);
            this.pnlMatrix.ResumeLayout(false);
            this.pnlMatrix.PerformLayout();
            this.panel1.ResumeLayout(false);
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
    }
}