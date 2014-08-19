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
    public partial class Materias : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Materias()
        {
            InitializeComponent();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.materia' Puede moverla o quitarla según sea necesario.
                this.materiaTableAdapter.Fill(this.instrumentalDataSet.materia);
            }
            catch (Exception error)
            {
                MessageBoxEx.Show(error.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                superValidator1.Validate();
            }
            else
            {
                try
                {
                    Agregar(sender, e);
                    this.materiaTableAdapter.Fill(this.instrumentalDataSet.materia);
                    txtNombre.Text = string.Empty;
                    txtNombre.Select();
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
            int resultado = negocio.INSERTAR_Materia(txtNombre.Text);
            negocio = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.materiaTableAdapter.Update(this.instrumentalDataSet.materia);
            MessageBoxEx.Show("Los datos que modifico se guardaron correctamente.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Materias_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgMaterias.Dispose();
        }

        private void dgMaterias_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("No se permiten nombres de categoría en blanco", "ERROR CAPTURANDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}