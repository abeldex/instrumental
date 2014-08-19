using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace instrumental_wbforrms.Alumnos
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
                GridView1.DataSourceID = "SqlDataSourceAlumnos";
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int brigada = int.Parse(cmbBrigada.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Alumno(txtCuenta.Text, brigada, txtNombre.Text, txtGrupo.Text, txtTelefono.Text);
            negocio = null;
            txtCuenta.Text = string.Empty;
            txtGrupo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }
    }
}