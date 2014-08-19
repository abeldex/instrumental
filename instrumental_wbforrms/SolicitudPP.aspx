<%@ Page Title="" Language="C#" MasterPageFile="~/flat.Master" AutoEventWireup="true" CodeBehind="SolicitudPP.aspx.cs" Inherits="instrumental_wbforrms.SolicitudPP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="Content/themes/flat/assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <!-- Custom styles for this template -->
    <link href="Content/themes/flat/css/style.css" rel="stylesheet">
    <link href="Content/themes/flat/css/style-responsive.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/bootstrap-fileupload/bootstrap-fileupload.css" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/bootstrap-wysihtml5/bootstrap-wysihtml5.css" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/bootstrap-datepicker/css/datepicker.css" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/bootstrap-timepicker/compiled/timepicker.css" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/bootstrap-colorpicker/css/colorpicker.css" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/bootstrap-daterangepicker/daterangepicker-bs3.css" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/bootstrap-datetimepicker/css/datetimepicker.css" />
    <link rel="stylesheet" type="text/css" href="Content/themes/flat/assets/jquery-multi-select/css/multi-select.css" />
    <div class="row">
                            
                  <div class="col-lg-12">
                     <aside class="profile-nav alt blue-border">
                          <section class="panel">
                              <div class="user-heading alt blue-bg">
                                  <a href="#">
                                      <img alt="" src="Content/themes/flat/img/practpro.png">
                                  </a>
                                  <h1>Prácticas Profesionales</h1>
                                  <p>Módulo</p>
                              </div>
                      <section class="panel">
                          <header class="panel-heading">
                              <center><b>SOLICITUD DE EQUIPO PARA PRÁCTICAS PROFESIONALES</b></center>
                          </header>
                          <div class="panel-body">
                               <!--DIV DEL FOLIO-->
        <div>
            <h4 style="color:#0094ff">Numero Solicitud:   <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h4>
            <h4 style="color:#0094ff">Turno:   <asp:Label ID="lblTurno" runat="server" Text="__"></asp:Label></h4>
            <br />
            
            <asp:SqlDataSource ID="SqlDataSourceObtenerUltimaSolicitud" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT IDENT_CURRENT('solicitud') AS FOLIO"></asp:SqlDataSource>       
            <asp:SqlDataSource ID="SqlDataSourceTurno" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_turno" SelectCommandType="StoredProcedure">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="lblFecha" Name="fecha" PropertyName="Value" />
                     </SelectParameters>
                 </asp:SqlDataSource>
        </div>
                              
        <!--/DIV DEL FOLIO-->

                              <div class="stepy-tab" >
                                  <ul id="default-titles" class="stepy-titles clearfix" >
                                      <li id="lpaso1" class="current-step" runat="server" >
                                          <div>Paso 1</div>
                                      </li>
                                      <li id="lpaso2" class="" runat="server">
                                          <div>Paso 2</div>
                                      </li>
                                      <li id="lpaso3" class="" runat="server">
                                          <div>Paso 3</div>
                                      </li>
                                  </ul>
                              </div>
                               <form id="default" runat="server">
                                  <fieldset title="Paso 1: FECHA Y TURNO" class="step" id="paso1" runat="server">
                                      <legend> </legend>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Fecha:</label>
                                          <div class="col-lg-10">
                                               <div class="form-group">
                                  <div class="col-md-3 col-xs-11">

                                      <div data-date-viewmode="years" data-date-format="dd-mm-yyyy" data-date="12-02-2012"  class="input-append date dpYears">

                                          <input type="text" value="12-02-2012" size="16" class="form-control" runat="server" id="lblFecha">
                                              <span class="input-group-btn add-on">
                                                <button class="btn btn-info" type="button"><i class="icon-calendar"></i></button>
                                              </span>
                                      </div>
                                      <span class="help-block"><i>Seleccione primero la fecha antes de obtener un turno</i></span>
                                  </div>
                              </div>
                                          </div>
                                      </div>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Obtener un Turno:</label>
                                          <div class="col-lg-10">
                                              &nbsp&nbsp&nbsp&nbsp<img alt="" width="40px" src="Content/themes/theme_up/css/images/1379011746_schedule.png" /> <asp:Button ID="btnTurno" runat="server" Text="Obtener Turno" CssClass="btn btn-shadow btn-info" OnClick="btnTurno_Click"/>
                                          </div>
                                      </div>
                                     
                                  </fieldset>
                                  <!--PASO 2-->
                                  <fieldset title="Paso 2: MI BRIGADA" class="step" id="paso2" runat="server">
                                      <legend> </legend>
                                   
                                       
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Seleccione su Brigada:</label>
                                          <div class="col-lg-10">
                                              <asp:DropDownList ID="cmbBrigada" runat="server" DataSourceID="SqlDataSourceBrigada" DataTextField="bri_nombre" DataValueField="bri_codigo" AutoPostBack="True" CssClass="btn btn-white dropdown-toggle" Width="200px"></asp:DropDownList>
                                              <asp:SqlDataSource ID="SqlDataSourceBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [brigada] WHERE bri_tipo = 'PP'"></asp:SqlDataSource>
                                          </div>
                                      </div>
                                      <br /><br />
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Integrantes su Brigada:</label>
                                          <div class="col-lg-10">

                                              <section class="panel">                    
                                              <header class="panel-heading">
                          Datos
                          </header>
                                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="CUENTA" DataSourceID="SqlDataSourceAlumnosPorBrigada" CssClass="table table-striped" GridLines="None">
                    <Columns>
                        <asp:BoundField DataField="CUENTA" HeaderText="CUENTA" ReadOnly="True" SortExpression="CUENTA" />
                        <asp:BoundField DataField="INTEGRANTES" HeaderText="NOMBRE" SortExpression="INTEGRANTES" />
                        <asp:BoundField DataField="CELULAR" HeaderText="CELULAR" SortExpression="CELULAR" />
                        <asp:TemplateField FooterText="_____________________________" HeaderText="FIRMAS"></asp:TemplateField>
                    </Columns>
                                                    <SelectedRowStyle CssClass="table table-striped" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSourceAlumnosPorBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT al_cuenta as CUENTA, al_nombre AS INTEGRANTES, al_telefono as CELULAR FROM alumno WHERE (bri_codigo = @bri_codigo)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="cmbBrigada" Name="bri_codigo" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>  

                                              </section>
                                          </div>
                                      </div>
                                      <br /><br />
                                      <div class="form-group">
                                          <center>
                                          
                                          <asp:CheckBox ID="CheckBox1" runat="server" Text="Confirmar que todos los datos que selecciono son correctos." />
                                          <asp:Button ID="btnSeleccionarFechayTurno" runat="server" Text="Atras" CssClass="btn btn-shadow btn-info" OnClick="btnSeleccionarFechayTurno_Click" />
                                              
                                          <asp:Button ID="btnElegirPractica" runat="server" Text="Seleccionar Equipos" CssClass="btn btn-shadow btn-info" OnClick="btnElegirPractica_Click"/>
                                              
                                              </center>
                                          </div>
                                  </fieldset>
                                 
                                      
                                   <fieldset title="Paso 4: SELECCIONAR LOS EQUIPOS" class="step" id="paso4" runat="server">
                                      <legend> </legend>
                                          <div class="form-group">
                                          <label class="col-lg-2 control-label">Categoria:</label>
                                              
                                          <div class="col-lg-10">
                                               <asp:SqlDataSource ID="SqlDataSourceCategoriaEquipos" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [equipo_tipo]"></asp:SqlDataSource>
                                                   <asp:DropDownList ID="cmbCategorias" CssClass="btn btn-white dropdown-toggle"  runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceCategoriaEquipos" DataTextField="eq_tipo_nombre" DataValueField="eq_tipo_codigo" OnSelectedIndexChanged="cmbCategorias_SelectedIndexChanged"></asp:DropDownList>
                                              
                  
                                           </div>
                                     </div><br />
                                      
                                              <div class="form-group">
                                          <label class="col-lg-2 control-label">Equipos:</label>
                                          <div class="col-lg-10">
                                               <asp:DropDownList ID="cmbSolicitudNumero0" runat="server" CssClass="btn btn-shadow btn-info" DataSourceID="SqlDataSourceObtenerUltimaSolicitud" DataTextField="FOLIO" DataValueField="FOLIO" Visible="False">
                        </asp:DropDownList>
                                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT IDENT_CURRENT('solicitud') AS FOLIO"></asp:SqlDataSource>
                                              
                                              <asp:DropDownList ID="cmbEquipos" runat="server" CssClass="btn btn-white dropdown-toggle" DataSourceID="SqlDataSourceEquiposPorPractica" DataTextField="eq_nombre" DataValueField="eq_codigo">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceEquiposPorPractica" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [equipo] WHERE ([eq_tipo_codigo] = @eq_tipo_codigo)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cmbCategorias" Name="eq_tipo_codigo" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                                          </div>
                                      </div>
                                         <br /><br />
                                          <div class="form-group">
                                          <label class="col-lg-2 control-label">Cantidad:</label>
                                          <div class="col-lg-10">
                                                  <asp:TextBox ID="txtCantidad" runat="server" Width="50px" CssClass="form-control" Text="1"></asp:TextBox>
          
                                                <br />
                                                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="100px" CssClass="btn btn-shadow btn-success" OnClick="btnAgregar_Click" />
                                                <br />
                                           </div>
                                     </div><br />
                                                 <div class="form-group">
                                          <label class="col-lg-2 control-label">Equipos Solicitados:</label>
                                          <div class="col-lg-10">
                                                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDetalleSolicitud" Width="100%" CssClass="table table-striped table-bordered" DataKeyNames="ID" GridLines="None">
                    <Columns>
                        <asp:BoundField DataField="SERIE" HeaderText="SERIE" SortExpression="SERIE" />
                        <asp:BoundField DataField="NOMBRE" SortExpression="NOMBRE" HeaderText="NOMBRE" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SOLCITADO" SortExpression="SOLCITADO" HeaderText="SOLCITADO" >
                        </asp:BoundField>
                          <asp:TemplateField HeaderText="ELIMINAR">
                             <ItemTemplate><center>
                                 <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Images/delete.png" ToolTip="Quitar Equipo" OnClick="ImageButton1_Click" />
    
                             </ItemTemplate>
                         </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSourceDetalleSolicitud" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_detalle_solicitud" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="Label1" Name="codigo" PropertyName="Text" Type="Int32" DefaultValue="" />
                    </SelectParameters>
                </asp:SqlDataSource>
                                           </div>
                                     </div>
                                        <div class="form-group">
                                          <center>
 
                                          <asp:Button ID="btnCancelarSolicitud" runat="server" Text="Cancelar Solicitud" CssClass="btn btn-shadow btn-info" OnClick="btnCancelarSolicitud_Click" />
                                              
                                          <asp:Button ID="btnEnviarSolicitud" runat="server" Text="Enviar Solicitud" CssClass="btn btn-shadow btn-info" OnClick="btnEnviarSolicitud_Click"/>
                                              
                                              </center>
                                          </div>
                                             
                                           <br /><br />
                                     
                                      </fieldset>

                                  <fieldset title="Paso 5" class="step" id="paso5" runat="server">
                                      <legend> </legend>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Full Name-label">Full Name</label>
                                          <div class="col-lg-10">
                                              <p class="form-control-static">Tawseef Ahmed</p>
                                          </div>
                                      </div>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Email Address</label>
                                          <div class="col-lg-10">
                                              <p class="form-control-static">tawseef@vectorlab.com</p>
                                          </div>
                                      </div>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">User Name</label>
                                          <div class="col-lg-10">
                                              <p class="form-control-static">tawseef</p>
                                          </div>
                                      </div>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Phone</label>
                                          <div class="col-lg-10">
                                              <p class="form-control-static">01234567</p>
                                          </div>
                                      </div>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Mobile</label>
                                          <div class="col-lg-10">
                                              <p class="form-control-static">01234567</p>
                                          </div>
                                      </div>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Address</label>
                                          <div class="col-lg-10">
                                              <p class="form-control-static">
                                                  Dreamland Ave, Suite 73
                                                  AU, PC 1361
                                                  P: (123) 456-7891 </p>
                                          </div>
                                      </div>
                                  </fieldset>&nbsp;
                                                                     
                               </form>
                               
                          </div>
                      </section>

                          </section>
                      </aside>
                  </div> 
              </div>
              <!-- page end-->  
</asp:Content>
