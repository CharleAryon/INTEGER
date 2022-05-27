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
using System.Collections;

namespace Integer_Mark_VI
{
    public partial class Reportes : Form
    {
        SqlConnection Conection = new SqlConnection("server=ULTIMATE-ARGAME;database=integer; integrated security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Reportes()
        {
            InitializeComponent();
        }

        private void ibtnvolvTMS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            graftopprod();
            grafpacfreq();
        }

        ArrayList Producto = new ArrayList();
        ArrayList cantvent = new ArrayList();
        ArrayList pacient = new ArrayList();
        ArrayList cantvisit = new ArrayList();
        private void graftopprod()
        {
            cmd = new SqlCommand("topproductos",Conection);
            cmd.CommandType = CommandType.StoredProcedure;
            Conection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto.Add(dr.GetString(0));
                cantvent.Add(dr.GetInt32(1));
            }
            charttopprod.Series[0].Points.DataBindXY(Producto,cantvent);
            dr.Close();
            Conection.Close();
        }
        private void grafpacfreq()
        {
            cmd = new SqlCommand("pacfrecuentes", Conection);
            cmd.CommandType = CommandType.StoredProcedure;
            Conection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pacient.Add(dr.GetString(0));
                cantvisit.Add(dr.GetInt32(1));
            }
            chartfreqpac.Series[0].Points.DataBindXY(pacient, cantvisit);
            dr.Close();
            Conection.Close();
        }

        private void ibtntopprod_Click(object sender, EventArgs e)
        {
            if (chartfreqpac.Visible == true)
            {
                chartfreqpac.Visible = false;
                charttopprod.Visible = true;
            }
            else
            {
                charttopprod.Visible = true;
            }
        }

        private void ibtnfreqpaci_Click(object sender, EventArgs e)
        {
            if (charttopprod.Visible == true)
            {
                charttopprod.Visible = false;
                chartfreqpac.Visible = true;
            }
            else
            {
                chartfreqpac.Visible = true;
            }
        }
    }
}
