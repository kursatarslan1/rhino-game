namespace RhinoGame
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Ates = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbRhino2 = new System.Windows.Forms.ComboBox();
            this.cbRhino1 = new System.Windows.Forms.ComboBox();
            this.txtBoxRhino2 = new System.Windows.Forms.TextBox();
            this.txtBoxRhino1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Ates
            // 
            this.Ates.Interval = 10;
            this.Ates.Tick += new System.EventHandler(this.Ates_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.cbRhino2);
            this.panel1.Controls.Add(this.cbRhino1);
            this.panel1.Controls.Add(this.txtBoxRhino2);
            this.panel1.Controls.Add(this.txtBoxRhino1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 412);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(195, 284);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(239, 65);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbRhino2
            // 
            this.cbRhino2.FormattingEnabled = true;
            this.cbRhino2.Items.AddRange(new object[] {
            "White",
            "Orange",
            "Yellow",
            "Green",
            "Blue"});
            this.cbRhino2.Location = new System.Drawing.Point(381, 208);
            this.cbRhino2.Name = "cbRhino2";
            this.cbRhino2.Size = new System.Drawing.Size(150, 21);
            this.cbRhino2.TabIndex = 3;
            // 
            // cbRhino1
            // 
            this.cbRhino1.FormattingEnabled = true;
            this.cbRhino1.Items.AddRange(new object[] {
            "White",
            "Orange",
            "Yellow",
            "Green",
            "Blue"});
            this.cbRhino1.Location = new System.Drawing.Point(74, 208);
            this.cbRhino1.Name = "cbRhino1";
            this.cbRhino1.Size = new System.Drawing.Size(150, 21);
            this.cbRhino1.TabIndex = 2;
            // 
            // txtBoxRhino2
            // 
            this.txtBoxRhino2.Location = new System.Drawing.Point(381, 123);
            this.txtBoxRhino2.Name = "txtBoxRhino2";
            this.txtBoxRhino2.Size = new System.Drawing.Size(150, 20);
            this.txtBoxRhino2.TabIndex = 1;
            // 
            // txtBoxRhino1
            // 
            this.txtBoxRhino1.Location = new System.Drawing.Point(74, 123);
            this.txtBoxRhino1.Name = "txtBoxRhino1";
            this.txtBoxRhino1.Size = new System.Drawing.Size(150, 20);
            this.txtBoxRhino1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rhino 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rhino 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Color: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 446);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer Ates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbRhino2;
        private System.Windows.Forms.ComboBox cbRhino1;
        private System.Windows.Forms.TextBox txtBoxRhino2;
        private System.Windows.Forms.TextBox txtBoxRhino1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

