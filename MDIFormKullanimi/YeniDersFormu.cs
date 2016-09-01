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
    public partial class YeniDersFormu : Form
    {
        public YeniDersFormu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=.\sqlexpress; database=wn11; integrated security=true");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int hour, credit;
            int.TryParse(txtCredit.Text, out credit);
            int.TryParse(txtHour.Text, out hour);
            char[] dizi = { ' ', '-' };
            string subject = txtName.Text.Trim(dizi);
            //trim - trimleft-trimrigth olarak çalışır ve bir string içindeki istenmeyen karakterleri elemeye yarar.
            if (!string.IsNullOrEmpty(subject) && hour!=0)
            {
                DataTable dtLessons = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("select Subject from Lessons", con);
                adp.Fill(dtLessons);

                bool var = false;//ders adı varsa true ya çekilir
                foreach (DataRow satir in dtLessons.Rows)
                {
                    if (satir["Subject"].ToString() == subject)
                    {
                        var = true;
                        break;
                    }
                }

                if (!var)//hala false değer taşıyorsa
                {
                    SqlCommand kaydet = new SqlCommand(string.Format("insert Lessons values('{0}',{1},{2})", subject.ToUpper(), hour, credit), con);
                    con.Open();
                    kaydet.ExecuteNonQuery();
                    con.Close();

                    txtName.Clear();
                    txtHour.Clear();
                    txtCredit.Clear();
                    txtName.Focus();//imleci txtname e gönder
                }
                else
                    MessageBox.Show("Daha önce kaydedilmiş!..");
            }
            else
                MessageBox.Show("Uygun bir ders adı girişi yapılmalı.");
        }
    }
}
