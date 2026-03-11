namespace LinearAlgebraGUI
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxExpense = new System.Windows.Forms.TextBox();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(395, 86);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(94, 25);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(277, 63);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(112, 20);
            this.textBoxAmount.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(277, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 199);
            this.listBox1.TabIndex = 2;
            // 
            // textBoxExpense
            // 
            this.textBoxExpense.Location = new System.Drawing.Point(277, 115);
            this.textBoxExpense.Name = "textBoxExpense";
            this.textBoxExpense.Size = new System.Drawing.Size(112, 20);
            this.textBoxExpense.TabIndex = 3;
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Location = new System.Drawing.Point(277, 89);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(112, 20);
            this.textBoxSalePrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount Sold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unit Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expense:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(395, 114);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSalePrice);
            this.Controls.Add(this.textBoxExpense);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxExpense;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
    }
}

