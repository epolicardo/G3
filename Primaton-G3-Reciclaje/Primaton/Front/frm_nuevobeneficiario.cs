﻿using entidades;
using System;
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
    public partial class frm_nuevobeneficiario : Form
    {
        public int genero { get; set; }
        public frm_nuevobeneficiario()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                user Usuario = new user();
                beneficiario Beneficiario = new beneficiario();

                Usuario.NombreUsuario = txtCorreo.Text;
                Usuario.Clave = txtClave.Text;
                Beneficiario.Apellido = txtApellido.Text;
                Beneficiario.Nombre = TxtNombre.Text;
                if (rbFemenino.Checked)
                {
                    genero = 1;
                }
                if (rbMasculino.Checked)
                {
                    genero = 2;
                }
                if (rbNoBinario.Checked)
                {
                    genero = 3;
                }
                Beneficiario.Genero = genero;
                Usuario.Beneficiario = Beneficiario;
                string[] columnas = { "usuario", "apellido", "nombre", "genero", "clave" };

                Persistencia db = new Persistencia(5, columnas, "Usuarios");
                string[] datos = {
                    Usuario.NombreUsuario,
                    Usuario.Beneficiario.Apellido,
                    Usuario.Beneficiario.Nombre,
                    Usuario.Beneficiario.Genero.ToString(),
                    Usuario.Clave
                };
                db.CargaDatos(datos, 5, columnas);

                MessageBox.Show("El usuario fue dado de alta correctamente.");



            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}