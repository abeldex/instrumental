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
    public partial class Categorias : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.equipo_tipo' Puede moverla o quitarla según sea necesario.
                this.equipo_tipoTableAdapter.Fill(this.instrumentalDataSet.equipo_tipo);
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
                    this.equipo_tipoTableAdapter.Fill(this.instrumentalDataSet.equipo_tipo);
                    txtNombre.Text = string.Empty;
                    txtID.Text = string.Empty;
                    txtID.Select();
             }
            catch
            {
                superValidator1.Validate();
                //MessageBoxEx.Show("-Escriba un ID valido (que no este repetido en los registros)\n-Escriba un Nombre para la Categoria","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            int resultado = negocio.Insertar_Categoria(id, txtNombre.Text);
            negocio = null;
            superValidator1.Validate();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.equipo_tipoTableAdapter.Update(this.instrumentalDataSet.equipo_tipo);
            MessageBoxEx.Show("Los datos que modifico se guardaron correctamente.","INFORMACION",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Categorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgCategoria.Dispose();
        }

        private void dgCategoria_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBoxEx.Show("No se permiten nombres de categoría en blanco", "ERROR CAPTURANDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}