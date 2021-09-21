
namespace assignment10
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
            this.btncalculateprice = new System.Windows.Forms.Button();
            this.lblage = new System.Windows.Forms.Label();
            this.lblpriceticket = new System.Windows.Forms.Label();
            this.lblticketprice = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalculateprice
            // 
            this.btncalculateprice.Location = new System.Drawing.Point(24, 60);
            this.btncalculateprice.Name = "btncalculateprice";
            this.btncalculateprice.Size = new System.Drawing.Size(247, 33);
            this.btncalculateprice.TabIndex = 0;
            this.btncalculateprice.Text = "Calculate Price";
            this.btncalculateprice.UseVisualStyleBackColor = true;
            this.btncalculateprice.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(21, 22);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Age";
            // 
            // lblpriceticket
            // 
            this.lblpriceticket.AutoSize = true;
            this.lblpriceticket.Location = new System.Drawing.Point(21, 118);
            this.lblpriceticket.Name = "lblpriceticket";
            this.lblpriceticket.Size = new System.Drawing.Size(60, 13);
            this.lblpriceticket.TabIndex = 2;
            this.lblpriceticket.Text = "Price ticket";
            // 
            // lblticketprice
            // 
            this.lblticketprice.AutoSize = true;
            this.lblticketprice.Location = new System.Drawing.Point(168, 118);
            this.lblticketprice.Name = "lblticketprice";
            this.lblticketprice.Size = new System.Drawing.Size(13, 13);
            this.lblticketprice.TabIndex = 3;
            this.lblticketprice.Text = "  ";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(171, 19);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 151);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblticketprice);
            this.Controls.Add(this.lblpriceticket);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.btncalculateprice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculateprice;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblpriceticket;
        private System.Windows.Forms.Label lblticketprice;
        private System.Windows.Forms.TextBox txtage;
    }
}

