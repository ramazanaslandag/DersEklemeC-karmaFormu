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
    public partial class YeniEgitmenFormu : Form
    {
        public YeniEgitmenFormu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=.\sqlexpress; database=wn11; integrated security=true");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert Teachers values(@name)", con);
//murat');
            kaydet.Parameters.AddWithValue("@name", txtName.Text);//kısa yoldan parametre ekleme.
            con.Open();
            kaydet.ExecuteNonQuery();
            con.Close();
            txtName.Clear();
            txtName.Focus();
        }
    }
}
