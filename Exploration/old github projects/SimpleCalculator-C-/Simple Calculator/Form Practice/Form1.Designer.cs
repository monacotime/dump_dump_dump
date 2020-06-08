namespace Form_Practice
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
            this.AddBut = new System.Windows.Forms.Button();
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SubBut = new System.Windows.Forms.Button();
            this.MulBut = new System.Windows.Forms.Button();
            this.DivBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(35, 158);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 23);
            this.AddBut.TabIndex = 0;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(35, 74);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 20);
            this.box1.TabIndex = 1;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(141, 74);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 20);
            this.box2.TabIndex = 2;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(29, 253);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(155, 31);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "*ANSWER*";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubBut
            // 
            this.SubBut.Location = new System.Drawing.Point(116, 158);
            this.SubBut.Name = "SubBut";
            this.SubBut.Size = new System.Drawing.Size(75, 23);
            this.SubBut.TabIndex = 4;
            this.SubBut.Text = "Sub";
            this.SubBut.UseVisualStyleBackColor = true;
            this.SubBut.Click += new System.EventHandler(this.SubBut_Click);
            // 
            // MulBut
            // 
            this.MulBut.Location = new System.Drawing.Point(197, 158);
            this.MulBut.Name = "MulBut";
            this.MulBut.Size = new System.Drawing.Size(75, 23);
            this.MulBut.TabIndex = 5;
            this.MulBut.Text = "Multiply";
            this.MulBut.UseVisualStyleBackColor = true;
            this.MulBut.Click += new System.EventHandler(this.MulBut_Click);
            // 
            // DivBut
            // 
            this.DivBut.Location = new System.Drawing.Point(275, 158);
            this.DivBut.Name = "DivBut";
            this.DivBut.Size = new System.Drawing.Size(75, 23);
            this.DivBut.TabIndex = 6;
            this.DivBut.Text = "Divide";
            this.DivBut.UseVisualStyleBackColor = true;
            this.DivBut.Click += new System.EventHandler(this.DivBut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DivBut);
            this.Controls.Add(this.MulBut);
            this.Controls.Add(this.SubBut);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.AddBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator - Monoco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button SubBut;
        private System.Windows.Forms.Button MulBut;
        private System.Windows.Forms.Button DivBut;
        private System.Windows.Forms.Button button1;
    }
}

