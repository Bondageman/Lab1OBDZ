﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab1OBDZ
{
    public partial class frmKatalog : Form
    {
        string path = Path.GetFullPath(@"..\..\");
        DataTable dt;
        public frmKatalog()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKatalog_Load(object sender, EventArgs e)
        {
            this.Height = 320;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * from weapon");
            dataGridView1.DataSource = h.bs1;
            dataGridView1.RowHeadersVisible = false;
            bindingNavigator1.BindingSource = h.bs1;

            DGWFormat();

            DataTable dtBorder = new DataTable();
            DataTable dtDistinct = new DataTable();
            DataTable dtRange = new DataTable();
            dtBorder = h.myfunDt("SELECT min(Weapon_Calibre), max(Weapon_Calibre) FROM weapon");
            dtDistinct = h.myfunDt("SELECT Weapon_Type from weapon");
            dtRange = h.myfunDt("SELECT Weapon_Estimated_Range from weapon");

            // записуємо межі у відповідні елементи керування
            txtReitFrom.Text = dtBorder.Rows[0][0].ToString();
            txtReitTo.Text = dtBorder.Rows[0][1].ToString();
            // визначаємо перелік можливих значень текстового поля
            cmbAdres.Items.Add("");
            for (int i = 0; i < dtDistinct.Rows.Count; i++)
            {
                cmbAdres.Items.Add(dtDistinct.Rows[i][0].ToString());
            }
            cmbAdres.DropDownStyle = ComboBoxStyle.DropDownList;//заборона редагування comboBox

            // ініціалізуємо comboBox фільтування за статтю
            cmbSex.Items.Add("");
            for (int i = 0; i < dtRange.Rows.Count; i++)
            {
                cmbSex.Items.Add(dtRange.Rows[i][0].ToString());
            }
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;//заборона редагування comboBox

            path += @"\report";

            dt = (DataTable)h.bs1.DataSource;


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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkViolet, 1); 

            gfx.DrawLine(p, 0, 5, 5, 5);

            gfx.DrawLine(p, 35, 5, e.ClipRectangle.Width - 2, 5);

            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);

            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);

            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!btnFilter.Checked)
            {
                this.Height = 600;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 320;
                groupBox1.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            strFilter += "idWeapon > 0 ";
            if (textPIP.Text != "")
                strFilter += " AND Weapon_Name LIKE '" + textPIP.Text + "%'";

            

            if ((txtReitFrom.Text != "") && (txtReitTo.Text != ""))
                strFilter += " AND (Weapon_Calibre >= " + txtReitFrom.Text.ToString().Replace(',', '.') +
                             " AND Weapon_Calibre <= " + txtReitTo.Text.ToString().Replace(',', '.') + ")";
            else if ((txtReitFrom.Text == "") && (txtReitTo.Text != "")) //до заданої межі
                strFilter += " AND (Weapon_Calibre <= " + txtReitTo.Text.ToString().Replace(',', '.') + ")";
            else if ((txtReitFrom.Text != "") && (txtReitTo.Text == "")) //від заданої межі
                strFilter += " AND (Weapon_Calibre >= " + txtReitFrom.Text.ToString().Replace(',', '.') + ")";

            // Фільтр по значенню адреси з comboBox
            if (cmbAdres.Text != "")
                strFilter += " AND (Weapon_Type = '" + cmbAdres.Text + "')";

            if (cmbSex.Text != "")
                strFilter += " AND (Weapon_Estimated_Range = '" + cmbSex.Text + "')";

            MessageBox.Show(strFilter);

            h.bs1.Filter = strFilter;
        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            AddInfo fladd = new AddInfo();
            fladd.ShowDialog();
            h.bs1.DataSource = h.myfunDt("select * from weapon");
            dataGridView1.DataSource = h.bs1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //знаходимо значення ключового поля поточного запису
            h.curVa10 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            DeleteInfo f3 = new DeleteInfo();
            f3.ShowDialog(); //показуємо форму в режимі діалогу

            //оновлюємо джерело даних застосунку клієнта
            h.bs1.DataSource = h.myfunDt("SELECT * FROM weapon");
            dataGridView1.DataSource = h.bs1; //оновлюємо DataGridView
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            h.keyName = dataGridView1.Columns[0].Name;
            h.curVa10 = dataGridView1.CurrentRow.Index.ToString();

            int curColInx = dataGridView1.CurrentCell.ColumnIndex;
            string curColName = dataGridView1.Columns[curColInx].Name;
            string newCurCellVal = e.Value.ToString();

            if (curColName == "Weapon_Name" || curColName == "Weapon_Calibre" || curColName == "Weapon_Type" || curColName == "Weapon_Estimated_Range")
            {
                newCurCellVal = "'" + newCurCellVal + "'"; // поле текстовое - берется в лапки
            }

            // у дійсному числі кома (так у dataGridView) замінюється на крапку (як в MySQL)
            //if (curColName == "Size")
            //{
            //    newCurCellVal = newCurCellVal.Replace(',', '.');
            //}

            string sqlStr = "UPDATE weapon SET " + curColName + " = " + newCurCellVal + " WHERE " + h.keyName + " = " + h.curVa10;
            //MessageBox.Show(sqlStr);

            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // знаходимо значення ключового поля поточного запису
            h.curVa10 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            ChangeForm f4 = new ChangeForm();
            f4.ShowDialog(); // показуємо форму у режимі діалогу

            // оновлюємо джерело даних застосунку клієнта
            h.bs1.DataSource = h.myfunDt("SELECT * FROM weapon");
            dataGridView1.DataSource = h.bs1; // оновлюємо DataGridView
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rIndx = dataGridView1.CurrentCell.RowIndex;

            // Отримуємо значення з клітинки як object для безпечної перевірк
            if (dataGridView1.Rows[rIndx].Cells[5].Value.ToString().Length > 0)
            {
                byte[] a = (byte[])dataGridView1.Rows[rIndx].Cells[5].Value;
                MemoryStream memImage = new MemoryStream(a);
                pictureBox1.Image = Image.FromStream(memImage);
                memImage.Close();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\VOlod\Downloads\i_am_like_p.didi.jpg");
            }
        }
    }
}

