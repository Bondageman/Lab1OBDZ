namespace Lab1OBDZ
{
    partial class Calculator
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbxAct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.txtCh2 = new System.Windows.Forms.TextBox();
            this.txtCh1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(184, 126);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Обчислити";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbxAct
            // 
            this.cmbxAct.FormattingEnabled = true;
            this.cmbxAct.Location = new System.Drawing.Point(149, 53);
            this.cmbxAct.Name = "cmbxAct";
            this.cmbxAct.Size = new System.Drawing.Size(121, 24);
            this.cmbxAct.TabIndex = 2;
            this.cmbxAct.SelectedIndexChanged += new System.EventHandler(this.cmbxAct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Виберіть дію";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Число 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(404, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Результат";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(437, 55);
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(100, 22);
            this.txtRez.TabIndex = 8;
            // 
            // txtCh2
            // 
            this.txtCh2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCh2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCh2.Location = new System.Drawing.Point(298, 55);
            this.txtCh2.Name = "txtCh2";
            this.txtCh2.Size = new System.Drawing.Size(100, 15);
            this.txtCh2.TabIndex = 9;
            // 
            // txtCh1
            // 
            this.txtCh1.Location = new System.Drawing.Point(22, 53);
            this.txtCh1.Name = "txtCh1";
            this.txtCh1.Size = new System.Drawing.Size(100, 22);
            this.txtCh1.TabIndex = 10;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 197);
            this.Controls.Add(this.txtCh1);
            this.Controls.Add(this.txtCh2);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxAct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Name = "Calculator";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbxAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.TextBox txtCh2;
        private System.Windows.Forms.TextBox txtCh1;
    }
}