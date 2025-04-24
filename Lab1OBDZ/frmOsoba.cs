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
    public partial class frmOsoba : Form
    {
        public frmOsoba()
        {
            InitializeComponent();
        }

        private void frmOsoba_Load(object sender, EventArgs e)
        {
            this.Height = 320;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * from userName");
            dataGridView1.DataSource = h.bs1;
            dataGridView1.RowHeadersVisible = false;
            bindingNavigator1.BindingSource = h.bs1;

            DGWFormat();
        }
        void DGWFormat()
        {
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[0].HeaderText = "N";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                label1.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                label1.Visible = false;
                txtFind.Visible = false;
                txtFind.Text = "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        private void txtFind_Leave(object sender, EventArgs e)
        {
            btnFind.Checked = false;
            label1.Visible = false;

            txtFind.Visible = false;
            txtFind.Text = "";

            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1.Rows[i].Selected = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;

            Pen p = new Pen(Color.DarkViolet, 1); // колір і товщина рамки
            gfx.DrawLine(p, 8, 5, 5, 5); // верхня горизонтальна лінія до Теxt

            gfx.DrawLine(p, 35, 5, e.ClipRectangle.Width - 2, 5); // верхня горизонтальна лінія після Text
            gfx.DrawLine(p, 6, 5, 6, e.ClipRectangle.Height - 2); // ліва вертикаль

            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2); // права вертикаль
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 6, e.ClipRectangle.Height - 2); // низ
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (btnFilter.Checked)
            {
                this.Height = 450;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 320;
                groupBox1.Visible = false;
            }
        }
    }
}

