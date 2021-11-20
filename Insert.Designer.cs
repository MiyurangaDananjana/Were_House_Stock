
namespace Were_House_Stock
{
    partial class Insert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSave_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(10, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item";
            // 
            // txtproduct
            // 
            this.txtproduct.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.txtproduct.Location = new System.Drawing.Point(128, 14);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(230, 27);
            this.txtproduct.TabIndex = 4;
            this.txtproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtproduct_KeyDown);
            // 
            // txtitem
            // 
            this.txtitem.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.txtitem.Location = new System.Drawing.Point(128, 55);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(230, 27);
            this.txtitem.TabIndex = 5;
            this.txtitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtitem_KeyDown);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.txtquantity.Location = new System.Drawing.Point(128, 100);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(230, 27);
            this.txtquantity.TabIndex = 6;
            this.txtquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquantity_KeyDown);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnsave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsave.Location = new System.Drawing.Point(124, 201);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(114, 45);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SlateBlue;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnclear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclear.Location = new System.Drawing.Point(244, 201);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(114, 45);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(215)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtitem);
            this.panel1.Controls.Add(this.txtproduct);
            this.panel1.Location = new System.Drawing.Point(10, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 262);
            this.panel1.TabIndex = 9;
            // 
            // txtSave_Price
            // 
            this.txtSave_Price.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.txtSave_Price.Location = new System.Drawing.Point(55, 116);
            this.txtSave_Price.Name = "txtSave_Price";
            this.txtSave_Price.Size = new System.Drawing.Size(77, 27);
            this.txtSave_Price.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(10, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.txtPrice.Location = new System.Drawing.Point(128, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(230, 27);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-4, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 55);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "New Item";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(392, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSave_Price);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Insert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSave_Price;
    }
}

