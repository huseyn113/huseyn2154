namespace WindowsFormsApp1shop12
{
    partial class dashboard
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
            this.txtwel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.ComboBox();
            this.txtpra = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcount = new System.Windows.Forms.NumericUpDown();
            this.lblprice = new System.Windows.Forms.Label();
            this.btnbuy = new System.Windows.Forms.Button();
            this.txtgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtwel
            // 
            this.txtwel.AutoSize = true;
            this.txtwel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtwel.Location = new System.Drawing.Point(504, 9);
            this.txtwel.Name = "txtwel";
            this.txtwel.Size = new System.Drawing.Size(67, 30);
            this.txtwel.TabIndex = 0;
            this.txtwel.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "category";
            // 
            // txtcat
            // 
            this.txtcat.FormattingEnabled = true;
            this.txtcat.Location = new System.Drawing.Point(17, 48);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(121, 21);
            this.txtcat.TabIndex = 2;
            this.txtcat.SelectedIndexChanged += new System.EventHandler(this.txtcat_SelectedIndexChanged);
            // 
            // txtpra
            // 
            this.txtpra.FormattingEnabled = true;
            this.txtpra.Location = new System.Drawing.Point(17, 138);
            this.txtpra.Name = "txtpra";
            this.txtpra.Size = new System.Drawing.Size(121, 21);
            this.txtpra.TabIndex = 4;
            this.txtpra.SelectedIndexChanged += new System.EventHandler(this.txtpra_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "praduct";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "count";
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(28, 230);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(120, 20);
            this.txtcount.TabIndex = 6;
            this.txtcount.ValueChanged += new System.EventHandler(this.txtcount_ValueChanged);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblprice.Location = new System.Drawing.Point(31, 283);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(59, 25);
            this.lblprice.TabIndex = 7;
            this.lblprice.Text = "price";
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(28, 322);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(120, 40);
            this.btnbuy.TabIndex = 8;
            this.btnbuy.Text = "buy";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // txtgrid
            // 
            this.txtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtgrid.Location = new System.Drawing.Point(314, 62);
            this.txtgrid.Name = "txtgrid";
            this.txtgrid.Size = new System.Drawing.Size(474, 462);
            this.txtgrid.TabIndex = 9;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.txtgrid);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtwel);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtwel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtcat;
        private System.Windows.Forms.ComboBox txtpra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtcount;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.DataGridView txtgrid;
    }
}