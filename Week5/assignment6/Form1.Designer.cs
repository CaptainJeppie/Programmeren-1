
namespace assignment6
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
            this.lblContentbefore = new System.Windows.Forms.Label();
            this.lbltablebefore = new System.Windows.Forms.Label();
            this.lblContentafter = new System.Windows.Forms.Label();
            this.lbltableafter = new System.Windows.Forms.Label();
            this.lblComparison = new System.Windows.Forms.Label();
            this.btncompare = new System.Windows.Forms.Button();
            this.txtcomparisonnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContentbefore
            // 
            this.lblContentbefore.AutoSize = true;
            this.lblContentbefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentbefore.Location = new System.Drawing.Point(12, 29);
            this.lblContentbefore.Name = "lblContentbefore";
            this.lblContentbefore.Size = new System.Drawing.Size(169, 17);
            this.lblContentbefore.TabIndex = 0;
            this.lblContentbefore.Text = "Content table (before)";
            // 
            // lbltablebefore
            // 
            this.lbltablebefore.AutoSize = true;
            this.lbltablebefore.Location = new System.Drawing.Point(12, 67);
            this.lbltablebefore.Name = "lbltablebefore";
            this.lbltablebefore.Size = new System.Drawing.Size(20, 17);
            this.lbltablebefore.TabIndex = 1;
            this.lbltablebefore.Text = "   ";
            // 
            // lblContentafter
            // 
            this.lblContentafter.AutoSize = true;
            this.lblContentafter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentafter.Location = new System.Drawing.Point(197, 29);
            this.lblContentafter.Name = "lblContentafter";
            this.lblContentafter.Size = new System.Drawing.Size(156, 17);
            this.lblContentafter.TabIndex = 2;
            this.lblContentafter.Text = "Content table (after)";
            // 
            // lbltableafter
            // 
            this.lbltableafter.AutoSize = true;
            this.lbltableafter.Location = new System.Drawing.Point(197, 67);
            this.lbltableafter.Name = "lbltableafter";
            this.lbltableafter.Size = new System.Drawing.Size(20, 17);
            this.lbltableafter.TabIndex = 3;
            this.lbltableafter.Text = "   ";
            // 
            // lblComparison
            // 
            this.lblComparison.AutoSize = true;
            this.lblComparison.Location = new System.Drawing.Point(12, 419);
            this.lblComparison.Name = "lblComparison";
            this.lblComparison.Size = new System.Drawing.Size(135, 17);
            this.lblComparison.TabIndex = 4;
            this.lblComparison.Text = "Comparison number";
            // 
            // btncompare
            // 
            this.btncompare.Location = new System.Drawing.Point(280, 416);
            this.btncompare.Name = "btncompare";
            this.btncompare.Size = new System.Drawing.Size(90, 23);
            this.btncompare.TabIndex = 5;
            this.btncompare.Text = "Compare";
            this.btncompare.UseVisualStyleBackColor = true;
            this.btncompare.Click += new System.EventHandler(this.btncompare_Click);
            // 
            // txtcomparisonnumber
            // 
            this.txtcomparisonnumber.Location = new System.Drawing.Point(164, 416);
            this.txtcomparisonnumber.Name = "txtcomparisonnumber";
            this.txtcomparisonnumber.Size = new System.Drawing.Size(100, 22);
            this.txtcomparisonnumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.txtcomparisonnumber);
            this.Controls.Add(this.btncompare);
            this.Controls.Add(this.lblComparison);
            this.Controls.Add(this.lbltableafter);
            this.Controls.Add(this.lblContentafter);
            this.Controls.Add(this.lbltablebefore);
            this.Controls.Add(this.lblContentbefore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContentbefore;
        private System.Windows.Forms.Label lbltablebefore;
        private System.Windows.Forms.Label lblContentafter;
        private System.Windows.Forms.Label lbltableafter;
        private System.Windows.Forms.Label lblComparison;
        private System.Windows.Forms.Button btncompare;
        private System.Windows.Forms.TextBox txtcomparisonnumber;
    }
}

