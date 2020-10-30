namespace WindowsFormsApp1shop12
{
    partial class loginform
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtche = new System.Windows.Forms.CheckBox();
            this.btnlo = new System.Windows.Forms.Button();
            this.lblerror1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(323, 196);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(142, 20);
            this.txtpass.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(319, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(323, 96);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(142, 20);
            this.txtemail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(319, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // txtche
            // 
            this.txtche.AutoSize = true;
            this.txtche.Location = new System.Drawing.Point(323, 241);
            this.txtche.Name = "txtche";
            this.txtche.Size = new System.Drawing.Size(72, 17);
            this.txtche.TabIndex = 10;
            this.txtche.Text = "remember";
            this.txtche.UseVisualStyleBackColor = true;
            // 
            // btnlo
            // 
            this.btnlo.Location = new System.Drawing.Point(323, 344);
            this.btnlo.Name = "btnlo";
            this.btnlo.Size = new System.Drawing.Size(142, 35);
            this.btnlo.TabIndex = 11;
            this.btnlo.Text = "login";
            this.btnlo.UseVisualStyleBackColor = true;
            this.btnlo.Click += new System.EventHandler(this.btnlo_Click);
            // 
            // lblerror1
            // 
            this.lblerror1.AutoSize = true;
            this.lblerror1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblerror1.Location = new System.Drawing.Point(319, 298);
            this.lblerror1.Name = "lblerror1";
            this.lblerror1.Size = new System.Drawing.Size(67, 20);
            this.lblerror1.TabIndex = 12;
            this.lblerror1.Text = "warning";
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblerror1);
            this.Controls.Add(this.btnlo);
            this.Controls.Add(this.txtche);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Name = "loginform";
            this.Text = "loginform";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox txtche;
        private System.Windows.Forms.Button btnlo;
        private System.Windows.Forms.Label lblerror1;
    }
}