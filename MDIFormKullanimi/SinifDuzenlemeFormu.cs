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
    public partial class SinifDuzenlemeFormu : Form
    {
        public SinifDuzenlemeFormu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server=.\sqlexpress; database=wn11; integrated security=true");
        private void SinifDuzenlemeFormu_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select ClassID, Room from Classes", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            cbClass.DisplayMember = "Room";
            cbClass.ValueMember = "ClassID";
            cbClass.DataSource = dt;

            grpClass.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand select = new SqlCommand("select * from Classes where ClassID=@id", con);
            select.Parameters.AddWithValue("@id", cbClass.SelectedValue);
            con.Open();
            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr["Room"].ToString();
                nud.Value = decimal.Parse(dr["Capacity"].ToString());
            }
            con.Close();
            grpClass.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                SqlCommand update = new SqlCommand("update Classes set Room=@room, Capacity=@caps where ClassID=@id", con);

                update.Parameters.AddWithValue("@room", txtName.Text);
                update.Parameters.AddWithValue("@caps", nud.Value);
                update.Parameters.AddWithValue("@id", cbClass.SelectedValue);

                con.Open();
                update.ExecuteNonQuery();

                con.Close();

                SinifDuzenlemeFormu_Load(sender, e); 
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
