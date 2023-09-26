namespace CSolW
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.setPath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.holes = new System.Windows.Forms.NumericUpDown();
            this.d7 = new System.Windows.Forms.NumericUpDown();
            this.d6 = new System.Windows.Forms.NumericUpDown();
            this.d5 = new System.Windows.Forms.NumericUpDown();
            this.d4 = new System.Windows.Forms.NumericUpDown();
            this.d3 = new System.Windows.Forms.NumericUpDown();
            this.d2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.d1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(13, 12);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(271, 22);
            this.textBoxPath.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxPath, "Path for saving");
            // 
            // setPath
            // 
            this.setPath.Location = new System.Drawing.Point(290, 12);
            this.setPath.Name = "setPath";
            this.setPath.Size = new System.Drawing.Size(75, 23);
            this.setPath.TabIndex = 2;
            this.setPath.Text = "Set Path";
            this.toolTip.SetToolTip(this.setPath, "Set new path");
            this.setPath.UseVisualStyleBackColor = true;
            this.setPath.Click += new System.EventHandler(this.setPath_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.holes);
            this.panel1.Controls.Add(this.d7);
            this.panel1.Controls.Add(this.d6);
            this.panel1.Controls.Add(this.d5);
            this.panel1.Controls.Add(this.d4);
            this.panel1.Controls.Add(this.d3);
            this.panel1.Controls.Add(this.d2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.d1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 332);
            this.panel1.TabIndex = 3;
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(297, 304);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(54, 23);
            this.reset.TabIndex = 2;
            this.reset.Text = "reset";
            this.toolTip.SetToolTip(this.reset, "Reset d1-d7 to standart values");
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // holes
            // 
            this.holes.BackColor = System.Drawing.Color.White;
            this.holes.Location = new System.Drawing.Point(107, 275);
            this.holes.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.holes.Name = "holes";
            this.holes.Size = new System.Drawing.Size(120, 22);
            this.holes.TabIndex = 1;
            this.toolTip.SetToolTip(this.holes, "[0; 50000] Number of Holes > (pi*d4)/(2*d6)");
            this.holes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.holes.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.holes.Enter += new System.EventHandler(this.Num_Enter);
            this.holes.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // d7
            // 
            this.d7.BackColor = System.Drawing.Color.White;
            this.d7.DecimalPlaces = 1;
            this.d7.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.d7.Location = new System.Drawing.Point(108, 209);
            this.d7.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.d7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d7.Name = "d7";
            this.d7.Size = new System.Drawing.Size(120, 22);
            this.d7.TabIndex = 1;
            this.toolTip.SetToolTip(this.d7, "[0.1; 500000]  d1>=d7");
            this.d7.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.d7.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.d7.Enter += new System.EventHandler(this.Num_Enter);
            this.d7.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // d6
            // 
            this.d6.BackColor = System.Drawing.Color.White;
            this.d6.DecimalPlaces = 1;
            this.d6.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.d6.Location = new System.Drawing.Point(108, 176);
            this.d6.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.d6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(120, 22);
            this.d6.TabIndex = 1;
            this.toolTip.SetToolTip(this.d6, "[0.1; 500000] d6<d5, d6<d4, d6<d4, d6 < (d5-d4)/2");
            this.d6.Value = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            this.d6.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.d6.Enter += new System.EventHandler(this.Num_Enter);
            this.d6.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // d5
            // 
            this.d5.BackColor = System.Drawing.Color.White;
            this.d5.DecimalPlaces = 1;
            this.d5.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.d5.Location = new System.Drawing.Point(108, 143);
            this.d5.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.d5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(120, 22);
            this.d5.TabIndex = 1;
            this.toolTip.SetToolTip(this.d5, "[0.1; 500000] d5>d4, d5<d3*2, d5>2*d6+d4");
            this.d5.Value = new decimal(new int[] {
            46,
            0,
            0,
            0});
            this.d5.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.d5.Enter += new System.EventHandler(this.Num_Enter);
            this.d5.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.White;
            this.d4.DecimalPlaces = 1;
            this.d4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.d4.Location = new System.Drawing.Point(108, 110);
            this.d4.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.d4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(120, 22);
            this.d4.TabIndex = 1;
            this.toolTip.SetToolTip(this.d4, "[0.1; 500000] d4<d3, d4<d5, d4<d6, d4< 2*d6-d5\r\n");
            this.d4.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.d4.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.d4.Enter += new System.EventHandler(this.Num_Enter);
            this.d4.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.White;
            this.d3.DecimalPlaces = 1;
            this.d3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.d3.Location = new System.Drawing.Point(108, 77);
            this.d3.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.d3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(120, 22);
            this.d3.TabIndex = 1;
            this.toolTip.SetToolTip(this.d3, "[0.1; 500000] d3>d4/2, d3>d5/2, d3>d6\r\n");
            this.d3.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.d3.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.d3.Enter += new System.EventHandler(this.Num_Enter);
            this.d3.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.White;
            this.d2.DecimalPlaces = 1;
            this.d2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.d2.Location = new System.Drawing.Point(108, 44);
            this.d2.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.d2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(120, 22);
            this.d2.TabIndex = 1;
            this.toolTip.SetToolTip(this.d2, "[0.1; 500000] d2<d1");
            this.d2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.d2.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.d2.Enter += new System.EventHandler(this.Num_Enter);
            this.d2.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "NumOfHoles";
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.White;
            this.d1.DecimalPlaces = 1;
            this.d1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.d1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.d1.Location = new System.Drawing.Point(108, 11);
            this.d1.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.d1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(120, 22);
            this.d1.TabIndex = 1;
            this.toolTip.SetToolTip(this.d1, "[0.1; 500000] d1>d2, d1>d7");
            this.d1.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.d1.ValueChanged += new System.EventHandler(this.Check_ValueChanged);
            this.d1.Enter += new System.EventHandler(this.Num_Enter);
            this.d1.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(16, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "D7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "D6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "D5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "D4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "D3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "D2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "D1";
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.create.Location = new System.Drawing.Point(13, 398);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(352, 40);
            this.create.TabIndex = 4;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.create);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Main";
            this.Text = "Ролик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button setPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown d7;
        private System.Windows.Forms.NumericUpDown d6;
        private System.Windows.Forms.NumericUpDown d5;
        private System.Windows.Forms.NumericUpDown d4;
        private System.Windows.Forms.NumericUpDown d3;
        private System.Windows.Forms.NumericUpDown d2;
        private System.Windows.Forms.NumericUpDown d1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown holes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip Tip;
    }
}

