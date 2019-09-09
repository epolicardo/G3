﻿using Primaton_G3_Reciclaje.Front_End.Formularios;
using System;
using System.Windows.Forms;
namespace Primaton_G3_Reciclaje
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            timer_hora.Start();
        }
        #region EVENTOS HERRAMIENTAS

        private void Link_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_registro_comercio = new Form();
            frm_registro_comercio.ShowDialog();
        }
        #endregion

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            //lbl_hora.Text = DateTime.Now..ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form frm_scan = new frm_scan();
            frm_scan.ShowDialog();
            
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            Form frm_tiposdereciclaje = new frm_tiposdereciclaje();

            frm_tiposdereciclaje.ShowDialog();
        }
    }
}
