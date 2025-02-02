﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton.Front.Formularios
{
    public partial class frm_pesajeplastico : Form
    {
        public frm_pesajeplastico()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int ingreso = rdm.Next(1, 10000);
            lblPeso.Text = "El peso ingresado es: " + ingreso.ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            lblPuntosGanados.Visible = true;
            lblPuntosAcumulados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = peso * 0.4;
            lblPuntosGanados.Text = "Estás sumando: " + Convert.ToString(peso);
        }

        private void BtSiguiente_Click(object sender, EventArgs e)
        {
            Form siguiente = new frm_SelectBenefit();
            siguiente.ShowDialog();

            //Aca guardo el registro
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            Form Volver = new frm_tiposdereciclaje();
            Volver.ShowDialog();
        }
    }
}
