namespace S_koordinat
{
    partial class CtAbPC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.buttonOpenTxt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelResultX = new System.Windows.Forms.Label();
            this.labelResultY = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonCalculation);
            this.panel1.Controls.Add(this.buttonOpenTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(4, 402);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(184, 45);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Location = new System.Drawing.Point(4, 51);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(184, 43);
            this.buttonCalculation.TabIndex = 1;
            this.buttonCalculation.Text = "Calculation";
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // buttonOpenTxt
            // 
            this.buttonOpenTxt.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenTxt.Name = "buttonOpenTxt";
            this.buttonOpenTxt.Size = new System.Drawing.Size(184, 40);
            this.buttonOpenTxt.TabIndex = 0;
            this.buttonOpenTxt.Text = "Open File";
            this.buttonOpenTxt.UseVisualStyleBackColor = true;
            this.buttonOpenTxt.Click += new System.EventHandler(this.buttonOpenTxt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelResultX);
            this.panel2.Controls.Add(this.labelResultY);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 450);
            this.panel2.TabIndex = 1;
            // 
            // labelResultX
            // 
            this.labelResultX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultX.AutoSize = true;
            this.labelResultX.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultX.Location = new System.Drawing.Point(178, 133);
            this.labelResultX.Name = "labelResultX";
            this.labelResultX.Size = new System.Drawing.Size(180, 57);
            this.labelResultX.TabIndex = 2;
            this.labelResultX.Text = "Sx : 0.0";
            // 
            // labelResultY
            // 
            this.labelResultY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultY.AutoSize = true;
            this.labelResultY.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultY.Location = new System.Drawing.Point(180, 202);
            this.labelResultY.Name = "labelResultY";
            this.labelResultY.Size = new System.Drawing.Size(179, 57);
            this.labelResultY.TabIndex = 1;
            this.labelResultY.Text = "Sy : 0.0";
            // 
            // CtAbPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "CtAbPC";
            this.Text = "CtAbPC";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.Button buttonOpenTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelResultX;
        private System.Windows.Forms.Label labelResultY;
    }
}

