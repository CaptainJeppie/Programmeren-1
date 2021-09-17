
namespace Assignment8
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
            this.lblTshirtprice = new System.Windows.Forms.Label();
            this.lblJeansprice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTtlprice = new System.Windows.Forms.Label();
            this.lblAnswerdate = new System.Windows.Forms.Label();
            this.lblAnswerprice = new System.Windows.Forms.Label();
            this.lblAnswervat = new System.Windows.Forms.Label();
            this.lblAnswertotalprice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNmbrshirts = new System.Windows.Forms.TextBox();
            this.txtNmbrjeans = new System.Windows.Forms.TextBox();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTshirtprice
            // 
            this.lblTshirtprice.AutoSize = true;
            this.lblTshirtprice.Location = new System.Drawing.Point(52, 43);
            this.lblTshirtprice.Name = "lblTshirtprice";
            this.lblTshirtprice.Size = new System.Drawing.Size(190, 17);
            this.lblTshirtprice.TabIndex = 0;
            this.lblTshirtprice.Text = "Number of T-shirts ( x 30.00)";
            this.lblTshirtprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTshirtprice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJeansprice
            // 
            this.lblJeansprice.AutoSize = true;
            this.lblJeansprice.Location = new System.Drawing.Point(52, 96);
            this.lblJeansprice.Name = "lblJeansprice";
            this.lblJeansprice.Size = new System.Drawing.Size(188, 17);
            this.lblJeansprice.TabIndex = 1;
            this.lblJeansprice.Text = "Number of Jeans ( x 100.00)";
            this.lblJeansprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJeansprice.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(52, 247);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(52, 282);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(52, 318);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(39, 17);
            this.lblVAT.TabIndex = 4;
            this.lblVAT.Text = "VAT:";
            // 
            // lblTtlprice
            // 
            this.lblTtlprice.AutoSize = true;
            this.lblTtlprice.Location = new System.Drawing.Point(52, 351);
            this.lblTtlprice.Name = "lblTtlprice";
            this.lblTtlprice.Size = new System.Drawing.Size(79, 17);
            this.lblTtlprice.TabIndex = 5;
            this.lblTtlprice.Text = "Total price:";
            // 
            // lblAnswerdate
            // 
            this.lblAnswerdate.Location = new System.Drawing.Point(171, 247);
            this.lblAnswerdate.Name = "lblAnswerdate";
            this.lblAnswerdate.Size = new System.Drawing.Size(198, 17);
            this.lblAnswerdate.TabIndex = 6;
            this.lblAnswerdate.Text = "    ";
            this.lblAnswerdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswerprice
            // 
            this.lblAnswerprice.Location = new System.Drawing.Point(174, 282);
            this.lblAnswerprice.Name = "lblAnswerprice";
            this.lblAnswerprice.Size = new System.Drawing.Size(195, 17);
            this.lblAnswerprice.TabIndex = 7;
            this.lblAnswerprice.Text = "   ";
            this.lblAnswerprice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswervat
            // 
            this.lblAnswervat.Location = new System.Drawing.Point(177, 318);
            this.lblAnswervat.Name = "lblAnswervat";
            this.lblAnswervat.Size = new System.Drawing.Size(192, 17);
            this.lblAnswervat.TabIndex = 8;
            this.lblAnswervat.Text = "   ";
            this.lblAnswervat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswertotalprice
            // 
            this.lblAnswertotalprice.Location = new System.Drawing.Point(172, 351);
            this.lblAnswertotalprice.Name = "lblAnswertotalprice";
            this.lblAnswertotalprice.Size = new System.Drawing.Size(197, 17);
            this.lblAnswertotalprice.TabIndex = 9;
            this.lblAnswertotalprice.Text = "   ";
            this.lblAnswertotalprice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(55, 145);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(322, 60);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNmbrshirts
            // 
            this.txtNmbrshirts.Location = new System.Drawing.Point(277, 38);
            this.txtNmbrshirts.Name = "txtNmbrshirts";
            this.txtNmbrshirts.Size = new System.Drawing.Size(100, 22);
            this.txtNmbrshirts.TabIndex = 11;
            // 
            // txtNmbrjeans
            // 
            this.txtNmbrjeans.Location = new System.Drawing.Point(277, 93);
            this.txtNmbrjeans.Name = "txtNmbrjeans";
            this.txtNmbrjeans.Size = new System.Drawing.Size(100, 22);
            this.txtNmbrjeans.TabIndex = 12;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(52, 219);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(52, 17);
            this.lblInvoice.TabIndex = 13;
            this.lblInvoice.Text = "Invoice";
            this.lblInvoice.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 394);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.txtNmbrjeans);
            this.Controls.Add(this.txtNmbrshirts);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswertotalprice);
            this.Controls.Add(this.lblAnswervat);
            this.Controls.Add(this.lblAnswerprice);
            this.Controls.Add(this.lblAnswerdate);
            this.Controls.Add(this.lblTtlprice);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblJeansprice);
            this.Controls.Add(this.lblTshirtprice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTshirtprice;
        private System.Windows.Forms.Label lblJeansprice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTtlprice;
        private System.Windows.Forms.Label lblAnswerdate;
        private System.Windows.Forms.Label lblAnswerprice;
        private System.Windows.Forms.Label lblAnswervat;
        private System.Windows.Forms.Label lblAnswertotalprice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNmbrshirts;
        private System.Windows.Forms.TextBox txtNmbrjeans;
        private System.Windows.Forms.Label lblInvoice;
    }
}

