
namespace Assignment4
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
            this.EnterPriceLabel = new System.Windows.Forms.Label();
            this.DetermineVATButton = new System.Windows.Forms.Button();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.VATLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceAnswerLabel = new System.Windows.Forms.Label();
            this.VATAnswerLabel = new System.Windows.Forms.Label();
            this.TotalAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterPriceLabel
            // 
            this.EnterPriceLabel.AutoSize = true;
            this.EnterPriceLabel.Location = new System.Drawing.Point(48, 88);
            this.EnterPriceLabel.Name = "EnterPriceLabel";
            this.EnterPriceLabel.Size = new System.Drawing.Size(93, 17);
            this.EnterPriceLabel.TabIndex = 0;
            this.EnterPriceLabel.Text = "Enter a price:";
            // 
            // DetermineVATButton
            // 
            this.DetermineVATButton.Location = new System.Drawing.Point(51, 150);
            this.DetermineVATButton.Name = "DetermineVATButton";
            this.DetermineVATButton.Size = new System.Drawing.Size(311, 28);
            this.DetermineVATButton.TabIndex = 1;
            this.DetermineVATButton.Text = "Determine VAT";
            this.DetermineVATButton.UseVisualStyleBackColor = true;
            this.DetermineVATButton.Click += new System.EventHandler(this.DetermineVATButton_Click);
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(245, 88);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(117, 22);
            this.PriceTextbox.TabIndex = 2;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(48, 217);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 17);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price:";
            // 
            // VATLabel
            // 
            this.VATLabel.AutoSize = true;
            this.VATLabel.Location = new System.Drawing.Point(48, 259);
            this.VATLabel.Name = "VATLabel";
            this.VATLabel.Size = new System.Drawing.Size(39, 17);
            this.VATLabel.TabIndex = 4;
            this.VATLabel.Text = "VAT:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(48, 300);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 17);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total:";
            // 
            // PriceAnswerLabel
            // 
            this.PriceAnswerLabel.AutoSize = true;
            this.PriceAnswerLabel.Location = new System.Drawing.Point(316, 217);
            this.PriceAnswerLabel.Name = "PriceAnswerLabel";
            this.PriceAnswerLabel.Size = new System.Drawing.Size(0, 17);
            this.PriceAnswerLabel.TabIndex = 6;
            // 
            // VATAnswerLabel
            // 
            this.VATAnswerLabel.AutoSize = true;
            this.VATAnswerLabel.Location = new System.Drawing.Point(316, 259);
            this.VATAnswerLabel.Name = "VATAnswerLabel";
            this.VATAnswerLabel.Size = new System.Drawing.Size(0, 17);
            this.VATAnswerLabel.TabIndex = 7;
            // 
            // TotalAnswerLabel
            // 
            this.TotalAnswerLabel.AutoSize = true;
            this.TotalAnswerLabel.Location = new System.Drawing.Point(316, 300);
            this.TotalAnswerLabel.Name = "TotalAnswerLabel";
            this.TotalAnswerLabel.Size = new System.Drawing.Size(0, 17);
            this.TotalAnswerLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 363);
            this.Controls.Add(this.TotalAnswerLabel);
            this.Controls.Add(this.VATAnswerLabel);
            this.Controls.Add(this.PriceAnswerLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.VATLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.DetermineVATButton);
            this.Controls.Add(this.EnterPriceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPriceLabel;
        private System.Windows.Forms.Button DetermineVATButton;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label VATLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PriceAnswerLabel;
        private System.Windows.Forms.Label VATAnswerLabel;
        private System.Windows.Forms.Label TotalAnswerLabel;
    }
}

