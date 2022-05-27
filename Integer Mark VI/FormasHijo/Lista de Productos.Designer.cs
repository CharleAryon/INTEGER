namespace Integer_Mark_VI
{
    partial class Lista_de_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneltblistpro = new System.Windows.Forms.Panel();
            this.titlistpaclb = new System.Windows.Forms.Label();
            this.ibtnvolv = new FontAwesome.Sharp.IconButton();
            this.paneldesklistpro = new System.Windows.Forms.Panel();
            this.roundButton3 = new Integer_Mark_VI.RoundButton();
            this.cComboBox1 = new Integer_Mark_VI.CComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paneltblistpro.SuspendLayout();
            this.paneldesklistpro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltblistpro
            // 
            this.paneltblistpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.paneltblistpro.Controls.Add(this.titlistpaclb);
            this.paneltblistpro.Controls.Add(this.ibtnvolv);
            this.paneltblistpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltblistpro.Location = new System.Drawing.Point(0, 0);
            this.paneltblistpro.Name = "paneltblistpro";
            this.paneltblistpro.Size = new System.Drawing.Size(586, 50);
            this.paneltblistpro.TabIndex = 0;
            // 
            // titlistpaclb
            // 
            this.titlistpaclb.AutoSize = true;
            this.titlistpaclb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlistpaclb.ForeColor = System.Drawing.Color.White;
            this.titlistpaclb.Location = new System.Drawing.Point(56, 9);
            this.titlistpaclb.Name = "titlistpaclb";
            this.titlistpaclb.Size = new System.Drawing.Size(239, 31);
            this.titlistpaclb.TabIndex = 1;
            this.titlistpaclb.Text = "Lista de Productos";
            // 
            // ibtnvolv
            // 
            this.ibtnvolv.FlatAppearance.BorderSize = 0;
            this.ibtnvolv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnvolv.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ibtnvolv.IconColor = System.Drawing.Color.White;
            this.ibtnvolv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnvolv.Location = new System.Drawing.Point(0, 0);
            this.ibtnvolv.Name = "ibtnvolv";
            this.ibtnvolv.Size = new System.Drawing.Size(50, 50);
            this.ibtnvolv.TabIndex = 0;
            this.ibtnvolv.UseVisualStyleBackColor = true;
            this.ibtnvolv.Click += new System.EventHandler(this.ibtnvolv_Click);
            // 
            // paneldesklistpro
            // 
            this.paneldesklistpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.paneldesklistpro.Controls.Add(this.dataGridView1);
            this.paneldesklistpro.Controls.Add(this.roundButton3);
            this.paneldesklistpro.Controls.Add(this.cComboBox1);
            this.paneldesklistpro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesklistpro.Location = new System.Drawing.Point(0, 50);
            this.paneldesklistpro.Name = "paneldesklistpro";
            this.paneldesklistpro.Size = new System.Drawing.Size(586, 342);
            this.paneldesklistpro.TabIndex = 1;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.roundButton3.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.roundButton3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roundButton3.BorderRadius = 40;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(389, 290);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(168, 40);
            this.roundButton3.TabIndex = 24;
            this.roundButton3.Text = "Editar Producto";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // cComboBox1
            // 
            this.cComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.cComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox1.BorderSize = 1;
            this.cComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cComboBox1.ForeColor = System.Drawing.Color.White;
            this.cComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.cComboBox1.Location = new System.Drawing.Point(21, 30);
            this.cComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.cComboBox1.Name = "cComboBox1";
            this.cComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.cComboBox1.Size = new System.Drawing.Size(536, 30);
            this.cComboBox1.TabIndex = 22;
            this.cComboBox1.Texts = "Nombre Filtro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 205);
            this.dataGridView1.TabIndex = 31;
            // 
            // Lista_de_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 392);
            this.Controls.Add(this.paneldesklistpro);
            this.Controls.Add(this.paneltblistpro);
            this.MinimumSize = new System.Drawing.Size(602, 431);
            this.Name = "Lista_de_Productos";
            this.Text = "Lista_de_Productos";
            this.paneltblistpro.ResumeLayout(false);
            this.paneltblistpro.PerformLayout();
            this.paneldesklistpro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltblistpro;
        private System.Windows.Forms.Label titlistpaclb;
        private FontAwesome.Sharp.IconButton ibtnvolv;
        private System.Windows.Forms.Panel paneldesklistpro;
        private RoundButton roundButton3;
        private CComboBox cComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}