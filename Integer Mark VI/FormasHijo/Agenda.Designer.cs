namespace Integer_Mark_VI
{
    partial class Agenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.titagenlb = new System.Windows.Forms.Label();
            this.btnvolveagend = new FontAwesome.Sharp.IconButton();
            this.paneldesktopagend = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ibtntoday = new FontAwesome.Sharp.IconButton();
            this.ibtnnext = new FontAwesome.Sharp.IconButton();
            this.ibtnprevius = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbmonthyear = new System.Windows.Forms.Label();
            this.lbday1 = new System.Windows.Forms.Label();
            this.lbday7 = new System.Windows.Forms.Label();
            this.lbday2 = new System.Windows.Forms.Label();
            this.lbday6 = new System.Windows.Forms.Label();
            this.lbday3 = new System.Windows.Forms.Label();
            this.lbday5 = new System.Windows.Forms.Label();
            this.lbday4 = new System.Windows.Forms.Label();
            this.flpagenda = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.paneldesktopagend.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(125)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.titagenlb);
            this.panel1.Controls.Add(this.btnvolveagend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 50);
            this.panel1.TabIndex = 2;
            // 
            // titagenlb
            // 
            this.titagenlb.AutoSize = true;
            this.titagenlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titagenlb.ForeColor = System.Drawing.Color.White;
            this.titagenlb.Location = new System.Drawing.Point(56, 9);
            this.titagenlb.Name = "titagenlb";
            this.titagenlb.Size = new System.Drawing.Size(107, 31);
            this.titagenlb.TabIndex = 1;
            this.titagenlb.Text = "Agenda";
            // 
            // btnvolveagend
            // 
            this.btnvolveagend.FlatAppearance.BorderSize = 0;
            this.btnvolveagend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolveagend.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnvolveagend.IconColor = System.Drawing.Color.White;
            this.btnvolveagend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolveagend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnvolveagend.Location = new System.Drawing.Point(0, 0);
            this.btnvolveagend.Name = "btnvolveagend";
            this.btnvolveagend.Size = new System.Drawing.Size(50, 50);
            this.btnvolveagend.TabIndex = 0;
            this.btnvolveagend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnvolveagend.UseVisualStyleBackColor = true;
            this.btnvolveagend.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // paneldesktopagend
            // 
            this.paneldesktopagend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.paneldesktopagend.Controls.Add(this.panel3);
            this.paneldesktopagend.Controls.Add(this.panel2);
            this.paneldesktopagend.Controls.Add(this.flpagenda);
            this.paneldesktopagend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktopagend.Location = new System.Drawing.Point(0, 50);
            this.paneldesktopagend.MinimumSize = new System.Drawing.Size(586, 342);
            this.paneldesktopagend.Name = "paneldesktopagend";
            this.paneldesktopagend.Size = new System.Drawing.Size(586, 342);
            this.paneldesktopagend.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ibtntoday);
            this.panel3.Controls.Add(this.ibtnnext);
            this.panel3.Controls.Add(this.ibtnprevius);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 32);
            this.panel3.TabIndex = 13;
            // 
            // ibtntoday
            // 
            this.ibtntoday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtntoday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ibtntoday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtntoday.ForeColor = System.Drawing.Color.White;
            this.ibtntoday.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtntoday.IconColor = System.Drawing.Color.Black;
            this.ibtntoday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtntoday.IconSize = 20;
            this.ibtntoday.Location = new System.Drawing.Point(424, 6);
            this.ibtntoday.Name = "ibtntoday";
            this.ibtntoday.Size = new System.Drawing.Size(75, 23);
            this.ibtntoday.TabIndex = 3;
            this.ibtntoday.Text = "Hoy";
            this.ibtntoday.UseVisualStyleBackColor = false;
            this.ibtntoday.Click += new System.EventHandler(this.ibtntoday_Click);
            // 
            // ibtnnext
            // 
            this.ibtnnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ibtnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnnext.ForeColor = System.Drawing.Color.White;
            this.ibtnnext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ibtnnext.IconColor = System.Drawing.Color.White;
            this.ibtnnext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnnext.IconSize = 20;
            this.ibtnnext.Location = new System.Drawing.Point(498, 6);
            this.ibtnnext.Name = "ibtnnext";
            this.ibtnnext.Size = new System.Drawing.Size(85, 23);
            this.ibtnnext.TabIndex = 2;
            this.ibtnnext.Text = "Siguiente";
            this.ibtnnext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnnext.UseVisualStyleBackColor = false;
            this.ibtnnext.Click += new System.EventHandler(this.ibtnnext_Click);
            // 
            // ibtnprevius
            // 
            this.ibtnprevius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnprevius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ibtnprevius.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnprevius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnprevius.ForeColor = System.Drawing.Color.White;
            this.ibtnprevius.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ibtnprevius.IconColor = System.Drawing.Color.White;
            this.ibtnprevius.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnprevius.IconSize = 20;
            this.ibtnprevius.Location = new System.Drawing.Point(353, 6);
            this.ibtnprevius.Name = "ibtnprevius";
            this.ibtnprevius.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ibtnprevius.Size = new System.Drawing.Size(75, 23);
            this.ibtnprevius.TabIndex = 1;
            this.ibtnprevius.Text = "Anterior";
            this.ibtnprevius.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnprevius.UseVisualStyleBackColor = false;
            this.ibtnprevius.Click += new System.EventHandler(this.ibtnprevius_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbmonthyear);
            this.panel2.Controls.Add(this.lbday1);
            this.panel2.Controls.Add(this.lbday7);
            this.panel2.Controls.Add(this.lbday2);
            this.panel2.Controls.Add(this.lbday6);
            this.panel2.Controls.Add(this.lbday3);
            this.panel2.Controls.Add(this.lbday5);
            this.panel2.Controls.Add(this.lbday4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 66);
            this.panel2.TabIndex = 12;
            // 
            // lbmonthyear
            // 
            this.lbmonthyear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbmonthyear.AutoSize = true;
            this.lbmonthyear.ForeColor = System.Drawing.Color.White;
            this.lbmonthyear.Location = new System.Drawing.Point(228, 15);
            this.lbmonthyear.Name = "lbmonthyear";
            this.lbmonthyear.Size = new System.Drawing.Size(76, 13);
            this.lbmonthyear.TabIndex = 11;
            this.lbmonthyear.Text = "MONTHYEAR";
            // 
            // lbday1
            // 
            this.lbday1.AutoSize = true;
            this.lbday1.ForeColor = System.Drawing.Color.White;
            this.lbday1.Location = new System.Drawing.Point(25, 41);
            this.lbday1.Name = "lbday1";
            this.lbday1.Size = new System.Drawing.Size(49, 13);
            this.lbday1.TabIndex = 3;
            this.lbday1.Text = "Domingo";
            // 
            // lbday7
            // 
            this.lbday7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbday7.AutoSize = true;
            this.lbday7.ForeColor = System.Drawing.Color.White;
            this.lbday7.Location = new System.Drawing.Point(501, 41);
            this.lbday7.Name = "lbday7";
            this.lbday7.Size = new System.Drawing.Size(44, 13);
            this.lbday7.TabIndex = 10;
            this.lbday7.Text = "Sabado";
            // 
            // lbday2
            // 
            this.lbday2.AutoSize = true;
            this.lbday2.ForeColor = System.Drawing.Color.White;
            this.lbday2.Location = new System.Drawing.Point(104, 41);
            this.lbday2.Name = "lbday2";
            this.lbday2.Size = new System.Drawing.Size(36, 13);
            this.lbday2.TabIndex = 4;
            this.lbday2.Text = "Lunes";
            // 
            // lbday6
            // 
            this.lbday6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbday6.AutoSize = true;
            this.lbday6.ForeColor = System.Drawing.Color.White;
            this.lbday6.Location = new System.Drawing.Point(404, 41);
            this.lbday6.Name = "lbday6";
            this.lbday6.Size = new System.Drawing.Size(42, 13);
            this.lbday6.TabIndex = 8;
            this.lbday6.Text = "Viernes";
            // 
            // lbday3
            // 
            this.lbday3.AutoSize = true;
            this.lbday3.ForeColor = System.Drawing.Color.White;
            this.lbday3.Location = new System.Drawing.Point(173, 41);
            this.lbday3.Name = "lbday3";
            this.lbday3.Size = new System.Drawing.Size(39, 13);
            this.lbday3.TabIndex = 5;
            this.lbday3.Text = "Martes";
            // 
            // lbday5
            // 
            this.lbday5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbday5.AutoSize = true;
            this.lbday5.ForeColor = System.Drawing.Color.White;
            this.lbday5.Location = new System.Drawing.Point(327, 41);
            this.lbday5.Name = "lbday5";
            this.lbday5.Size = new System.Drawing.Size(41, 13);
            this.lbday5.TabIndex = 7;
            this.lbday5.Text = "Jueves";
            // 
            // lbday4
            // 
            this.lbday4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbday4.AutoSize = true;
            this.lbday4.ForeColor = System.Drawing.Color.White;
            this.lbday4.Location = new System.Drawing.Point(252, 41);
            this.lbday4.Name = "lbday4";
            this.lbday4.Size = new System.Drawing.Size(52, 13);
            this.lbday4.TabIndex = 6;
            this.lbday4.Text = "Miercoles";
            // 
            // flpagenda
            // 
            this.flpagenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpagenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.flpagenda.Location = new System.Drawing.Point(0, 66);
            this.flpagenda.Name = "flpagenda";
            this.flpagenda.Size = new System.Drawing.Size(586, 242);
            this.flpagenda.TabIndex = 0;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 392);
            this.Controls.Add(this.paneldesktopagend);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(602, 431);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneldesktopagend.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnvolveagend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titagenlb;
        private System.Windows.Forms.Panel paneldesktopagend;
        private System.Windows.Forms.Label lbday7;
        private System.Windows.Forms.Label lbday6;
        private System.Windows.Forms.Label lbday5;
        private System.Windows.Forms.Label lbday4;
        private System.Windows.Forms.Label lbday3;
        private System.Windows.Forms.Label lbday2;
        private System.Windows.Forms.Label lbday1;
        private FontAwesome.Sharp.IconButton ibtnnext;
        private FontAwesome.Sharp.IconButton ibtnprevius;
        private System.Windows.Forms.FlowLayoutPanel flpagenda;
        private System.Windows.Forms.Label lbmonthyear;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ibtntoday;
        private System.Windows.Forms.Panel panel2;
    }
}