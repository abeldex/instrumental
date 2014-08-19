using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Data;

namespace instrumental_wbforrms
{
    public partial class Solicitud : System.Web.UI.Page
    {
        int i; //variable para capturar la ultima solicitud
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //BDPLite1.SelectedDate = DateTime.Today;
                //txtHoraSalida.Text = DateTime.Now.ToString("hh:mm");
                //DivEquipos.Visible = false;
                //DivGrupoBrigada.Visible = false;
                //DivIntegrantesBrigada.Visible = false;
                //btnElegirEquipos.Visible = false;
                cmbSolicitudNumero.DataBind();
                i = int.Parse(cmbSolicitudNumero.SelectedValue.ToString());
                i = i + 1;
                lblFolio.Text = i.ToString();
                divSolEquipos.Visible = false;
                divSelEquipos.Visible = false;       
            }
            else
            {
                          
            }
        }

        protected void eliminar_solicitud()
        {
            try
            {
                AccesoLogica negocio = new AccesoLogica();
                int solicitud = int.Parse(cmbSolicitudNumero.Text);
                negocio.EliminarSolicitud(solicitud);
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }
        protected void btnTurno_Click(object sender, EventArgs e)
        {
            try
            {
                lblFecha.Text = cmbDia.Text + "/" + cmbMes.Text + "/" + cmbAño.Text;
                cmbTurno.DataBind();
                int turno = int.Parse(cmbTurno.Text);
                lblTurno.Text = turno.ToString();
                lblObtTurno.Visible = false;
                btnTurno.Visible = false;
                DivGrupoBrigada.Visible = true;
                DivIntegrantesBrigada.Visible = true;
                btnElegirEquipos.Visible = true;
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }


        protected void ActualizarNombres(object sender, EventArgs e)
        {
            GridView2.DataBind();
        }

        protected void btnSeleccionarEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar(sender, e);
                divSelEquipos.Visible = true;
                divSolEquipos.Visible = true;
                btnSeleccionarEquipos.Enabled = false;
                txtCantidad.Text = "1";
            }
            catch (Exception er)
            {
                MessageBox("No se ha seleccionado un TURNO. Haga Clic en el boton en forma de calendario.");
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            string fecha = lblFecha.Text;
            int brigada = int.Parse(cmbBrigada.SelectedValue.ToString());
            int profesor = int.Parse(cmbMaestros.SelectedValue.ToString());
            int practica = int.Parse(cmbPractica.SelectedValue.ToString());
            int turno = int.Parse(cmbTurno.SelectedValue.ToString());
            int resultado = negocio.INSERTAR_Solicitud(brigada, fecha, DateTime.Now.ToString("hh:mm"), "00:00", practica, profesor, true, turno);
            negocio = null;
            cmbSolicitudNumero.DataBind();
            cmbBrigada.Enabled = false;
            cmbAño.Enabled = false;
            cmbDia.Enabled = false;
            cmbMes.Enabled = false;
            cmbMaestros.Enabled = false;
            cmbPractica.Enabled = false;
            btnSeleccionarEquipos.Enabled = false;
            cmbGrupoBrigada.Enabled = false;
            btnTurno.Enabled = false;
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
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
            catch 
            {
                MessageBox("No se ha seleccionado una Cantidad");
            }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DivGrupoBrigada.Visible = false;
            //DivBotonImprimir.Visible = false;
            //DivSeleccionarEquipos.Visible = false;
            //btnElegirEquipos.Visible = false;
            enviar_solicitud();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

         

           
        }

        protected void enviar_solicitud()
        {
            //System.Web.Exception opcional para manejar datos de respuesta HTTP a un cliente
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            //Para crear una instancia de documento de iTextSharp con el tamaño de página y tamaño de margenes correspondientes
            Document doc = new Document(PageSize.LETTER, 10, 10, 10, 10);
            //La ruta en donde será guardado el pdf dentro del servidor
            String path = this.Server.MapPath(".") + "\\SolicitudesPDF\\Solicitud" + lblFolio.Text + ".pdf";


            //Utilizamos System.IO para crear o sobreescribir el archivo si existe
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //iTextSharp para escribir en el documento PDF
            PdfWriter.GetInstance(doc, file);
            doc.Open();

            //Agregamos  el texto que esta dentro de la etiqueta
            //Se pueden agregar varios solamente añadiendo varias sentencias doc.Add(…)  
            var naranja = new BaseColor(238, 123, 8);
            var verde = new BaseColor(41, 213, 162);
            var MyFontNaranja = FontFactory.GetFont("Calibri", 11, naranja);
            var MyFontVerde = FontFactory.GetFont("Calibri", 13, verde);
            var MyFontNormal = FontFactory.GetFont("Calibri", 10, BaseColor.DARK_GRAY);
            string url = "http://servidor/instrumental/Content/themes/AdminTemplate/img/logouasderecha.png";
            iTextSharp.text.Image logouasderecha = iTextSharp.text.Image.GetInstance(new Uri(url));
            logouasderecha.SetAbsolutePosition(doc.PageSize.Width - 25f - 72f, doc.PageSize.Height - 1f - 60f);
            logouasderecha.ScaleAbsoluteWidth(80);
            logouasderecha.ScaleAbsoluteHeight(42);
            iTextSharp.text.Image logocentro = iTextSharp.text.Image.GetInstance(new Uri("http://servidor/instrumental/Content/themes/AdminTemplate/img/Notebook.png"));
            logocentro.SetAbsolutePosition(doc.PageSize.Width - 400f - 72f, doc.PageSize.Height - 1f - 70f);
            logocentro.ScaleAbsoluteWidth(355);
            logocentro.ScaleAbsoluteHeight(59);
            iTextSharp.text.Image logofacite = iTextSharp.text.Image.GetInstance(new Uri("http://servidor/instrumental/Content/themes/AdminTemplate/img/logo_b.png"));
            logofacite.SetAbsolutePosition(doc.PageSize.Width - 470f - 72f, doc.PageSize.Height - 1f - 70f);
            logofacite.ScaleAbsoluteWidth(52);
            logofacite.ScaleAbsoluteHeight(52);
            iTextSharp.text.Image logoInstrumento = iTextSharp.text.Image.GetInstance(new Uri("http://servidor/instrumental/Content/themes/AdminTemplate/img/TRIPE.png"));
            logoInstrumento.SetAbsolutePosition(doc.PageSize.Width - 520f - 72f, doc.PageSize.Height - 1f - 70f);
            logoInstrumento.ScaleAbsoluteWidth(29);
            logoInstrumento.ScaleAbsoluteHeight(60);
            iTextSharp.text.pdf.draw.LineSeparator line1 = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_LEFT, 5);
            doc.Add(new Paragraph("\n")); doc.Add(new Paragraph("\n")); doc.Add(new Paragraph("\n")); doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("             NUMERO DE SOLICITUD: " + lblFolio.Text, MyFontNaranja));
            //se agregan los logos
            doc.Add(logoInstrumento);
            doc.Add(logofacite);
            doc.Add(logouasderecha);
            doc.Add(logocentro);
            doc.Add(new Chunk(line1));
            doc.Add(new Paragraph("                               SOLICITUD DE EQUIPO PARA PRÁCTICAS ACADÉMICAS", MyFontVerde));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("                   GRUPO: " + cmbGrupoBrigada.Text + "      BRIGADA: " + cmbBrigada.SelectedItem.Text, MyFontNormal));
            doc.Add(new Paragraph("\n"));
            //AGREGANDO LA TABLA DE BRIGADA
            //Create a table
            PdfPTable table = new PdfPTable(GridView2.Columns.Count);
            PdfPCell header = new PdfPCell(new Phrase("INTEGRANTES DE LA BRIGADA", MyFontNaranja));
            header.Colspan = GridView2.Columns.Count;
            header.Border = 0;
            header.HorizontalAlignment = 1;
            table.AddCell(header);
            //Set the column widths
            int[] widths = new int[GridView2.Columns.Count];
            for (int x = 0; x < GridView2.Columns.Count; x++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(GridView2.HeaderRow.Cells[x].Text, FontFactory.GetFont("Calibri",   // fuente
                8, BaseColor.BLACK                            // tamaño
                )));
                cell.BackgroundColor = new BaseColor(41, 213, 162);
                cell.Border = 0;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
            }

            //Transfer rows from GridView to table
            for (int i = 0; i < GridView2.Rows.Count; i++)
            {
                if (GridView2.Rows[i].RowType == DataControlRowType.DataRow)
                {
                    for (int j = 0; j < GridView2.Columns.Count; j++)
                    {
                        if (j == GridView2.Columns.Count - 1)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase("      "));
                            cell.Border = 1;
                            cell.BorderColor = BaseColor.LIGHT_GRAY;
                            cell.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER;
                            cell.BorderWidthBottom = 1f;
                            cell.BorderWidthTop = 0f;
                            cell.PaddingBottom = 10f;
                            cell.PaddingLeft = 20f;
                            cell.PaddingTop = 5f;
                            cell.HorizontalAlignment = 1;
                            table.AddCell(cell);

                        }
                        else
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(GridView2.Rows[i].Cells[j].Text, FontFactory.GetFont("Calibri",   // fuente
                8, BaseColor.DARK_GRAY                            // tamaño
                )));
                            cell.Border = 1;
                            cell.BorderColor = new BaseColor(41, 213, 162);
                            cell.BorderColor = BaseColor.LIGHT_GRAY;
                            cell.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER;
                            cell.BorderWidthBottom = 1f;
                            cell.BorderWidthTop = 0f;
                            cell.PaddingBottom = 10f;
                            cell.PaddingLeft = 20f;
                            cell.PaddingTop = 5f;
                            cell.HorizontalAlignment = 1;
                            table.AddCell(cell);
                        }
                    }
                }
            }

            doc.Add(table);

            doc.Add(new Paragraph("\n"));
            //AGREGANDO LA TABLA DE EQUIPOS
            //Create a table
            PdfPTable tableEquipos = new PdfPTable(GridView1.Columns.Count - 1);
            PdfPCell headerEquipos = new PdfPCell(new Phrase("EQUIPO SOLICITADO", MyFontNaranja));
            headerEquipos.Colspan = GridView1.Columns.Count;
            headerEquipos.Border = 0;
            headerEquipos.HorizontalAlignment = 1;
            tableEquipos.AddCell(headerEquipos);
            //Set the column widths
            int[] widths2 = new int[GridView1.Columns.Count];
            for (int x = 0; x < GridView1.Columns.Count - 1; x++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(GridView1.HeaderRow.Cells[x].Text, FontFactory.GetFont("Calibri",   // fuente
                8, BaseColor.BLACK                            // tamaño
                )));
                cell.BackgroundColor = new BaseColor(41, 213, 162);
                cell.Border = 0;
                cell.HorizontalAlignment = 1;
                tableEquipos.AddCell(cell);
            }

            //Transfer rows from GridView to table
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (GridView1.Rows[i].RowType == DataControlRowType.DataRow)
                {
                    for (int j = 0; j < GridView1.Columns.Count - 1; j++)
                    {
                        if (j == GridView1.Columns.Count - 1)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase("      "));
                            cell.Border = 1;
                            cell.BorderColor = BaseColor.LIGHT_GRAY;
                            cell.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER;
                            cell.BorderWidthBottom = 1f;
                            cell.BorderWidthTop = 0f;
                            cell.PaddingBottom = 10f;
                            cell.PaddingLeft = 20f;
                            cell.PaddingTop = 5f;
                            cell.HorizontalAlignment = 1;
                            tableEquipos.AddCell(cell);

                        }
                        else
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(GridView1.Rows[i].Cells[j].Text, FontFactory.GetFont("Calibri",   // fuente
                8, BaseColor.DARK_GRAY                            // tamaño
                )));
                            cell.Border = 1;
                            cell.BorderColor = new BaseColor(41, 213, 162);
                            cell.BorderColor = BaseColor.LIGHT_GRAY;
                            cell.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER;
                            cell.BorderWidthBottom = 1f;
                            cell.BorderWidthTop = 0f;
                            cell.PaddingBottom = 10f;
                            cell.PaddingLeft = 20f;
                            cell.PaddingTop = 5f;
                            cell.HorizontalAlignment = 1;
                            tableEquipos.AddCell(cell);
                        }
                    }
                }
            }

            doc.Add(tableEquipos);
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("             FECHA: " + cmbDia.Text + " de " + cmbMes.SelectedItem.Text + " del " + cmbAño.Text + ".   HORA DE SALIDA: ________   HORA DE ENTREGA: ________", MyFontNormal));
            doc.Add(new Paragraph("             PRÁCTICA: " + cmbPractica.SelectedItem.Text, MyFontNormal));
            doc.Add(new Paragraph("             MAESTRO RESPONSABLE: " + cmbMaestros.SelectedItem.Text, MyFontNormal));
            doc.Add(new Paragraph("\n")); doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("                                           _____________________________________________________________", MyFontNormal));
            doc.Add(new Paragraph("                                             NOMBRE Y FIRMA DE CONFORMIDAD DE RECEPCIÓN DE EQUIPO", MyFontNormal));
            doc.Close();

            //Process.Start(path);
            Response.Redirect("\\instrumental\\SolicitudesPDF\\Solicitud" + lblFolio.Text + ".pdf");
        }


        protected void cmbGrupoBrigada_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPractica.DataBind();
        }

        protected void cmbMaestros_TextChanged(object sender, EventArgs e)
        {
            cmbPractica.DataBind();
        }

        protected void cmbSemestre_TextChanged(object sender, EventArgs e)
        {
            cmbPractica.DataBind();
        }

        protected void cmbGrupoBrigada_TextChanged(object sender, EventArgs e)
        {
            cmbPractica.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            string cod_equipo = GridView1.DataKeys[row.RowIndex].Value.ToString();
            AccesoLogica negocio = new AccesoLogica();
            negocio.QuitarEquipos(int.Parse(cod_equipo));
            GridView1.DataBind();
            MessageBox("Equipo Eliminado Correctamente");
            negocio = null;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoLogica negocio = new AccesoLogica();
                negocio.EliminarSolicitud(int.Parse(lblFolio.Text));
                Response.Redirect("http://geodesia.uas.edu.mx");
            }
            catch (Exception er)
            {
                MessageBox("Error: " + er.Message);
            }
        }
    }
}