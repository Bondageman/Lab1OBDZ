using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace Lab1OBDZ
{
    public partial class LogIn : Form
    {

        public string[,] matrix;
        DataTable dt;
        public LogIn()
        {
            InitializeComponent();
            h.ConStr = "server = 194.44.236.9; database = sqlipz24_1_zvi; user = sqlipz24_1_zvi; password = ipz24_zvi; charset = cp1251;";
            dt = h.myfunDt("SELECT * FROM userName");
            
            int kilkz = dt.Rows.Count;
            matrix = new string[kilkz, 4];

            for (int i = 0; i < kilkz; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("idUserName").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("UserName");
                matrix[i, 2] = dt.Rows[i].Field<int>("Type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("Password");

                cbxUser.Items.Add(matrix[i, 1]);
            }

            cbxUser.Text = matrix[0, 1];

            txtPassword.UseSystemPasswordChar = true;
            cbxUser.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Autorization();
            textBox2.Text = h.EncriptedPassword_MD5(txtPassword.Text);
            
    }
        private void Autorization()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (string.Equals(cbxUser.Text.ToUpper(), matrix[i, 1].ToUpper()))
                {
                    if (string.Equals(txtPassword.Text, matrix[i, 3]))
                    {
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введіть правильний пароль!", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autorization();
            }
             else if (e.KeyCode == Keys.Escape) {
                Application.Exit();

            }
        }

        private void TextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
    static class h
    {
        public static string ConStr { get; set; }

        public static string typeUser { get; set; }

        public static string nameUser { get; set; }
        public static string keyName { get; set; }
        public static string curVa10 { get; set; }

        public static string pathToPhoto { get; set; }

        public static BindingSource bs1 { get; set; }
        public static DataTable myfunDt(string commandString)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(commandString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неможливо з'єднатися з сервером", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return dt;
            }
        }

        public static string EncriptedPassword_MD5(string s)
        {
            if (string.Compare(s, "null", true) == 0)
            {
                return "null";
            }
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
                byte[] byteHach = CSP.ComputeHash(bytes);
                string hash = string.Empty;
                foreach (byte b in byteHach)
                {
                    hash += String.Format("{0:x2}", b);
                }
            return hash;
        }

        }
    }
