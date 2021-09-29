
namespace assignment7
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
            this.lblSide = new System.Windows.Forms.Label();
            this.lblsquare = new System.Windows.Forms.Label();
            this.btncreatesquare = new System.Windows.Forms.Button();
            this.txtsidelength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(51, 26);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(28, 13);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Side";
            // 
            // lblsquare
            // 
            this.lblsquare.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsquare.Location = new System.Drawing.Point(54, 105);
            this.lblsquare.Name = "lblsquare";
            this.lblsquare.Size = new System.Drawing.Size(184, 213);
            this.lblsquare.TabIndex = 1;
            this.lblsquare.Text = "   ";
            this.lblsquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncreatesquare
            // 
            this.btncreatesquare.Location = new System.Drawing.Point(54, 60);
            this.btncreatesquare.Name = "btncreatesquare";
            this.btncreatesquare.Size = new System.Drawing.Size(184, 25);
            this.btncreatesquare.TabIndex = 2;
            this.btncreatesquare.Text = "Create square";
            this.btncreatesquare.UseVisualStyleBackColor = true;
            this.btncreatesquare.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsidelength
            // 
            this.txtsidelength.Location = new System.Drawing.Point(138, 23);
            this.txtsidelength.Name = "txtsidelength";
            this.txtsidelength.Size = new System.Drawing.Size(100, 20);
            this.txtsidelength.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 388);
            this.Controls.Add(this.txtsidelength);
            this.Controls.Add(this.btncreatesquare);
            this.Controls.Add(this.lblsquare);
            this.Controls.Add(this.lblSide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Label lblsquare;
        private System.Windows.Forms.Button btncreatesquare;
        private System.Windows.Forms.TextBox txtsidelength;
    }
}

