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
    public partial class Solicitud : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Solicitud()
        {
            InitializeComponent();
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            calendar.SelectedDate = DateTime.Today;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void calendar_DateChanged(object sender, EventArgs e)
        {
            try
            {
            dgPracticas.DataSource = AccesoLogica.ObtenerSolicitudPorFecha(calendar.SelectedDate.ToShortDateString());
            dgPracticas.Refresh();
            }
            catch (Exception err)
            {
                MessageBoxEx.Show(err.Message);
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Editar(sender, e);

        }

        protected void Editar(object sender, EventArgs e)
        {
            try
            {
                int Folio = (int)dgPracticas.CurrentRow.Cells["SOLICITUD"].Value; ;
                Solicitud_detalle sol_detalle = new Solicitud_detalle(Folio, this);
                sol_detalle.Show();
            }
            catch
            {
                MessageBoxEx.Show("Seleccione una solicitud de la lista primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgPracticas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Editar(sender, e);
        }
    }
}