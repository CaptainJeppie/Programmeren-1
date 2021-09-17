
namespace Assignment5
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
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.btnCalculatevarage = new System.Windows.Forms.Button();
            this.lblAv = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.lblAvarage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(61, 12);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(74, 17);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "Number 1:";
            this.lblNumber1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(61, 40);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(74, 17);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "Number 2:";
            // 
            // lblNumber3
            // 
            this.lblNumber3.AutoSize = true;
            this.lblNumber3.Location = new System.Drawing.Point(61, 71);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(74, 17);
            this.lblNumber3.TabIndex = 2;
            this.lblNumber3.Text = "Number 3:";
            // 
            // btnCalculatevarage
            // 
            this.btnCalculatevarage.Location = new System.Drawing.Point(64, 124);
            this.btnCalculatevarage.Name = "btnCalculatevarage";
            this.btnCalculatevarage.Size = new System.Drawing.Size(226, 32);
            this.btnCalculatevarage.TabIndex = 3;
            this.btnCalculatevarage.Text = "Calculate Avarage";
            this.btnCalculatevarage.UseVisualStyleBackColor = true;
            this.btnCalculatevarage.Click += new System.EventHandler(this.btnCalculatevarage_Click);
            // 
            // lblAv
            // 
            this.lblAv.AutoSize = true;
            this.lblAv.Location = new System.Drawing.Point(61, 189);
            this.lblAv.Name = "lblAv";
            this.lblAv.Size = new System.Drawing.Size(69, 17);
            this.lblAv.TabIndex = 4;
            this.lblAv.Text = "Avarage: ";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(190, 12);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 5;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(190, 40);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 6;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(190, 68);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(100, 22);
            this.txtNumber3.TabIndex = 7;
            this.txtNumber3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblAvarage
            // 
            this.lblAvarage.AutoSize = true;
            this.lblAvarage.Location = new System.Drawing.Point(244, 189);
            this.lblAvarage.Name = "lblAvarage";
            this.lblAvarage.Size = new System.Drawing.Size(12, 17);
            this.lblAvarage.TabIndex = 8;
            this.lblAvarage.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.lblAvarage);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblAv);
            this.Controls.Add(this.btnCalculatevarage);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Button btnCalculatevarage;
        private System.Windows.Forms.Label lblAv;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.Label lblAvarage;
    }
}

