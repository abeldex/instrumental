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
    public partial class Brigadas : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Brigadas()
        {
            InitializeComponent();
        }

        private void Brigadas_Load(object sender, EventArgs e)
        {
            try { 
            // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.brigada' Puede moverla o quitarla según sea necesario.
            this.brigadaTableAdapter.Fill(this.instrumentalDataSet.brigada);
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
            if (txtGrupo.Text == "" || txtNombre.Text == "")
            {
                superValidator1.Validate();
            }
            else
            {
                try
                {
                    Agregar(sender, e);
                    this.brigadaTableAdapter.Fill(this.instrumentalDataSet.brigada);
                    txtNombre.Text = string.Empty;
                    txtGrupo.Text = string.Empty;
                    txtGrupo.Select();
                }
                catch
                {
                    superValidator1.Validate();
                    //MessageBoxEx.Show(er.Message);
                }
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int resultado = negocio.INSERTAR_Brigada(txtNombre.Text, txtGrupo.Text, int.Parse(txtSemestre.Text),cmbTipoBrigada.Text);
            negocio = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.brigadaTableAdapter.Update(this.instrumentalDataSet.brigada);
            MessageBoxEx.Show("Los datos que modifico se guardaron correctamente.");
        }

        private void Brigadas_FormClosing(object sender, FormClosingEventArgs e)
        {         
            dgBrigadas.Dispose();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.brigadaTableAdapter.FillBy1(this.instrumentalDataSet.brigada);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgBrigadas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("No se permiten nombres de categoría en blanco", "ERROR CAPTURANDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void brigadaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}