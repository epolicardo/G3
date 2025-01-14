﻿namespace Primaton.Front.Formularios
{
    partial class frm_scan
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
            this.components = new System.ComponentModel.Container();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pn_scanner = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btn_detenercamara = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.combobox_camara = new System.Windows.Forms.ComboBox();
            this.picbox_camara = new System.Windows.Forms.PictureBox();
            this.lbl_scanner = new System.Windows.Forms.Label();
            this.timer_scan = new System.Windows.Forms.Timer(this.components);
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.lblDato = new System.Windows.Forms.Label();
            this.pn_scanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_info.Location = new System.Drawing.Point(51, 42);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(164, 17);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "Camara de el Dispositivo";
            // 
            // pn_scanner
            // 
            this.pn_scanner.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pn_scanner.Controls.Add(this.lblDato);
            this.pn_scanner.Controls.Add(this.button2);
            this.pn_scanner.Controls.Add(this.button1);
            this.pn_scanner.Controls.Add(this.listBox1);
            this.pn_scanner.Controls.Add(this.lbl_hora);
            this.pn_scanner.Controls.Add(this.btn_detenercamara);
            this.pn_scanner.Controls.Add(this.btn_show);
            this.pn_scanner.Controls.Add(this.btn_inicio);
            this.pn_scanner.Controls.Add(this.combobox_camara);
            this.pn_scanner.Controls.Add(this.lbl_info);
            this.pn_scanner.Controls.Add(this.picbox_camara);
            this.pn_scanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_scanner.Location = new System.Drawing.Point(0, 0);
            this.pn_scanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_scanner.Name = "pn_scanner";
            this.pn_scanner.Size = new System.Drawing.Size(951, 577);
            this.pn_scanner.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 506);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(731, 197);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 164);
            this.listBox1.TabIndex = 10;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Location = new System.Drawing.Point(717, 9);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(221, 84);
            this.lbl_hora.TabIndex = 9;
            this.lbl_hora.Text = "12:32:25";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_detenercamara
            // 
            this.btn_detenercamara.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_detenercamara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detenercamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detenercamara.Location = new System.Drawing.Point(221, 469);
            this.btn_detenercamara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_detenercamara.Name = "btn_detenercamara";
            this.btn_detenercamara.Size = new System.Drawing.Size(156, 102);
            this.btn_detenercamara.TabIndex = 8;
            this.btn_detenercamara.Text = "Detener Camara";
            this.btn_detenercamara.UseVisualStyleBackColor = false;
            this.btn_detenercamara.Click += new System.EventHandler(this.Btn_detenercamara_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(421, 469);
            this.btn_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(219, 102);
            this.btn_show.TabIndex = 7;
            this.btn_show.Text = "Mostrar Codigo";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(16, 469);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(173, 102);
            this.btn_inicio.TabIndex = 6;
            this.btn_inicio.Text = "Iniciar";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            // 
            // combobox_camara
            // 
            this.combobox_camara.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.combobox_camara.Cursor = System.Windows.Forms.Cursors.No;
            this.combobox_camara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobox_camara.FormattingEnabled = true;
            this.combobox_camara.Location = new System.Drawing.Point(397, 39);
            this.combobox_camara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox_camara.Name = "combobox_camara";
            this.combobox_camara.Size = new System.Drawing.Size(255, 24);
            this.combobox_camara.TabIndex = 5;
            // 
            // picbox_camara
            // 
            this.picbox_camara.BackColor = System.Drawing.Color.Transparent;
            this.picbox_camara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_camara.Location = new System.Drawing.Point(16, 84);
            this.picbox_camara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbox_camara.Name = "picbox_camara";
            this.picbox_camara.Size = new System.Drawing.Size(649, 379);
            this.picbox_camara.TabIndex = 3;
            this.picbox_camara.TabStop = false;
            // 
            // lbl_scanner
            // 
            this.lbl_scanner.AutoSize = true;
            this.lbl_scanner.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.lbl_scanner.Location = new System.Drawing.Point(279, 106);
            this.lbl_scanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_scanner.Name = "lbl_scanner";
            this.lbl_scanner.Size = new System.Drawing.Size(91, 22);
            this.lbl_scanner.TabIndex = 16;
            this.lbl_scanner.Text = "Escanear";
            // 
            // timer_scan
            // 
            this.timer_scan.Tick += new System.EventHandler(this.Timer_scan_Tick);
            // 
            // timer_hora
            // 
            this.timer_hora.Interval = 1000;
            this.timer_hora.Tick += new System.EventHandler(this.Timer_hora_Tick);
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(726, 145);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(46, 17);
            this.lblDato.TabIndex = 13;
            this.lblDato.Text = "label1";
            // 
            // frm_scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pn_scanner);
            this.Controls.Add(this.lbl_scanner);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_scan";
            this.Text = "frm_scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_scan_FormClosing);
            this.pn_scanner.ResumeLayout(false);
            this.pn_scanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel pn_scanner;
        private System.Windows.Forms.Button btn_detenercamara;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.ComboBox combobox_camara;
        private System.Windows.Forms.PictureBox picbox_camara;
        private System.Windows.Forms.Label lbl_scanner;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timer_scan;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDato;
    }
}