using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Instrumental_Desktop
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TileCategorias_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            cat.MdiParent = this;
            cat.Show();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            Equipos eq = new Equipos();
            eq.MdiParent = this;
            eq.Show();
        }

        private void tabEquipos_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem5_Click(object sender, EventArgs e)
        {
            Brigadas bri = new Brigadas();
            bri.MdiParent = this;
            bri.Show();
        }

        private void metroTileItem6_Click(object sender, EventArgs e)
        {
            Alumnos al = new Alumnos();
            al.MdiParent = this;
            al.Show();
        }

        private void metroAppButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            Materias mat = new Materias();
            mat.MdiParent = this;
            mat.Show();
        }

        private void metroTileItem2_Click_1(object sender, EventArgs e)
        {
            Profesores profe = new Profesores();
            profe.MdiParent = this;
            profe.Show();
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            Practicas pra = new Practicas();
            pra.MdiParent = this;
            pra.Show();
        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {
            Practica_Profesores pp = new Practica_Profesores();
            pp.MdiParent = this;
            pp.Show();
        }

        private void metroTileItem7_Click(object sender, EventArgs e)
        {
            Solicitud sol = new Solicitud();
            sol.MdiParent = this;
            sol.Show();
        }

        private void metroShell1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorPickerButton1_SelectedColorChanged(object sender, EventArgs e)
        {
        }

        private void customColorBlender1_SelectedColorChanged(object sender, EventArgs e)
        {
            
        }
    }
}