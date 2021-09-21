
namespace assignment9
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
            this.lblsport = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lbltobepaid = new System.Windows.Forms.Label();
            this.lblfee = new System.Windows.Forms.Label();
            this.btncalculatefee = new System.Windows.Forms.Button();
            this.rbtnfootball = new System.Windows.Forms.RadioButton();
            this.rbtnhandball = new System.Windows.Forms.RadioButton();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtmembership = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblsport
            // 
            this.lblsport.AutoSize = true;
            this.lblsport.Location = new System.Drawing.Point(25, 27);
            this.lblsport.Name = "lblsport";
            this.lblsport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblsport.Size = new System.Drawing.Size(32, 13);
            this.lblsport.TabIndex = 0;
            this.lblsport.Text = "Sport";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(25, 90);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Age";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(25, 116);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(105, 13);
            this.lblmembership.TabIndex = 2;
            this.lblmembership.Text = "Membership duration";
            // 
            // lbltobepaid
            // 
            this.lbltobepaid.AutoSize = true;
            this.lbltobepaid.Location = new System.Drawing.Point(25, 206);
            this.lbltobepaid.Name = "lbltobepaid";
            this.lbltobepaid.Size = new System.Drawing.Size(75, 13);
            this.lbltobepaid.TabIndex = 3;
            this.lbltobepaid.Text = "Fee to be paid";
            // 
            // lblfee
            // 
            this.lblfee.AutoSize = true;
            this.lblfee.Location = new System.Drawing.Point(210, 206);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(13, 13);
            this.lblfee.TabIndex = 4;
            this.lblfee.Text = "  ";
            // 
            // btncalculatefee
            // 
            this.btncalculatefee.Location = new System.Drawing.Point(28, 146);
            this.btncalculatefee.Name = "btncalculatefee";
            this.btncalculatefee.Size = new System.Drawing.Size(285, 44);
            this.btncalculatefee.TabIndex = 5;
            this.btncalculatefee.Text = "Calculate Fee";
            this.btncalculatefee.UseVisualStyleBackColor = true;
            this.btncalculatefee.Click += new System.EventHandler(this.btncalculatefee_Click);
            // 
            // rbtnfootball
            // 
            this.rbtnfootball.AutoSize = true;
            this.rbtnfootball.Location = new System.Drawing.Point(213, 23);
            this.rbtnfootball.Name = "rbtnfootball";
            this.rbtnfootball.Size = new System.Drawing.Size(62, 17);
            this.rbtnfootball.TabIndex = 6;
            this.rbtnfootball.TabStop = true;
            this.rbtnfootball.Text = "Football";
            this.rbtnfootball.UseVisualStyleBackColor = true;
            this.rbtnfootball.CheckedChanged += new System.EventHandler(this.rbtnfootball_CheckedChanged);
            // 
            // rbtnhandball
            // 
            this.rbtnhandball.AutoSize = true;
            this.rbtnhandball.Location = new System.Drawing.Point(213, 46);
            this.rbtnhandball.Name = "rbtnhandball";
            this.rbtnhandball.Size = new System.Drawing.Size(67, 17);
            this.rbtnhandball.TabIndex = 7;
            this.rbtnhandball.TabStop = true;
            this.rbtnhandball.Text = "Handball";
            this.rbtnhandball.UseVisualStyleBackColor = true;
            this.rbtnhandball.CheckedChanged += new System.EventHandler(this.rbtnhandball_CheckedChanged);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(213, 87);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 8;
            // 
            // txtmembership
            // 
            this.txtmembership.Location = new System.Drawing.Point(213, 113);
            this.txtmembership.Name = "txtmembership";
            this.txtmembership.Size = new System.Drawing.Size(100, 20);
            this.txtmembership.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 239);
            this.Controls.Add(this.txtmembership);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.rbtnhandball);
            this.Controls.Add(this.rbtnfootball);
            this.Controls.Add(this.btncalculatefee);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.lbltobepaid);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblsport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsport;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lbltobepaid;
        private System.Windows.Forms.Label lblfee;
        private System.Windows.Forms.Button btncalculatefee;
        private System.Windows.Forms.RadioButton rbtnfootball;
        private System.Windows.Forms.RadioButton rbtnhandball;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtmembership;
    }
}

