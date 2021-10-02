
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
            this.btnthrow = new System.Windows.Forms.Button();
            this.lblthrows = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthrow
            // 
            this.btnthrow.Location = new System.Drawing.Point(154, 165);
            this.btnthrow.Name = "btnthrow";
            this.btnthrow.Size = new System.Drawing.Size(100, 23);
            this.btnthrow.TabIndex = 0;
            this.btnthrow.Text = "Throw";
            this.btnthrow.UseVisualStyleBackColor = true;
            this.btnthrow.Click += new System.EventHandler(this.btnthrow_Click);
            // 
            // lblthrows
            // 
            this.lblthrows.AutoSize = true;
            this.lblthrows.Location = new System.Drawing.Point(32, 44);
            this.lblthrows.Name = "lblthrows";
            this.lblthrows.Size = new System.Drawing.Size(20, 17);
            this.lblthrows.TabIndex = 1;
            this.lblthrows.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 237);
            this.Controls.Add(this.lblthrows);
            this.Controls.Add(this.btnthrow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthrow;
        private System.Windows.Forms.Label lblthrows;
    }
}

