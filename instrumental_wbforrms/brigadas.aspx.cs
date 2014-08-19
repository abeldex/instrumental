using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace instrumental_wbforrms
{
    public partial class brigadas : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnActualiarBrigada.Visible = false;
                divSuccess.Visible = false;
                divError.Visible = false;
                divNuevaBrigada.Visible = false;
            }
        }

        protected void btnCrearBrigada_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoLogica negocio = new AccesoLogica();
                negocio.INSERTAR_Brigada(txt_bri_nombre.Value, txt_bri_grupo.Value, int.Parse(txt_bri_semestre.Value), txt_bri_tipo.Value);
                divSuccess.Visible = true;
                divError.Visible = false;
                GridViewBrigadas.DataBind();
            }
            catch
            {
                MessageBox("Error insertando brigada");
                divError.Visible = true;
                divSuccess.Visible = false;
            }
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }

        protected void btnNuevaBrigada_Click(object sender, EventArgs e)
        {
            integrantesBrigada.Visible = false;
            divNuevaBrigada.Visible = true;
        }

    }
}