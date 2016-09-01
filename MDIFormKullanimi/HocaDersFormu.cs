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
    public partial class HocaDersFormu : Form
    {
        public HocaDersFormu()
        {
            InitializeComponent();
        }

        private void HocaDersFormu_Load(object sender, EventArgs e)
        {
            EgitmenGetir();
        }
        SqlConnection con = new SqlConnection(@"server=.\sqlexpress; database=wn11; integrated security=true");
        void EgitmenGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from teachers", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            cbEgitmen.DisplayMember = "Name";
            cbEgitmen.ValueMember = "TeacherID";
            cbEgitmen.DataSource = dt;
        }

        private void cbEgitmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Lessons where LessonID not in (select LessonID from TeachersLessons where TeacherId=@id)", con);

            adp.SelectCommand.Parameters.AddWithValue("@id", cbEgitmen.SelectedValue);
            dtDers = new DataTable();
            adp.Fill(dtDers);
            lbDersler.DisplayMember = "Subject";
            lbDersler.ValueMember = "LessonID";
            lbDersler.DataSource = dtDers;
        }
        DataTable dtDers = new DataTable();
        private void btnYaz_Click(object sender, EventArgs e)
        {
            string egitmenID = cbEgitmen.SelectedValue.ToString();
            ListBox.SelectedIndexCollection secilenler = lbDersler.SelectedIndices;//secilenler içinde hangi indexlerin işaretlendiğini buluruz
            SqlCommand kaydet = new SqlCommand("insert TeachersLessons values(@egitmenID, @dersID)", con);
            for (int i = 0; i < secilenler.Count; i++)
            {
                kaydet.Parameters.Clear();
                kaydet.Parameters.AddWithValue("@egitmenID", egitmenID);
                kaydet.Parameters.AddWithValue("@dersID", dtDers.Rows[secilenler[i]]["LessonID"]);//ders listesinde tm dersler görüntülenmeyebilir (daha önceden alındığı için) bu nedenle indexleri 0-1-2-3 vs olarak kabul etsek bile dersId leri 2-7-11-12-28 vs şeklinde gelebilir
                con.Open();
                kaydet.ExecuteNonQuery();
                con.Close();
            }

            cbEgitmen_SelectedIndexChanged(sender, e);

            //ToDo:öğrenci ders almalı formunu hazırlayalım
        }
    }
}
