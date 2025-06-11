using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1OBDZ
{
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                //читаємо дані з форми FormAddRecordToTable
                string tb1 = textBox1.Text;
                string tb2 = textBox2.Text;
                string tb3 = textBox3.Text;
                string tb4 = textBox4.Text;
                string tb5 = textBox5.Text;

                string strFileName = h.pathToPhoto;
                FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                int FileSize = (Int32)fs.Length;
                byte[] rawData = new byte[FileSize];
                fs.Read(rawData, 0, FileSize);
                fs.Close();

                //формуємо команду на додавання запису
                string sql = "INSERT INTO weapon " +
                             "(idWeapon, Weapon_Name, Weapon_Calibre, Weapon_Type, Weapon_Estimated_Range, Weapon_Picture) " +
                             "VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @File)";



                MySqlCommand cmd = new MySqlCommand(sql, con);

                //додаємо параметри у колекцію класу Command
                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);

                cmd.Parameters.AddWithValue("@File", rawData);
                con.Open();           //Відкриваємо з'єднання   
                cmd.ExecuteNonQuery(); //Виконуємо команду cmd
                con.Close();          //Закриваємо з'єднання

                MessageBox.Show("Додавання запису пройшло вдало");
            }
            this.Close(); //Закриваємо вікно
        }

        private void AddInfo_Load(object sender, EventArgs e)
        {
            h.pathToPhoto = @"C:\Users\VOlod\Downloads\i_am_like_p.didi.jpg";
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // кнопка вибрати зображення
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Виберіть файл";
            openFileDialog1.Filter = "img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            h.pathToPhoto = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
        }
    }
}
