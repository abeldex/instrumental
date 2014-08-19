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
    public partial class Equipos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Equipos()
        {
            InitializeComponent();
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCategoria.Select();
                // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.equipo_tipo' Puede moverla o quitarla según sea necesario.
                this.equipo_tipoTableAdapter.Fill(this.instrumentalDataSet.equipo_tipo);
                // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.equipo' Puede moverla o quitarla según sea necesario.
                this.equipoTableAdapter.Fill(this.instrumentalDataSet.equipo);
            }
            catch (Exception error)
            {
                MessageBoxEx.Show(error.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                this.equipoTableAdapter.Fill(this.instrumentalDataSet.equipo);
            }
            catch
            {
                superValidator1.Validate();
                //MessageBoxEx.Show("Error",er.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int cant = int.Parse(txtCantidad.Text);
            string nombre = txtNombre.Text;
            int categoria = int.Parse(cmbCategoria.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Equipo(categoria, nombre, cant, txtSerie.Text);
            negocio = null;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.equipoTableAdapter.Update(this.instrumentalDataSet.equipo);
            MessageBoxEx.Show("Los datos que modifico se guardaron correctamente.");
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Equipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmbCategoria.Dispose();
            dgEquipos.Dispose();
        }

        private void dgEquipos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("No se permiten campos vacios en la tabla", "ERROR CAPTURANDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}