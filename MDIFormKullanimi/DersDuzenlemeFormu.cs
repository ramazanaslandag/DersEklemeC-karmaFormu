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
    public partial class DersDuzenlemeFormu : Form
    {
        public DersDuzenlemeFormu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=.\sqlexpress; database=wn11; integrated security=true");
        
        private void DersDuzenlemeFormu_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select LessonID, Subject from Lessons", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            cbDers.DisplayMember = "Subject";
            cbDers.ValueMember = "LessonID";
            cbDers.DataSource = dt;

            grpClass.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand select = new SqlCommand("select * from lessons where LessonID=@id", con);
            select.Parameters.AddWithValue("@id", cbDers.SelectedValue);
            con.Open();
            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr["Subject"].ToString();
                txtHour.Text = dr["Hour"].ToString();
                txtCredit.Text = dr["Credit"].ToString();
            }
            con.Close();
            grpClass.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtHour.Text) && !string.IsNullOrEmpty(txtCredit.Text))
            {
                SqlCommand update = new SqlCommand("update Lessons set Subject=@name, Hour=@hour, Credit=@credit where LessonID=@id", con);//bağzı bilgiler değişir ya da değişmez
                update.Parameters.AddWithValue("@name", txtName.Text);
                update.Parameters.AddWithValue("@hour", txtHour.Text);
                update.Parameters.AddWithValue("@credit", txtCredit.Text);
                update.Parameters.AddWithValue("@id", cbDers.SelectedValue);
                con.Open();
                update.ExecuteNonQuery();
                con.Close();
                DersDuzenlemeFormu_Load(sender, e);//ders update olduktan sonra combobox da yeni bilgiler yer alsın diye load u tekrar çağırdık.
                
            }
            else
                MessageBox.Show("Tüm alanları doldurun!..");
        }
    }
}
