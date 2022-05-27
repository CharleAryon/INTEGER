using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Integer_Mark_VI
{
    public partial class Login : Form
    {
        //Campos
        private int borderSize = 2;
        private Size formSize;
        //Conexion Base de Datos
        SqlConnection Conection = new SqlConnection("server=ULTIMATE-ARGAME;database=integer; integrated security=True");
        //Constructor
        public Login()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Tamaño Borde
            this.BackColor = Color.FromArgb(32, 34, 37);//Color Borde
        }

        #region Arrastrar Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void panelToolbox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodos de Overrridden
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            #region Form Resize
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remover Borde
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        //Metodo de Evento
        private void Login_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        //Metodo Privado
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                    {
                        this.Padding = new Padding(borderSize);
                    }
                    break;
            }
        }
        #endregion

        #region Login
        private void Login_Load(object sender, EventArgs e)
        {
            usuariotexbox.Text = "Carlos Martínez Sarmiento";
        }

        private void usuariotexbox_TextChanged(object sender, EventArgs e)
        {
            errorlb.Visible = false;
        }

        private void contratexbox_TextChanged(object sender, EventArgs e)
        {
            errorlb.Visible = false;
        }

        private void contratexbox_KeyDown(object sender, KeyEventArgs kea)
        {
            DBConection log = new DBConection();
            bool resultado;
            if (kea.KeyCode.Equals(Keys.Return))
            {
                resultado = log.logear(usuariotexbox.Text, contratexbox.Text);
                if (resultado == true)
                {
                    Menu_Principal frm = new Menu_Principal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    errorlb.Visible = true;
                }
                Conection.Close();
            }
        }

        private void rbtnlogin_Click(object sender, EventArgs e)
        {
            DBConection log = new DBConection();
            bool resultado;
            resultado = log.logear(usuariotexbox.Text, contratexbox.Text);
            if (resultado == true)
            {
                Menu_Principal frm = new Menu_Principal();
                frm.Show();
                this.Hide();
            }
            else
            {
                errorlb.Visible = true;
            }

            //Conection.Open();
            //string consulta = "select * from Usuarios where nusuario='" + usuariotexbox.Text + "' and contraseña='" + contratexbox.Text + "'";
            //SqlCommand comando = new SqlCommand(consulta, Conection);
            //SqlDataReader lector;
            //lector = comando.ExecuteReader();
            //if (lector.HasRows == true)
            //{
            //    Menu_Principal frm = new Menu_Principal();
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    errorlb.Visible = true;
            //}
            //Conection.Close();
        }
        #endregion

        #region Botones ToolBox
        private void minimisarbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximisarbtn_Click(object sender, EventArgs e)
        {
            //Visibilidad de botones
            minivenbtn.Visible = true;
            maximisarbtn.Visible = false;
            //Maximisacion de la ventana
            this.WindowState = FormWindowState.Maximized;
        }

        private void minivenbtn_Click(object sender, EventArgs e)
        {
            //Visibilidad de los botones
            maximisarbtn.Visible = true;
            minivenbtn.Visible = false;
            //Normalizacion de la ventana
            this.WindowState = FormWindowState.Normal;
            Size = new Size(629, 379);
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
