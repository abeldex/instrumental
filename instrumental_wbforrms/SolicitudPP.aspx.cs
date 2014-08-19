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
    public partial class SolicitudPP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                paso2.Visible = false;
                paso4.Visible = false;
                paso5.Visible = false;
               
            }
        }

        protected void btnTurno_Click(object sender, EventArgs e)
        {
            try
            {
                int turno = int.Parse(AccesoLogica.ObtenerUltimoTurno(lblFecha.Value).Rows[0][0].ToString());
                lblTurno.Text = turno.ToString();
                paso1.Visible = false;
                paso2.Visible = true;
            }
            catch (Exception er)
            {
                MessageBox(er.Message);
            }
        }

        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }



        protected void btnSeleccionarFechayTurno_Click(object sender, EventArgs e)
        {
            paso1.Visible = true;
            paso2.Visible = false;

        }

        protected void btnElegirPractica_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {

                try
                {
                    Agregar(sender, e);
                    btnElegirPractica.Enabled = false;
                    txtCantidad.Text = "1";
                }
                catch (Exception er)
                {
                    MessageBox("No se ha seleccionado un TURNO. Haga Clic en el boton en forma de calendario.");
                }
                paso2.Visible = false;
                paso4.Visible = true;
            }

            else
            {
                MessageBox("Confirme los datos que selecciono para poder continuar.");
            }

        }


        protected void btnSeleccionarBrigada_Click(object sender, EventArgs e)
        {
            paso2.Visible = true;
        }

        protected void btnSeleccionarEquipos_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                paso4.Visible = true;
            }
            else
            {
                MessageBox("Confirme los datos que selecciono para poder continuar.");
            }
        }

        protected void Agregar(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            string fecha = lblFecha.Value;
            int i = int.Parse(AccesoLogica.ObtenerFolio().Rows[0][0].ToString());
            i++;
            Label1.Text = i.ToString();
            int brigada = int.Parse(cmbBrigada.SelectedValue.ToString());
            int turno = int.Parse(AccesoLogica.ObtenerUltimoTurno(lblFecha.Value).Rows[0][0].ToString());
            lblTurno.Text = turno.ToString();
            int resultado = negocio.INSERTAR_Solicitud(brigada, fecha, DateTime.Now.ToString("hh:mm"), "00:00", 135, 0, true, turno);
            negocio = null;
            btnTurno.Enabled = false;
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
            try
            {
                int sol_numero = int.Parse(Label1.Text);
                int equipo_cod = int.Parse(cmbEquipos.SelectedValue.ToString());
                int cantidad = int.Parse(txtCantidad.Text);
                AccesoLogica negocio = new AccesoLogica();
                int resultado = negocio.INSERTAR_Solicitud_detalle(sol_numero, equipo_cod, cantidad);
                negocio = null;
            }
            catch (Exception err)
            {
                MessageBox(err.Message);
            }
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            string cod_equipo = GridView1.DataKeys[row.RowIndex].Value.ToString();
            AccesoLogica negocio = new AccesoLogica();
            negocio.QuitarEquipos(int.Parse(cod_equipo));
            GridView1.DataBind();
            negocio = null;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
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

        protected void btnCancelarSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoLogica negocio = new AccesoLogica();
                negocio.EliminarSolicitud(int.Parse(Label1.Text));
                Response.Redirect("http://geodesia.uas.edu.mx");
            }
            catch (Exception er)
            {
                MessageBox("Error: " + er.Message);
            }
        }

        protected void btnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            //System.Web.Exception opcional para manejar datos de respuesta HTTP a un cliente
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            //Para crear una instancia de documento de iTextSharp con el tamaño de página y tamaño de margenes correspondientes
            Document doc = new Document(PageSize.LETTER, 10, 10, 10, 10);
            //La ruta en donde será guardado el pdf dentro del servidor
            String path = this.Server.MapPath(".") + "\\SolicitudesPDF\\Solicitud" + Label1.Text + ".pdf";


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
            doc.Add(new Paragraph("             NUMERO DE SOLICITUD: " + Label1.Text, MyFontNaranja));
            //se agregan los logos
            doc.Add(logoInstrumento);
            doc.Add(logofacite);
            doc.Add(logouasderecha);
            doc.Add(logocentro);
            doc.Add(new Chunk(line1));
            doc.Add(new Paragraph("                               SOLICITUD DE EQUIPO PARA PRÁCTICAS ACADÉMICAS", MyFontVerde));
            doc.Add(new Paragraph("\n"));
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
            doc.Add(new Paragraph("             FECHA: " + lblFecha.Value + ".   HORA DE SALIDA: ________   HORA DE ENTREGA: ________", MyFontNormal));
            doc.Add(new Paragraph("\n")); doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("                                           _____________________________________________________________", MyFontNormal));
            doc.Add(new Paragraph("                                             NOMBRE Y FIRMA DE CONFORMIDAD DE RECEPCIÓN DE EQUIPO", MyFontNormal));
            doc.Close();

            //Process.Start(path);
            MessageBox("La solicitud se ha enviado correctamente");
            Response.Redirect("\\instrumental\\SolicitudesPDF\\Solicitud" + Label1.Text + ".pdf");
        }

        protected void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEquipos.DataBind();
        }
    }
}