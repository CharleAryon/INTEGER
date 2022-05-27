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
    public partial class UserControlBlanco : UserControl
    {
        public UserControlBlanco()
        {
            InitializeComponent();
        }
        public void normblan()
        {
            this.Size = new Size(74, 37);
        }
        public void maxblan()
        {
            this.Size = new Size(166, 93);
        }
    }
}
