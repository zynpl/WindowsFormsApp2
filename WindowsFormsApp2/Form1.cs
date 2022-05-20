using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BOT86M2\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projectDataSet.Movies' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.moviesTableAdapter.Fill(this.projectDataSet.Movies);
       
            SqlCommand cmd = new SqlCommand("execute MovieList @mName='Movie Name',@mGenre='Movie Genre'", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataReader dr = cmd.ExecuteReader();
            //cmd.Parameters.Add(new SqlParameter("@mName='a'", "@mGenre='b'"));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
                da.Fill(dt);
            dataGridView1.DataSource = dt;
       

        }
    }
}
