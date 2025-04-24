using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1OBDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.ShowDialog();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Form(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void таблиціБДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenTableOsoba_Click(object sender, EventArgs e)
        {
            frmOsoba f1 = new frmOsoba();
            f1.ShowDialog();
        }

        private void OpenTableKatalog_Click(object sender, EventArgs e)
        {
            frmKatalog f1 = new frmKatalog();
            f1.ShowDialog();
        }

        private void OpenTableFormuliar_Click(object sender, EventArgs e)
        {
            frmFormuliar f1 = new frmFormuliar();
            f1.ShowDialog();
        }
    }
}
