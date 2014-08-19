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
    public partial class Alumnos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.brigada' Puede moverla o quitarla según sea necesario.
                this.brigadaTableAdapter.Fill(this.instrumentalDataSet.brigada);
                // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.alumno' Puede moverla o quitarla según sea necesario.
                this.alumnoTableAdapter.Fill(this.instrumentalDataSet.alumno);
            }
            catch (Exception error)
            {
                MessageBoxEx.Show(error.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                this.alumnoTableAdapter.Fill(this.instrumentalDataSet.alumno);
                txtNombre.Text = string.Empty;
                txtCuenta.Text = string.Empty;
                txtGrupo.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtNombre.Select();
            }
            catch (Exception er)
            {
                MessageBoxEx.Show(er.Message);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int brigada = int.Parse(cmbBrigadas.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Alumno(txtCuenta.Text, brigada, txtNombre.Text, txtGrupo.Text, txtTelefono.Text);
            negocio = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.alumnoTableAdapter.Update(this.instrumentalDataSet.alumno);
            MessageBoxEx.Show("Los datos que modifico se guardaron correctamente.");
        }

        private void cmbBrigadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgAlumnos.Dispose();
            cmbBrigadas.Dispose();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.brigadaTableAdapter.FillBy(this.instrumentalDataSet.brigada);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}