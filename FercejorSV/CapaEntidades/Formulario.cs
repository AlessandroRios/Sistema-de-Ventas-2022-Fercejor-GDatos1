﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEntidades
{
    public class Formulario
    {
        public Formulario() { }

        public static Form formularioActivo = null;

        public void mostrarFormulario(Form formulario, Panel contenedor)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.AntiqueWhite;
            contenedor.Controls.Add(formulario);
            formulario.Show();

        }
    }
}
