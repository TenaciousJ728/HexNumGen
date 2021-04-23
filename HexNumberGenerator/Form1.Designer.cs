namespace HexNumberGen
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxStartAt = new System.Windows.Forms.TextBox();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.upDwnSize = new System.Windows.Forms.NumericUpDown();
            this.upDwnQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chckBoxRandom = new System.Windows.Forms.CheckBox();
            this.upDwnStep = new System.Windows.Forms.NumericUpDown();
            this.buttonCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnStep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leading zeroes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numbers to generate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxStartAt
            // 
            this.txtBoxStartAt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStartAt.Location = new System.Drawing.Point(165, 64);
            this.txtBoxStartAt.Name = "txtBoxStartAt";
            this.txtBoxStartAt.Size = new System.Drawing.Size(87, 20);
            this.txtBoxStartAt.TabIndex = 3;
            this.txtBoxStartAt.Text = "0000";
            this.txtBoxStartAt.TextChanged += new System.EventHandler(this.txtBoxStartAt_TextChanged);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.AcceptsReturn = true;
            this.txtBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutput.Location = new System.Drawing.Point(0, 116);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOutput.Size = new System.Drawing.Size(264, 214);
            this.txtBoxOutput.TabIndex = 5;
            // 
            // upDwnSize
            // 
            this.upDwnSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upDwnSize.Location = new System.Drawing.Point(165, 12);
            this.upDwnSize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.upDwnSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDwnSize.Name = "upDwnSize";
            this.upDwnSize.Size = new System.Drawing.Size(87, 20);
            this.upDwnSize.TabIndex = 1;
            this.upDwnSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.upDwnSize.ValueChanged += new System.EventHandler(this.upDwnSize_ValueChanged);
            // 
            // upDwnQuantity
            // 
            this.upDwnQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upDwnQuantity.Location = new System.Drawing.Point(165, 38);
            this.upDwnQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.upDwnQuantity.Name = "upDwnQuantity";
            this.upDwnQuantity.Size = new System.Drawing.Size(87, 20);
            this.upDwnQuantity.TabIndex = 2;
            this.upDwnQuantity.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.upDwnQuantity.ValueChanged += new System.EventHandler(this.upDwnQuantity_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start generating at (in hex)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Increment per number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chckBoxRandom
            // 
            this.chckBoxRandom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckBoxRandom.Enabled = false;
            this.chckBoxRandom.Location = new System.Drawing.Point(0, 344);
            this.chckBoxRandom.Name = "chckBoxRandom";
            this.chckBoxRandom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chckBoxRandom.Size = new System.Drawing.Size(164, 17);
            this.chckBoxRandom.TabIndex = 4;
            this.chckBoxRandom.Text = "Random number generation";
            this.chckBoxRandom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckBoxRandom.UseVisualStyleBackColor = true;
            this.chckBoxRandom.Visible = false;
            // 
            // upDwnStep
            // 
            this.upDwnStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upDwnStep.Location = new System.Drawing.Point(165, 90);
            this.upDwnStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDwnStep.Name = "upDwnStep";
            this.upDwnStep.Size = new System.Drawing.Size(87, 20);
            this.upDwnStep.TabIndex = 4;
            this.upDwnStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDwnStep.ValueChanged += new System.EventHandler(this.upDwnStep_ValueChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(0, 330);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(264, 31);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy All";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 361);
            this.Controls.Add(this.chckBoxRandom);
            this.Controls.Add(this.upDwnStep);
            this.Controls.Add(this.upDwnQuantity);
            this.Controls.Add(this.upDwnSize);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.txtBoxStartAt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCopy);
            this.MinimumSize = new System.Drawing.Size(280, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "HexNumGen";
            ((System.ComponentModel.ISupportInitialize)(this.upDwnSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxStartAt;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.NumericUpDown upDwnSize;
        private System.Windows.Forms.NumericUpDown upDwnQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chckBoxRandom;
        private System.Windows.Forms.NumericUpDown upDwnStep;
        private System.Windows.Forms.Button buttonCopy;
    }
}

