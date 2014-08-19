using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace instrumental_wbforrms
{
    public partial class ListaSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = System.DateTime.Now;
        }

        protected void dgvSolPendientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void dgvSolPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected row using the SelectedRow property.
            GridViewRow row = dgvSolPendientes.SelectedRow;
            // Display the company name from the selected row.
            // In this example, the third column (index 2) contains
            // the company name.
            MessageLabel.Text = row.Cells[0].Text;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            divFecha.Visible = false;
        }


    }
}