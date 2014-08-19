using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace instrumental_wbforrms
{
    public partial class AsignarEquipos : System.Web.UI.Page
    {
        AccesoLogica negocio = new AccesoLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                GridView1.DataBind();
                //GridView1.DataSourceID = "SqlDataSourcePracticaEquipo";
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

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int index = 0;
            if (e.CommandName == "Select")
                index = Convert.ToInt32(e.CommandArgument);
            int Equipo = Convert.ToInt32(GridView1.DataKeys[index].Value);
            try
            {
                negocio.ELIMINAR_equipo_practica(Equipo);
                GridView1.DataBind();
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        protected void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void cmbPractica_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}