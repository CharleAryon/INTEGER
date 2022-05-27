using Integer_Mark_VI.FormasHijo;
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
    public partial class Agenda : Form
    {
        int mes, año;
        public Agenda()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            año = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbmonthyear.Text = monthname.ToUpper() + " " + año;

            //El principio del mes
            DateTime startmonth = new DateTime(año, mes, 1);

            //Obtener el numero del dias de ese mes
            int days = DateTime.DaysInMonth(año, mes);

            //convertir el principio del mes en entero
            int dayofweek = Convert.ToInt32(startmonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlanco ucb = new UserControlBlanco();
                flpagenda.Controls.Add(ucb);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                flpagenda.Controls.Add(ucd);
            }
        }

        private void ibtnnext_Click(object sender, EventArgs e)
        {
            //Limpiar el Control
            flpagenda.Controls.Clear();

            //Incremento de Mes
            
            if (mes == 12)
            {
                año++;
                mes = 1;
            }
            else
            {
                mes++;
            }

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

            lbmonthyear.Text = monthname.ToUpper() + " " + año;

            DateTime startmonth = new DateTime(año, mes, 1);

            //Obtener el numero del dias de ese mes
            int days = DateTime.DaysInMonth(año, mes);

            //convertir el principio del mes en entero
            int dayofweek = Convert.ToInt32(startmonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlanco ucb = new UserControlBlanco();
                flpagenda.Controls.Add(ucb);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                flpagenda.Controls.Add(ucd);
            }
        }

        private void ibtntoday_Click(object sender, EventArgs e)
        {
            flpagenda.Controls.Clear();
            displayDays();
        }

        private void ibtnprevius_Click(object sender, EventArgs e)
        {
            //Limpiar el Control
            flpagenda.Controls.Clear();

            //Decremento de Mes

            if (mes == 1)
            {
                año--;
                mes = 12;
            }
            else
            {
                mes--;
            }

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbmonthyear.Text = monthname.ToUpper() + " " + año;

            DateTime startmonth = new DateTime(año, mes, 1);

            //Obtener el numero del dias de ese mes
            int days = DateTime.DaysInMonth(año, mes);

            //convertir el principio del mes en entero
            int dayofweek = Convert.ToInt32(startmonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlanco ucb = new UserControlBlanco();
                flpagenda.Controls.Add(ucb);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                flpagenda.Controls.Add(ucd);
            }
        }
    }
}
