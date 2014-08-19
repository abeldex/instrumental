using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace instrumental_wbforrms.Equipos_Practica
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                GridView1.DataSourceID = "SqlDataSourcePracticaEquipo";
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int equipo = int.Parse(cmbEquipo.SelectedValue.ToString());
            int practica = int.Parse(cmbPractica.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Practica_Equipo(practica, equipo);
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