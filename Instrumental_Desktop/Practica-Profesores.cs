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
    public partial class Practica_Profesores : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Practica_Profesores()
        {
            InitializeComponent();
        }

        private void Practica_Profesores_Load(object sender, EventArgs e)
        {
           // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.practica' Puede moverla o quitarla según sea necesario.
            this.practicaTableAdapter.Fill(this.instrumentalDataSet.practica);
            // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.instrumentalDataSet.materia);
            // TODO: esta línea de código carga datos en la tabla 'instrumentalDataSet.profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter.Fill(this.instrumentalDataSet.profesor);
            lbMateria.SelectedIndex = 1;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void Practica_Profesores_FormClosing(object sender, FormClosingEventArgs e)
        {
            lbMateria.Dispose();
            lbProfesor.Dispose();
            lbPractica.Dispose();
        }

        private void lbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.practicaTableAdapter.FillBy1(this.instrumentalDataSet.practica, ((int)(System.Convert.ChangeType(lbMateria.SelectedValue.ToString(), typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void lbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.obtener_practica_profesorTableAdapter.Fill(this.instrumentalDataSet.obtener_practica_profesor, ((int)(System.Convert.ChangeType(lbProfesor.SelectedValue.ToString(), typeof(int)))));
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Este profesor tiene practicas repetidas.");
            }
        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                this.obtener_practica_profesorTableAdapter.Fill(this.instrumentalDataSet.obtener_practica_profesor, ((int)(System.Convert.ChangeType(lbProfesor.SelectedValue.ToString(), typeof(int)))));
            }
            catch (Exception er)
            {
                MessageBoxEx.Show(er.Message);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int profesor = int.Parse(lbProfesor.SelectedValue.ToString());           
            int practica = int.Parse(lbPractica.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Practica_Profesor(profesor, practica);
            negocio = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}