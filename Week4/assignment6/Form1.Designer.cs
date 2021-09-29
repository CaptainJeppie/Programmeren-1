
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
            this.btncalculatecapital = new System.Windows.Forms.Button();
            this.lblStartamount = new System.Windows.Forms.Label();
            this.lblFinalcapital = new System.Windows.Forms.Label();
            this.lblendprice = new System.Windows.Forms.Label();
            this.txtstartamount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalculatecapital
            // 
            this.btncalculatecapital.Location = new System.Drawing.Point(43, 80);
            this.btncalculatecapital.Name = "btncalculatecapital";
            this.btncalculatecapital.Size = new System.Drawing.Size(195, 22);
            this.btncalculatecapital.TabIndex = 0;
            this.btncalculatecapital.Text = "Calculate final capital";
            this.btncalculatecapital.UseVisualStyleBackColor = true;
            this.btncalculatecapital.Click += new System.EventHandler(this.btncalculatecapital_Click);
            // 
            // lblStartamount
            // 
            this.lblStartamount.AutoSize = true;
            this.lblStartamount.Location = new System.Drawing.Point(40, 46);
            this.lblStartamount.Name = "lblStartamount";
            this.lblStartamount.Size = new System.Drawing.Size(67, 13);
            this.lblStartamount.TabIndex = 1;
            this.lblStartamount.Text = "Start amount";
            // 
            // lblFinalcapital
            // 
            this.lblFinalcapital.AutoSize = true;
            this.lblFinalcapital.Location = new System.Drawing.Point(40, 141);
            this.lblFinalcapital.Name = "lblFinalcapital";
            this.lblFinalcapital.Size = new System.Drawing.Size(63, 13);
            this.lblFinalcapital.TabIndex = 2;
            this.lblFinalcapital.Text = "Final capital";
            // 
            // lblendprice
            // 
            this.lblendprice.Location = new System.Drawing.Point(138, 136);
            this.lblendprice.Name = "lblendprice";
            this.lblendprice.Size = new System.Drawing.Size(100, 23);
            this.lblendprice.TabIndex = 3;
            this.lblendprice.Text = "   ";
            this.lblendprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtstartamount
            // 
            this.txtstartamount.Location = new System.Drawing.Point(138, 43);
            this.txtstartamount.Name = "txtstartamount";
            this.txtstartamount.Size = new System.Drawing.Size(100, 20);
            this.txtstartamount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.txtstartamount);
            this.Controls.Add(this.lblendprice);
            this.Controls.Add(this.lblFinalcapital);
            this.Controls.Add(this.lblStartamount);
            this.Controls.Add(this.btncalculatecapital);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculatecapital;
        private System.Windows.Forms.Label lblStartamount;
        private System.Windows.Forms.Label lblFinalcapital;
        private System.Windows.Forms.Label lblendprice;
        private System.Windows.Forms.TextBox txtstartamount;
    }
}

