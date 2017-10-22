namespace Plotting_Try
{
    partial class IntegralCalc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtbIntegralInfo = new System.Windows.Forms.RichTextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btnSetA = new System.Windows.Forms.Button();
            this.btnSetB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.plot1);
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.btnSetB);
            this.splitContainer1.Panel2.Controls.Add(this.btnSetA);
            this.splitContainer1.Panel2.Controls.Add(this.tbB);
            this.splitContainer1.Panel2.Controls.Add(this.tbA);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.rtbIntegralInfo);
            this.splitContainer1.Panel2.Controls.Add(this.rtbData);
            this.splitContainer1.Panel2MinSize = 288;
            this.splitContainer1.Size = new System.Drawing.Size(792, 530);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 1;
            // 
            // plot1
            // 
            this.plot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(498, 528);
            this.plot1.TabIndex = 0;
            this.plot1.Text = "plotView1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Just do it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 2;
            // 
            // rtbIntegralInfo
            // 
            this.rtbIntegralInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbIntegralInfo.Location = new System.Drawing.Point(0, 409);
            this.rtbIntegralInfo.Name = "rtbIntegralInfo";
            this.rtbIntegralInfo.Size = new System.Drawing.Size(286, 119);
            this.rtbIntegralInfo.TabIndex = 1;
            this.rtbIntegralInfo.Text = "";
            // 
            // rtbData
            // 
            this.rtbData.BackColor = System.Drawing.Color.Black;
            this.rtbData.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbData.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rtbData.Location = new System.Drawing.Point(0, 0);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(286, 349);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(4, 357);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(68, 20);
            this.tbA.TabIndex = 4;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(145, 357);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(68, 20);
            this.tbB.TabIndex = 5;
            // 
            // btnSetA
            // 
            this.btnSetA.Location = new System.Drawing.Point(78, 355);
            this.btnSetA.Name = "btnSetA";
            this.btnSetA.Size = new System.Drawing.Size(61, 23);
            this.btnSetA.TabIndex = 6;
            this.btnSetA.Text = "Set a";
            this.btnSetA.UseVisualStyleBackColor = true;
            this.btnSetA.Click += new System.EventHandler(this.btnSetA_Click);
            // 
            // btnSetB
            // 
            this.btnSetB.Location = new System.Drawing.Point(219, 355);
            this.btnSetB.Name = "btnSetB";
            this.btnSetB.Size = new System.Drawing.Size(61, 23);
            this.btnSetB.TabIndex = 7;
            this.btnSetB.Text = "Set b";
            this.btnSetB.UseVisualStyleBackColor = true;
            this.btnSetB.Click += new System.EventHandler(this.btnSetB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.RichTextBox rtbIntegralInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSetB;
        private System.Windows.Forms.Button btnSetA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
    }
}

