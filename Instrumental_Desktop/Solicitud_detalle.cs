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
    public partial class Solicitud_detalle : DevComponents.DotNetBar.Metro.MetroForm
    {
        Solicitud _owner;
        public Solicitud_detalle()
        {
            InitializeComponent();
        }
        int FOLIO;
        public Solicitud_detalle(int folio, Solicitud owner)
        {
            InitializeComponent();
            FOLIO = folio;
            _owner = owner;
            DataRow row = AccesoLogica.ObtenerSolicitudPorCodigo(folio).Rows[0];
            lblFolio.Text = row["sol_codigo"].ToString();
            lblFechaDetalle.Text = row["sol_fecha"].ToString();
            lblTurno.Text = row["turno"].ToString();
            lblBride.Text = row["bri_codigo"].ToString();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void Solicitud_detalle_Load(object sender, EventArgs e)
        {
            //llenar datagrid de integrantes de la brigada
            dgIntegrantesBrigada.DataSource = AccesoLogica.ObtenerAlumnoBrigada(lblBride.Text);
            dgIntegrantesBrigada.Refresh();
            //llenar con los equipos solicitados
            dgEquiposSolicitados.DataSource = AccesoLogica.ObtenerSolicitudDetalle(lblFolio.Text);
            dgEquiposSolicitados.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esto debe imprimir la solicitud");
        }

        private void dgEquiposSolicitados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}