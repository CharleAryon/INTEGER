using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_Mark_VI
{
    public partial class Registrar_Pacientes : Form
    {
        public Registrar_Pacientes()
        {
            InitializeComponent();
        }

        private void ibtnvolvregpaci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int mes, dia, año;
        private void ccbmes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            mes = ccbmes.SelectedIndex+1;
        }

        private void ccbdianac_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //dia = ccbdianac.SelectedIndex+1;
        }

        private void ccbaño_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dia = int.Parse(ccbdianac.Texts);
            año = int.Parse(ccbaño.Texts);
            DateTime nacimiento = new DateTime(año, mes, dia); //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            tbxedad.Text = edad.ToString();
        }

        public void ccbaño_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            año = ccbaño.SelectedIndex;
        }
    }
}
