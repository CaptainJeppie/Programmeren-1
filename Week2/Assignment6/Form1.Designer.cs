
namespace Assignment6
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
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.btnConverttime = new System.Windows.Forms.Button();
            this.lblhms = new System.Windows.Forms.Label();
            this.lblAnswerhms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(61, 15);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(67, 17);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "Seconds:";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(164, 12);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(100, 22);
            this.txtSeconds.TabIndex = 1;
            // 
            // btnConverttime
            // 
            this.btnConverttime.Location = new System.Drawing.Point(64, 63);
            this.btnConverttime.Name = "btnConverttime";
            this.btnConverttime.Size = new System.Drawing.Size(200, 23);
            this.btnConverttime.TabIndex = 2;
            this.btnConverttime.Text = "Calculate Time";
            this.btnConverttime.UseVisualStyleBackColor = true;
            this.btnConverttime.Click += new System.EventHandler(this.btnConverttime_Click);
            // 
            // lblhms
            // 
            this.lblhms.AutoSize = true;
            this.lblhms.Location = new System.Drawing.Point(61, 114);
            this.lblhms.Name = "lblhms";
            this.lblhms.Size = new System.Drawing.Size(158, 17);
            this.lblhms.TabIndex = 3;
            this.lblhms.Text = "Hours:Minutes:Seconds";
            // 
            // lblAnswerhms
            // 
            this.lblAnswerhms.AutoSize = true;
            this.lblAnswerhms.Location = new System.Drawing.Point(61, 151);
            this.lblAnswerhms.Name = "lblAnswerhms";
            this.lblAnswerhms.Size = new System.Drawing.Size(12, 17);
            this.lblAnswerhms.TabIndex = 4;
            this.lblAnswerhms.Text = " ";
            this.lblAnswerhms.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 213);
            this.Controls.Add(this.lblAnswerhms);
            this.Controls.Add(this.lblhms);
            this.Controls.Add(this.btnConverttime);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.lblSeconds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Button btnConverttime;
        private System.Windows.Forms.Label lblhms;
        private System.Windows.Forms.Label lblAnswerhms;
    }
}

