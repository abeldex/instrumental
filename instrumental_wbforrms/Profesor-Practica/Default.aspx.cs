using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace instrumental_wbforrms.Practica_Profesor
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                GridView1.DataSourceID = "SqlDataSourcePracticaProfesor";
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int profesor = int.Parse(cmbProfesor.SelectedValue.ToString());
            int practica = int.Parse(cmbPractica.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Practica_Profesor(profesor, practica);
            negocio = null;
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}