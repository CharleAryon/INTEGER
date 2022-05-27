using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_Mark_VI.FormasHijo
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numdays)
        {
            lbdays.Text = numdays + "";
        }

        public void normdays()
        {
            this.Size = new Size(74, 37);
        }
        public void maxdays()
        {
            this.Size = new Size(166, 93);
        }
    }
}
