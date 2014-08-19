using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Negocio;

namespace instrumental_wbforrms.Solititud
{
    public partial class Default : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BDPLite1.SelectedDate = DateTime.Today;
                txtHoraSalida.Text = DateTime.Now.ToString("hh:mm");
                DivEquipos.Visible = false;
                cmbSolicitudNumero.DataBind();
                i = int.Parse(cmbSolicitudNumero.SelectedValue.ToString());
                i = i+1;
                lblFolio.Text = i.ToString();
            }
        }

        protected void ActualizarNombres(object sender, EventArgs e)
        {
            GridView2.DataBind();
        }

        protected void cmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnSeleccionarEquipos_Click(object sender, EventArgs e)
        { 
            try
            {
                Agregar(sender, e);
                DivEquipos.Visible = true;
                btnSeleccionarEquipos.Visible = false;
                txtCantidad.Text = "1";
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            string fecha = BDPLite1.SelectedDateFormatted;
            int brigada = int.Parse(cmbBrigada.SelectedValue.ToString());
            int profesor = int.Parse(cmbMaestros.SelectedValue.ToString());
            int practica = int.Parse(cmbPractica.SelectedValue.ToString());
            int turno = int.Parse(cmbTurno.SelectedValue.ToString());   
            int resultado = negocio.INSERTAR_Solicitud(brigada, fecha, txtHoraSalida.Text, "00:00", practica, profesor, true, turno);
            negocio = null;
            cmbSolicitudNumero.DataBind();
            cmbBrigada.Enabled = false;
            BDPLite1.Enabled = false;
            txtHoraSalida.Enabled = false;
            cmbMaestros.Enabled = false;
            cmbPractica.Enabled = false;
            btnSeleccionarEquipos.Enabled = false;
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        protected void AgregarEquipo(object sender, EventArgs e)
        {
            int sol_numero = int.Parse(cmbSolicitudNumero.SelectedValue.ToString());
            int equipo_cod = int.Parse(cmbEquipos.SelectedValue.ToString());
            int cantidad = int.Parse(txtCantidad.Text);
            AccesoLogica negocio = new AccesoLogica();
            int resultado = negocio.INSERTAR_Solicitud_detalle(sol_numero, equipo_cod, cantidad);
            negocio = null;
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            try
            {
                AgregarEquipo(sender, e);
                GridView1.DataBind();
                cmbEquipos.DataBind();
                txtCantidad.Text = "1";
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmbEquipos.Visible = false;
            btnAgregar.Visible = false;
            Button1.Visible = false;
            Response.Redirect("Default.aspx");
        }

        protected void cmbSolicitudNumero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void cmbTurno_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void txtFecha_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtFecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtFecha_TextChanged1(object sender, EventArgs e)
        {
        }

        protected void btnTurno_Click(object sender, EventArgs e)
        {
            lblFecha.Text = BDPLite1.SelectedDateFormatted;
            cmbTurno.DataBind();
        }
    }
}