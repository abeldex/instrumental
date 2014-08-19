using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace instrumental_wbforrms.Profesores
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                GridView1.DataSourceID = "SqlDataSourceProfesores";
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int numero_empleado = int.Parse(txtCodigo.Text);
            int resultado = negocio.INSERTAR_Profesor(numero_empleado, txtNomnbre.Text);
            negocio = null;
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }
    }
}