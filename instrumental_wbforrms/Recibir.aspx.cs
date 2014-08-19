using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace instrumental_wbforrms
{
    public partial class Recibir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            datos.Visible = false;
            error.Visible = false;
            botones.Visible = false;
            DivEquiposSol.Visible = false;
            DivIntegrantesBrigada.Visible = false;
            txtNumSol.Focus();
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                DataRow row = AccesoLogica.ObtenerSolicitudPorCodigo(int.Parse(txtNumSol.Text)).Rows[0];
                DateTime fecha;
                lblSolicitud.Text = row["sol_codigo"].ToString();
                fecha = Convert.ToDateTime(row["sol_fecha"]);
                lblFecha.Text = fecha.ToShortDateString();
                lblTurno.Text = row["turno"].ToString();
                lblBride.Text = row["bri_codigo"].ToString();
                datos.Visible = true;
                dgIntegrantesBrigada.DataBind();
                dgEquiposSolicitados.DataBind();
                botones.Visible = true;
                DivIntegrantesBrigada.Visible = true;
                DivEquiposSol.Visible = true;
                txtNumSol.Text = "";
                txtNumSol.Focus();

            }
            catch
            {
                botones.Visible = false;
                DivIntegrantesBrigada.Visible = false;
                DivEquiposSol.Visible = false;
                lblError.Text = "No existe la solicitud intente con un numero valido.";
                error.Visible = true;
            }
        }

        protected void btnRecibir_Click(object sender, EventArgs e)
        {
            recibir_solicitud();
        }

        public void recibir_solicitud()
        {
             try
            {
                AccesoLogica negocio = new AccesoLogica();
                negocio.RecibirEquipos(int.Parse(lblSolicitud.Text));
                negocio = null;
                MessageBox("Se han recibido correctamente los equipos");
                dgEquiposSolicitados.DataBind();
                txtNumSol.Focus();
            }
            catch
            {
                MessageBox("Debe buscar una brigada primero");
            }
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }

    }
}