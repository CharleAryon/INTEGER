namespace Integer_Mark_VI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelToolbox = new System.Windows.Forms.Panel();
            this.minivenbtn = new System.Windows.Forms.Button();
            this.minimisarbtn = new System.Windows.Forms.Button();
            this.maximisarbtn = new System.Windows.Forms.Button();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.loginlb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.contratexbox = new System.Windows.Forms.TextBox();
            this.usuariotexbox = new System.Windows.Forms.TextBox();
            this.errorlb = new System.Windows.Forms.Label();
            this.contraseñalb = new System.Windows.Forms.Label();
            this.usuariolb = new System.Windows.Forms.Label();
            this.rbtnlogin = new Integer_Mark_VI.RoundButton();
            this.panelToolbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbox
            // 
            this.panelToolbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelToolbox.Controls.Add(this.minivenbtn);
            this.panelToolbox.Controls.Add(this.minimisarbtn);
            this.panelToolbox.Controls.Add(this.maximisarbtn);
            this.panelToolbox.Controls.Add(this.cerrarbtn);
            this.panelToolbox.Controls.Add(this.loginlb);
            this.panelToolbox.Controls.Add(this.pictureBox1);
            this.panelToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbox.Location = new System.Drawing.Point(0, 0);
            this.panelToolbox.Name = "panelToolbox";
            this.panelToolbox.Size = new System.Drawing.Size(613, 50);
            this.panelToolbox.TabIndex = 0;
            this.panelToolbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolbox_MouseDown);
            // 
            // minivenbtn
            // 
            this.minivenbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minivenbtn.BackgroundImage = global::Integer_Mark_VI.Properties.Resources.Minimizar_ventanita_icon;
            this.minivenbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minivenbtn.FlatAppearance.BorderSize = 0;
            this.minivenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minivenbtn.Location = new System.Drawing.Point(517, 0);
            this.minivenbtn.Name = "minivenbtn";
            this.minivenbtn.Size = new System.Drawing.Size(50, 50);
            this.minivenbtn.TabIndex = 5;
            this.minivenbtn.UseVisualStyleBackColor = true;
            this.minivenbtn.Visible = false;
            this.minivenbtn.Click += new System.EventHandler(this.minivenbtn_Click);
            // 
            // minimisarbtn
            // 
            this.minimisarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimisarbtn.BackgroundImage = global::Integer_Mark_VI.Properties.Resources.Minimizar_Icon;
            this.minimisarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimisarbtn.FlatAppearance.BorderSize = 0;
            this.minimisarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimisarbtn.Location = new System.Drawing.Point(471, 0);
            this.minimisarbtn.Name = "minimisarbtn";
            this.minimisarbtn.Size = new System.Drawing.Size(50, 50);
            this.minimisarbtn.TabIndex = 4;
            this.minimisarbtn.UseVisualStyleBackColor = true;
            this.minimisarbtn.Click += new System.EventHandler(this.minimisarbtn_Click);
            // 
            // maximisarbtn
            // 
            this.maximisarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximisarbtn.BackgroundImage = global::Integer_Mark_VI.Properties.Resources.Maximisar_Icon;
            this.maximisarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximisarbtn.FlatAppearance.BorderSize = 0;
            this.maximisarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximisarbtn.Location = new System.Drawing.Point(517, 0);
            this.maximisarbtn.Name = "maximisarbtn";
            this.maximisarbtn.Size = new System.Drawing.Size(50, 50);
            this.maximisarbtn.TabIndex = 3;
            this.maximisarbtn.UseVisualStyleBackColor = true;
            this.maximisarbtn.Click += new System.EventHandler(this.maximisarbtn_Click);
            // 
            // cerrarbtn
            // 
            this.cerrarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarbtn.BackgroundImage = global::Integer_Mark_VI.Properties.Resources.CloseIcon_2_;
            this.cerrarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerrarbtn.FlatAppearance.BorderSize = 0;
            this.cerrarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.cerrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarbtn.Location = new System.Drawing.Point(563, 0);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(50, 50);
            this.cerrarbtn.TabIndex = 2;
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbtn_Click);
            // 
            // loginlb
            // 
            this.loginlb.AutoSize = true;
            this.loginlb.Font = new System.Drawing.Font("Mandalore", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(166)))), ((int)(((byte)(170)))));
            this.loginlb.Location = new System.Drawing.Point(30, 14);
            this.loginlb.Name = "loginlb";
            this.loginlb.Size = new System.Drawing.Size(67, 21);
            this.loginlb.TabIndex = 1;
            this.loginlb.Text = "INTEGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Integer_Mark_VI.Properties.Resources.IntegerLogo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelDesktop.Controls.Add(this.contratexbox);
            this.panelDesktop.Controls.Add(this.usuariotexbox);
            this.panelDesktop.Controls.Add(this.errorlb);
            this.panelDesktop.Controls.Add(this.contraseñalb);
            this.panelDesktop.Controls.Add(this.usuariolb);
            this.panelDesktop.Controls.Add(this.rbtnlogin);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 50);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(613, 290);
            this.panelDesktop.TabIndex = 1;
            // 
            // contratexbox
            // 
            this.contratexbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contratexbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.contratexbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contratexbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contratexbox.ForeColor = System.Drawing.Color.White;
            this.contratexbox.Location = new System.Drawing.Point(45, 143);
            this.contratexbox.Name = "contratexbox";
            this.contratexbox.Size = new System.Drawing.Size(522, 46);
            this.contratexbox.TabIndex = 5;
            this.contratexbox.UseSystemPasswordChar = true;
            this.contratexbox.TextChanged += new System.EventHandler(this.contratexbox_TextChanged);
            this.contratexbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contratexbox_KeyDown);
            // 
            // usuariotexbox
            // 
            this.usuariotexbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuariotexbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.usuariotexbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuariotexbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotexbox.ForeColor = System.Drawing.Color.White;
            this.usuariotexbox.Location = new System.Drawing.Point(45, 53);
            this.usuariotexbox.Name = "usuariotexbox";
            this.usuariotexbox.Size = new System.Drawing.Size(522, 46);
            this.usuariotexbox.TabIndex = 4;
            this.usuariotexbox.TextChanged += new System.EventHandler(this.usuariotexbox_TextChanged);
            // 
            // errorlb
            // 
            this.errorlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorlb.AutoSize = true;
            this.errorlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(134)))), ((int)(((byte)(136)))));
            this.errorlb.Location = new System.Drawing.Point(240, 109);
            this.errorlb.Name = "errorlb";
            this.errorlb.Size = new System.Drawing.Size(272, 31);
            this.errorlb.TabIndex = 3;
            this.errorlb.Text = "- Contraseña Invalida";
            this.errorlb.Visible = false;
            // 
            // contraseñalb
            // 
            this.contraseñalb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contraseñalb.AutoSize = true;
            this.contraseñalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñalb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.contraseñalb.Location = new System.Drawing.Point(39, 109);
            this.contraseñalb.Name = "contraseñalb";
            this.contraseñalb.Size = new System.Drawing.Size(204, 31);
            this.contraseñalb.TabIndex = 2;
            this.contraseñalb.Text = "CONTRASEÑA";
            // 
            // usuariolb
            // 
            this.usuariolb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuariolb.AutoSize = true;
            this.usuariolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariolb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.usuariolb.Location = new System.Drawing.Point(39, 19);
            this.usuariolb.Name = "usuariolb";
            this.usuariolb.Size = new System.Drawing.Size(139, 31);
            this.usuariolb.TabIndex = 1;
            this.usuariolb.Text = "USUARIO";
            // 
            // rbtnlogin
            // 
            this.rbtnlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.rbtnlogin.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.rbtnlogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.rbtnlogin.BorderRadius = 40;
            this.rbtnlogin.BorderSize = 0;
            this.rbtnlogin.FlatAppearance.BorderSize = 0;
            this.rbtnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnlogin.ForeColor = System.Drawing.Color.White;
            this.rbtnlogin.Location = new System.Drawing.Point(45, 213);
            this.rbtnlogin.Name = "rbtnlogin";
            this.rbtnlogin.Size = new System.Drawing.Size(522, 45);
            this.rbtnlogin.TabIndex = 0;
            this.rbtnlogin.Text = "Iniciar Sesión";
            this.rbtnlogin.TextColor = System.Drawing.Color.White;
            this.rbtnlogin.UseVisualStyleBackColor = false;
            this.rbtnlogin.Click += new System.EventHandler(this.rbtnlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 340);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelToolbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(629, 379);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelToolbox.ResumeLayout(false);
            this.panelToolbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbox;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Label loginlb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button maximisarbtn;
        private System.Windows.Forms.Button minimisarbtn;
        private System.Windows.Forms.Button minivenbtn;
        private RoundButton rbtnlogin;
        private System.Windows.Forms.TextBox contratexbox;
        private System.Windows.Forms.TextBox usuariotexbox;
        private System.Windows.Forms.Label errorlb;
        private System.Windows.Forms.Label contraseñalb;
        private System.Windows.Forms.Label usuariolb;
    }
}

