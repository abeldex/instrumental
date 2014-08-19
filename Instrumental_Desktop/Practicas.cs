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
    public partial class Practicas : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Practicas()
        {
            InitializeComponent();
        }

        private void Practicas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.practica' Puede moverla o quitarla según sea necesario.
            this.practicaTableAdapter.Fill(this.instrumentalDataSet.practica);
            // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.instrumentalDataSet.materia);
            cmbMateria.SelectedIndex = 1;
        }

        private void cmbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.practicaTableAdapter.FillBy(this.instrumentalDataSet.practica, ((int)(System.Convert.ChangeType(cmbMateria.SelectedValue.ToString(), typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Practicas_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmbMateria.Dispose();
            dgPracticas.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNumero.Text == "")
            {
                superValidator1.Validate();
            }
            else
            {
                try
                {
                    Agregar(sender, e);
                    this.practicaTableAdapter.FillBy(this.instrumentalDataSet.practica, ((int)(System.Convert.ChangeType(cmbMateria.SelectedValue.ToString(), typeof(int)))));
                    txtNumero.Value = 0;
                    txtNombre.Text = string.Empty;
                    txtNumero.Select();
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
            int practica = int.Parse(txtNumero.Text);
            int materia = int.Parse(cmbMateria.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Practica(practica, txtNombre.Text, materia);
            negocio = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.practicaTableAdapter.Update(this.instrumentalDataSet.practica);
            MessageBoxEx.Show("Los datos que modifico se guardaron correctamente.");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPracticas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("No se permiten nombres de categoría en blanco", "ERROR CAPTURANDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}