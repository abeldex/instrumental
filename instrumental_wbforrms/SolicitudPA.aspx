<%@ Page Title="" Language="C#" MasterPageFile="~/flat.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="SolicitudPA.aspx.cs" Inherits="instrumental_wbforrms.solicitud_equipo" %>
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
                      <aside class="profile-nav alt green-border">
                          <section class="panel">
                              <div class="user-heading alt green-bg">
                                  <a href="#">
                                      <img alt="" src="Content/themes/flat/img/pacad.png">
                                  </a>
                                  <h1>Prácticas Académicas</h1>
                                  <p>Módulo</p>
                              </div>
                      <section class="panel">
                          <header class="panel-heading">
                              <center><b>SOLICITUD DE EQUIPO PARA PRÁCTICAS ACADÉMICAS</b></center>
                          </header>
                          <div class="panel-body">
                               <!--DIV DEL FOLIO-->
        <div>
            <h4 style="color:#ff6a00">Numero Solicitud:   <asp:Label ID="Label1" runat="server" Text="#"></asp:Label></h4>
            <h4 style="color:#ff6a00">Turno:   <asp:Label ID="lblTurno" runat="server" Text="__"></asp:Label></h4>
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
                                                <button class="btn btn-primary" type="button"><i class="icon-calendar"></i></button>
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
                                              &nbsp&nbsp&nbsp&nbsp<img alt="" width="40px" src="Content/themes/theme_up/css/images/1379011746_schedule.png" /> <asp:Button ID="btnTurno" runat="server" Text="Obtener Turno" CssClass="btn btn-shadow btn-primary" OnClick="btnTurno_Click"/>
                                          </div>
                                      </div>
                                     
                                  </fieldset>
                                  <!--PASO 2-->
                                  <fieldset title="Paso 2: MI BRIGADA" class="step" id="paso2" runat="server">
                                      <legend> </legend>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Seleccione su grupo:</label>
                                          <div class="col-lg-10">
                                              <asp:DropDownList ID="cmbGrupoBrigada" runat="server" DataSourceID="SqlDataSourceGrupoBrigada" AutoPostBack="True" DataTextField="GRUPO" DataValueField="GRUPO" CssClass="btn btn-white dropdown-toggle" OnSelectedIndexChanged="cmbGrupoBrigada_SelectedIndexChanged" OnTextChanged="cmbGrupoBrigada_TextChanged" Width="200px"></asp:DropDownList>
                                              <asp:SqlDataSource ID="SqlDataSourceGrupoBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT DISTINCT bri_grupo AS GRUPO, bri_semestre AS SEMESTRE FROM brigada where bri_tipo = 'PA' ORDER BY GRUPO"> </asp:SqlDataSource>
                                          </div>
                                      </div>
                                      <br /><br /><br />
                                        <div class="form-group">
                                          <label class="col-lg-2 control-label">Semestre actual:</label>
                                          <div class="col-lg-10">
                                      <asp:DropDownList ID="cmbSemestre" runat="server" DataSourceID="SqlDataSourceSemestre" DataTextField="bri_semestre" DataValueField="bri_semestre" AutoPostBack="True" Enabled="False" CssClass="btn btn-white dropdown-toggle" Width="200px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceSemestre" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT DISTINCT [bri_semestre] FROM [brigada] WHERE ([bri_grupo] = @bri_grupo)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cmbGrupoBrigada" Name="bri_grupo" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                                          </div>
                                      </div>
                                      <br /><br />
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Seleccione su Brigada:</label>
                                          <div class="col-lg-10">
                                              <asp:DropDownList ID="cmbBrigada" runat="server" DataSourceID="SqlDataSourceBrigada" DataTextField="bri_nombre" DataValueField="bri_codigo" AutoPostBack="True" CssClass="btn btn-white dropdown-toggle" Width="200px"></asp:DropDownList>
                                              <asp:SqlDataSource ID="SqlDataSourceBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [brigada] WHERE ([bri_grupo] = @bri_grupo)">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbGrupoBrigada" Name="bri_grupo" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
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
                                          <asp:Button ID="btnSeleccionarFechayTurno" runat="server" Text="Atras" CssClass="btn btn-shadow btn-primary" OnClick="btnSeleccionarFechayTurno_Click" />
                                              
                                          <asp:Button ID="btnElegirPractica" runat="server" Text="Seleccionar Práctica" CssClass="btn btn-shadow btn-primary" OnClick="btnElegirPractica_Click"/>
                                              
                                              </center>
                                          </div>
                                  </fieldset>
                                    <!--/PASO 2-->
                                     <fieldset title="Paso 3: PROFESOR Y PRÁCTICA" class="step" id="paso3" runat="server">
                                      <legend> </legend>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Seleccione un Profesor:</label>
                                          <div class="col-lg-10">
                                              <asp:DropDownList ID="cmbMaestros" runat="server" AutoPostBack="True" CssClass="btn btn-white dropdown-toggle" DataSourceID="SqlDataSourceMAestros" DataTextField="profesor_nombre" DataValueField="profesor_codigo" Width="100%">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceMAestros" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [profesor]"></asp:SqlDataSource>
                                          
                                          </div>
                                      </div>
                                         <br /><br /><br />
                                         <div class="form-group">
                                          <label class="col-lg-2 control-label">Seleccione una Práctica:</label>
                                          <div class="col-lg-10">
                                               <asp:DropDownList ID="cmbPractica" runat="server" AutoPostBack="True"  DataSourceID="SqlDataSourcePracticas" DataTextField="PRACTICA" DataValueField="practica_codigo" Width="100%" CssClass="btn btn-white dropdown-toggle">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourcePracticas" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practica_profesor" SelectCommandType="StoredProcedure">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cmbMaestros" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
                                <asp:ControlParameter ControlID="cmbSemestre" Name="semestre" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                                              </div>
                                             </div>
                                           <br /><br />
                                      <div class="form-group">
                                          <center>
                                          
                                          <asp:CheckBox ID="CheckBox2" runat="server" Text="Confirmar que todos los datos que selecciono son correctos." />
                                          <asp:Button ID="btnSeleccionarBrigada" runat="server" Text="Atras" CssClass="btn btn-shadow btn-primary" OnClick="btnSeleccionarBrigada_Click" />
                                         <a href="#myModal" data-toggle="modal" class="btn btn-shadow btn-primary">
                                  Seleccionar Equipos
                              </a>         
                                              </center>
                                          </div>
                                      </fieldset>
                                   <fieldset title="Paso 4: SELECCIONAR LOS EQUIPOS" class="step" id="paso4" runat="server">
                                      <legend> </legend>
                                      <div class="form-group">
                                          <label class="col-lg-2 control-label">Seleccionar Equipos:</label>
                                          <div class="col-lg-10">
                                               <asp:DropDownList ID="cmbSolicitudNumero0" runat="server" CssClass="btn btn-shadow btn-info" DataSourceID="SqlDataSourceObtenerUltimaSolicitud" DataTextField="FOLIO" DataValueField="FOLIO" Visible="False">
                        </asp:DropDownList>
                                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT IDENT_CURRENT('solicitud') AS FOLIO"></asp:SqlDataSource>
                                          <asp:DropDownList ID="cmbEquipos" runat="server" AutoPostBack="True" CssClass="btn btn-white dropdown-toggle" DataSourceID="SqlDataSourceEquiposPorPractica" DataTextField="EQUIPO" DataValueField="CODIGO">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceEquiposPorPractica" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_equipos_por_practica" SelectCommandType="StoredProcedure">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cmbPractica" Name="practica" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                                          </div>
                                      </div>
                                      
                                         <br /><br /><br />
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
 
                                          <asp:Button ID="btnCancelarSolicitud" runat="server" Text="Cancelar Solicitud" CssClass="btn btn-shadow btn-primary" OnClick="btnCancelarSolicitud_Click" />
                                              
                                          <asp:Button ID="btnEnviarSolicitud" runat="server" Text="Enviar Solicitud" CssClass="btn btn-shadow btn-primary" OnClick="btnEnviarSolicitud_Click"/>
                                              
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
                                      <div aria-hidden="true" aria-labelledby="myModalLabel" role="dialog" tabindex="-1" id="myModal" class="modal fade">
                                  <div class="modal-dialog">
                                      <div class="modal-content">
                                          <div class="modal-header">
                                              <button aria-hidden="true" data-dismiss="modal" class="close" type="button">×</button>
                                              <h4 class="modal-title">¡AVISO IMPORTANTE!</h4>
                                          </div>
                                          <div class="modal-body">
                                                <h4 class="modal-title">CANCELE LA SOLICITUD EN LOS SIGUIENTES CASOS:</h4>
                                                <h5>- No aparecen equipos para seleccionar.</h5>
                                                <h5>- Los equipos no se agregan.<h5>
                                                <h5>- Quiere volver a empezar una nueva solicitud.</h5> 
                                                    <br />
                                                    <h5><i>Cualquier duda consultar al encargado del Centro de Cómputo</i></h5> 

                                            <asp:Button ID="btnSeleccionarEquipos" runat="server" Text="Continuar" CssClass="btn btn-shadow btn-primary" OnClick="btnSeleccionarEquipos_Click"/>
                                          </div>
                                      </div>
                                  </div>
                              </div>                                
                               </form>
                               
                          </div>
                      </section>

                          </section>
                      </aside>
                  </div> 
              </div>
     
              <!-- page end-->  
</asp:Content>
