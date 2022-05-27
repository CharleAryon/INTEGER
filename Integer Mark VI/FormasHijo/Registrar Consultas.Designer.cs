namespace Integer_Mark_VI
{
    partial class Registro_de_Consultas
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
            this.paneltblistpac = new System.Windows.Forms.Panel();
            this.titlelistpac = new System.Windows.Forms.Label();
            this.ibtnvollistpa = new FontAwesome.Sharp.IconButton();
            this.paneldesklistpa = new System.Windows.Forms.Panel();
            this.cComboBox1 = new Integer_Mark_VI.CComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cComboBox2 = new Integer_Mark_VI.CComboBox();
            this.paneltblistpac.SuspendLayout();
            this.paneldesklistpa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltblistpac
            // 
            this.paneltblistpac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(123)))), ((int)(((byte)(33)))));
            this.paneltblistpac.Controls.Add(this.titlelistpac);
            this.paneltblistpac.Controls.Add(this.ibtnvollistpa);
            this.paneltblistpac.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltblistpac.Location = new System.Drawing.Point(0, 0);
            this.paneltblistpac.Name = "paneltblistpac";
            this.paneltblistpac.Size = new System.Drawing.Size(586, 50);
            this.paneltblistpac.TabIndex = 0;
            // 
            // titlelistpac
            // 
            this.titlelistpac.AutoSize = true;
            this.titlelistpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelistpac.ForeColor = System.Drawing.Color.White;
            this.titlelistpac.Location = new System.Drawing.Point(56, 9);
            this.titlelistpac.Name = "titlelistpac";
            this.titlelistpac.Size = new System.Drawing.Size(282, 31);
            this.titlelistpac.TabIndex = 1;
            this.titlelistpac.Text = "Registro de Consultas";
            // 
            // ibtnvollistpa
            // 
            this.ibtnvollistpa.FlatAppearance.BorderSize = 0;
            this.ibtnvollistpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnvollistpa.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ibtnvollistpa.IconColor = System.Drawing.Color.White;
            this.ibtnvollistpa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnvollistpa.Location = new System.Drawing.Point(0, 0);
            this.ibtnvollistpa.Name = "ibtnvollistpa";
            this.ibtnvollistpa.Size = new System.Drawing.Size(50, 50);
            this.ibtnvollistpa.TabIndex = 0;
            this.ibtnvollistpa.UseVisualStyleBackColor = true;
            this.ibtnvollistpa.Click += new System.EventHandler(this.ibtnvollistpa_Click);
            // 
            // paneldesklistpa
            // 
            this.paneldesklistpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.paneldesklistpa.Controls.Add(this.cComboBox2);
            this.paneldesklistpa.Controls.Add(this.groupBox1);
            this.paneldesklistpa.Controls.Add(this.cComboBox1);
            this.paneldesklistpa.Controls.Add(this.label2);
            this.paneldesklistpa.Controls.Add(this.label1);
            this.paneldesklistpa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesklistpa.Location = new System.Drawing.Point(0, 50);
            this.paneldesklistpa.Name = "paneldesklistpa";
            this.paneldesklistpa.Size = new System.Drawing.Size(586, 342);
            this.paneldesklistpa.TabIndex = 1;
            // 
            // cComboBox1
            // 
            this.cComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.cComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox1.BorderSize = 0;
            this.cComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox1.Items.AddRange(new object[] {
            "Akali martinez",
            "Carlos Jimenez",
            "Abimael Jimenez",
            "Starossa Mael",
            "Akali Jimenez"});
            this.cComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.cComboBox1.Location = new System.Drawing.Point(12, 56);
            this.cComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.cComboBox1.Name = "cComboBox1";
            this.cComboBox1.Size = new System.Drawing.Size(200, 30);
            this.cComboBox1.TabIndex = 13;
            this.cComboBox1.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(383, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recomendaciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(193, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tratamiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Diagnostico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paciente";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(387, 52);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 149);
            this.textBox4.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(197, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 149);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(9, 52);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 149);
            this.textBox3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 210);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta:";
            // 
            // cComboBox2
            // 
            this.cComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.cComboBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox2.BorderSize = 0;
            this.cComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.cComboBox2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cComboBox2.ListTextColor = System.Drawing.Color.DimGray;
            this.cComboBox2.Location = new System.Drawing.Point(374, 56);
            this.cComboBox2.MinimumSize = new System.Drawing.Size(200, 30);
            this.cComboBox2.Name = "cComboBox2";
            this.cComboBox2.Size = new System.Drawing.Size(200, 30);
            this.cComboBox2.TabIndex = 16;
            this.cComboBox2.Texts = "19/Mayo/2022";
            // 
            // Registro_de_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 392);
            this.Controls.Add(this.paneldesklistpa);
            this.Controls.Add(this.paneltblistpac);
            this.MinimumSize = new System.Drawing.Size(602, 431);
            this.Name = "Registro_de_Consultas";
            this.Text = "Registro_de_Consultas";
            this.paneltblistpac.ResumeLayout(false);
            this.paneltblistpac.PerformLayout();
            this.paneldesklistpa.ResumeLayout(false);
            this.paneldesklistpa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltblistpac;
        private FontAwesome.Sharp.IconButton ibtnvollistpa;
        private System.Windows.Forms.Panel paneldesklistpa;
        private System.Windows.Forms.Label titlelistpac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private CComboBox cComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CComboBox cComboBox2;
    }
}