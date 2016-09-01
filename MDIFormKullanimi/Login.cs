using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormKullanimi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=.\sqlexpress; database=net11db; integrated security=true");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text, pass = txtPass.Text;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {
                SqlCommand komut = new SqlCommand(string.Format("select COUNT(*) from Users where UserName='{0}' and Password='{1}'", user, pass), con);
                con.Open();
                //gelecek olan veri scalar bir veridir bu nedenler ExecuteScalar() ile çalıştırılmalı
                int kullanici = (int)komut.ExecuteScalar(); //gelecek olan hücre sorguya bağlı olduğundan geri dönüş object türünde (ilk hücre sayısal, sözel, mantıksal, tarih türünde olabilir)
                con.Close();
                if (kullanici != 0)
                {
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                    Hata();
            }
            else
                Hata();

        }
        void Hata()
        {
            MessageBox.Show("Kullanıcı adı veya şifre hatalı!..");
        }
    }
}
