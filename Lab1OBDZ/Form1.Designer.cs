namespace Lab1OBDZ
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableOsoba = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableKatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableFormuliar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціБДToolStripMenuItem,
            this.адмініструванняToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.проToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціБДToolStripMenuItem
            // 
            this.таблиціБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTableOsoba,
            this.OpenTableKatalog,
            this.OpenTableFormuliar});
            this.таблиціБДToolStripMenuItem.Name = "таблиціБДToolStripMenuItem";
            this.таблиціБДToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.таблиціБДToolStripMenuItem.Text = "Таблиці БД";
            this.таблиціБДToolStripMenuItem.Click += new System.EventHandler(this.таблиціБДToolStripMenuItem_Click);
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // проToolStripMenuItem
            // 
            this.проToolStripMenuItem.Name = "проToolStripMenuItem";
            this.проToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.проToolStripMenuItem.Text = "Про програму";
            this.проToolStripMenuItem.Click += new System.EventHandler(this.проToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // OpenTableOsoba
            // 
            this.OpenTableOsoba.Name = "OpenTableOsoba";
            this.OpenTableOsoba.Size = new System.Drawing.Size(224, 26);
            this.OpenTableOsoba.Text = "Читачі";
            this.OpenTableOsoba.Click += new System.EventHandler(this.OpenTableOsoba_Click);
            // 
            // OpenTableKatalog
            // 
            this.OpenTableKatalog.Name = "OpenTableKatalog";
            this.OpenTableKatalog.Size = new System.Drawing.Size(224, 26);
            this.OpenTableKatalog.Text = "Каталог";
            this.OpenTableKatalog.Click += new System.EventHandler(this.OpenTableKatalog_Click);
            // 
            // OpenTableFormuliar
            // 
            this.OpenTableFormuliar.Name = "OpenTableFormuliar";
            this.OpenTableFormuliar.Size = new System.Drawing.Size(224, 26);
            this.OpenTableFormuliar.Text = "Формуляр";
            this.OpenTableFormuliar.Click += new System.EventHandler(this.OpenTableFormuliar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTableOsoba;
        private System.Windows.Forms.ToolStripMenuItem OpenTableKatalog;
        private System.Windows.Forms.ToolStripMenuItem OpenTableFormuliar;
    }
}

