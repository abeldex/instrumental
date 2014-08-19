using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Negocio;

namespace Instrumental_Desktop
{
    public partial class Profesores : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.profesor' Puede moverla o quitarla según sea necesario.
                this.profesorTableAdapter.Fill(this.instrumentalDataSet.profesor);
            }
            catch (Exception error)
            {
                MessageBoxEx.Show(error.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNumEmpleado.Text == "")
            {
                superValidator1.Validate();
            }
            else
            {
                try
                {
                    Agregar(sender, e);
                    this.profesorTableAdapter.Fill(this.instrumentalDataSet.profesor);
                    txtNumEmpleado.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                    txtNumEmpleado.Select();
                }
                catch (Exception er)
                {
                    MessageBoxEx.Show(er.Message);
                }
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int numeroemp = int.Parse(txtNumEmpleado.Text);
            int resultado = negocio.INSERTAR_Profesor(numeroemp, txtNombre.Text);
            negocio = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.profesorTableAdapter.Update(this.instrumentalDataSet.profesor);
            MessageBoxEx.Show("Los datos que modifico se guardaron correctamente.");
        }

        private void Profesores_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgProfesores.Dispose();
        }

        private void dgProfesores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("No se permiten nombres de categoría en blanco", "ERROR CAPTURANDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}