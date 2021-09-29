
namespace assignment8
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
            this.btncompare = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lblEnternumber = new System.Windows.Forms.Label();
            this.lblSum1 = new System.Windows.Forms.Label();
            this.lblSum2 = new System.Windows.Forms.Label();
            this.lblanswersum1 = new System.Windows.Forms.Label();
            this.lblanswersum2 = new System.Windows.Forms.Label();
            this.lblequalnumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncompare
            // 
            this.btncompare.Location = new System.Drawing.Point(12, 73);
            this.btncompare.Name = "btncompare";
            this.btncompare.Size = new System.Drawing.Size(214, 23);
            this.btncompare.TabIndex = 0;
            this.btncompare.Text = "Compare";
            this.btncompare.UseVisualStyleBackColor = true;
            this.btncompare.Click += new System.EventHandler(this.btncompare_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(126, 34);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 20);
            this.txtnumber.TabIndex = 1;
            // 
            // lblEnternumber
            // 
            this.lblEnternumber.AutoSize = true;
            this.lblEnternumber.Location = new System.Drawing.Point(12, 37);
            this.lblEnternumber.Name = "lblEnternumber";
            this.lblEnternumber.Size = new System.Drawing.Size(94, 13);
            this.lblEnternumber.TabIndex = 2;
            this.lblEnternumber.Text = "Enter a number (n)";
            // 
            // lblSum1
            // 
            this.lblSum1.AutoSize = true;
            this.lblSum1.Location = new System.Drawing.Point(12, 124);
            this.lblSum1.Name = "lblSum1";
            this.lblSum1.Size = new System.Drawing.Size(70, 13);
            this.lblSum1.TabIndex = 3;
            this.lblSum1.Text = "1 + 2 + ... + n";
            // 
            // lblSum2
            // 
            this.lblSum2.AutoSize = true;
            this.lblSum2.Location = new System.Drawing.Point(12, 162);
            this.lblSum2.Name = "lblSum2";
            this.lblSum2.Size = new System.Drawing.Size(101, 13);
            this.lblSum2.TabIndex = 4;
            this.lblSum2.Text = "sum = n * (n + 1) / 2";
            // 
            // lblanswersum1
            // 
            this.lblanswersum1.AutoSize = true;
            this.lblanswersum1.Location = new System.Drawing.Point(191, 124);
            this.lblanswersum1.Name = "lblanswersum1";
            this.lblanswersum1.Size = new System.Drawing.Size(16, 13);
            this.lblanswersum1.TabIndex = 5;
            this.lblanswersum1.Text = "   ";
            // 
            // lblanswersum2
            // 
            this.lblanswersum2.AutoSize = true;
            this.lblanswersum2.Location = new System.Drawing.Point(191, 162);
            this.lblanswersum2.Name = "lblanswersum2";
            this.lblanswersum2.Size = new System.Drawing.Size(16, 13);
            this.lblanswersum2.TabIndex = 6;
            this.lblanswersum2.Text = "   ";
            // 
            // lblequalnumbers
            // 
            this.lblequalnumbers.AutoSize = true;
            this.lblequalnumbers.Location = new System.Drawing.Point(12, 202);
            this.lblequalnumbers.Name = "lblequalnumbers";
            this.lblequalnumbers.Size = new System.Drawing.Size(16, 13);
            this.lblequalnumbers.TabIndex = 7;
            this.lblequalnumbers.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 237);
            this.Controls.Add(this.lblequalnumbers);
            this.Controls.Add(this.lblanswersum2);
            this.Controls.Add(this.lblanswersum1);
            this.Controls.Add(this.lblSum2);
            this.Controls.Add(this.lblSum1);
            this.Controls.Add(this.lblEnternumber);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.btncompare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncompare;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lblEnternumber;
        private System.Windows.Forms.Label lblSum1;
        private System.Windows.Forms.Label lblSum2;
        private System.Windows.Forms.Label lblanswersum1;
        private System.Windows.Forms.Label lblanswersum2;
        private System.Windows.Forms.Label lblequalnumbers;
    }
}

