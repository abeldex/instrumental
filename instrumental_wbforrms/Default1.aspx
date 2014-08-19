<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="instrumental_wbforrms.Solicitud" %>
<asp:Content ID="menu1" ContentPlaceHolderID="menu" runat="server">
     <div class="subnavbar">
                  <div class="subnavbar-inner">
                    <div class="container">
                      <ul class="mainnav">
                          <li class="active"><a href="Default.aspx"><i class="icon-list-alt"></i><span>Solicitud de Equipos</span> </a> </li>                          
                        <li><a href="Administracion.aspx"><i class="icon-cogs"></i><span>Administrador</span> </a> </li>
                        <!--<li><a href="guidely.html"><i class="icon-facetime-video"></i><span>App Tour</span> </a></!--li>
                        <li><a href="charts.html"><i class="icon-bar-chart"></i><span>Charts</span> </a> </li>
                        <li><a href="shortcodes.html"><i class="icon-code"></i><span>Shortcodes</span> </a> </li>
                        <li class="dropdown"><a href="javascript:;" class="dropdown-toggle" data-toggle="dropdown"> <i class="icon-long-arrow-down"></i><span>Drops</span> <b class="caret"></b></a>
                          <ul class="dropdown-menu">
                            <li><a href="icons.html">Icons</a></li>
                            <li><a href="faq.html">FAQ</a></li>
                            <li><a href="pricing.html">Pricing Plans</a></li>
                            <li><a href="login.html">Login</a></li>
                            <li><a href="signup.html">Signup</a></li>
                            <li><a href="error.html">404</a></li>
                          </ul>
                        </li>-->
                      </ul>
                          <div class="nav pull-right">
                             <asp:LoginView ID="LoginView1" runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                            <i class="icon-signin"></i>&nbsp;&nbsp;<a id="A2" runat="server" href="~/Login.aspx">Iniciar sesión</a><br />
                               <i class="icon-pencil"></i>&nbsp;&nbsp; <a id="A1" runat="server" href="~/Account/Register.aspx">Registrarse</a>
                        </AnonymousTemplate>
                        <LoggedInTemplate>
                            <p><br />
                                usuario: <i class="icon-user"></i><a id="A3" runat="server" class="" href="~/Account/Manage.aspx" title="Cambiar Contraseña">
                                    <asp:LoginName ID="LoginName2" runat="server" CssClass="dropdown" /></a> | 
                                <asp:LoginStatus ID="LoginStatus2" runat="server" LogoutAction="Redirect" LogoutText="Salir" LogoutPageUrl="http://servidor/" /><i class="icon-share-alt"></i>
                            </p>
                        </LoggedInTemplate>
                    </asp:LoginView>
                            </div> 
                    </div>
                    <!-- /container --> 
                  </div>
                  <!-- /subnavbar-inner --> 
                </div>
                <!-- /subnavbar -->
                       
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>            
    <div style="text-align:center;">
       &nbsp;<!--ENCABEZADO DE LA SOLICITUD--><h3 style="color:#1eb265">SOLICITUD DE EQUIPO PARA PRÁCTICAS ACADÉMICAS</h3>
        </div>
      <!--DIV DEL FOLIO-->
        <div>
            <h3 style="color:#ff6a00">Numero Solicitud:  <asp:Label ID="lblFolio" runat="server" Text="" Font-Bold="true" Font-Size="Medium"></asp:Label></h3>
            <br />
            <asp:DropDownList ID="cmbSolicitudNumero" runat="server" DataSourceID="SqlDataSourceObtenerUltimaSolicitud" DataTextField="FOLIO" DataValueField="FOLIO" Visible="False" CssClass="drop-down-style"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSourceObtenerUltimaSolicitud" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT IDENT_CURRENT('solicitud') AS FOLIO"></asp:SqlDataSource>       
            <asp:SqlDataSource ID="SqlDataSourceTurno" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_turno" SelectCommandType="StoredProcedure">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="lblFecha" Name="fecha" PropertyName="Text" />
                     </SelectParameters>
                 </asp:SqlDataSource>
        </div>
        <!--/DIV DEL FOLIO-->
    <div class="row" id="imp">	      	
	      	
	      	<div class="span12">
	      		
	      		<div id="target-1" class="widget">
	      			
	      			<div class="widget-content" id="target-8">
	      				
			      		<h3>Datos Generales</h3><h4 style="float:right">
                       <!-- <img src="Content/themes/AdminTemplate/img/1382651183_print.png" style="width: 32px; height: 32px" /><asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Larger" OnClick="LinkButton1_Click">IMPRIMIR SOLICITUD</asp:LinkButton></h4>-->
			      		
			      		 Fecha de la Práctica : 
                <asp:DropDownList ID="cmbDia" runat="server" Width="70px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="cmbMes" runat="server" Width="120px">
                    <asp:ListItem Value="1">Enero</asp:ListItem>
                    <asp:ListItem Value="2">Febrero</asp:ListItem>
                    <asp:ListItem Value="3">Marzo</asp:ListItem>
                    <asp:ListItem Value="4">Abril</asp:ListItem>
                    <asp:ListItem Value="5">Mayo</asp:ListItem>
                    <asp:ListItem Value="6">Junio</asp:ListItem>
                    <asp:ListItem Value="7">Julio</asp:ListItem>
                    <asp:ListItem Value="8">Agosto</asp:ListItem>
                    <asp:ListItem Value="9">Septiembre</asp:ListItem>
                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                    <asp:ListItem Value="11">Noviembre</asp:ListItem>
                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="cmbAño" runat="server" Width="70px">
                    <asp:ListItem>2014</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;<asp:label runat="server" text="Obtener un Tuno:" ID="lblObtTurno"></asp:label>&nbsp;<asp:LinkButton ID="btnTurno" runat="server" OnClick="btnTurno_Click"><img alt="" width="40px" src="Content/themes/theme_up/css/images/1379011746_schedule.png" /></asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="cmbTurno" runat="server" Font-Bold="True" Font-Size="Large" CssClass="turno" DataSourceID="SqlDataSourceTurno" DataTextField="TURNO" DataValueField="TURNO" Visible="False">
                 </asp:DropDownList>
            <asp:Label ID="lblFecha" runat="server" Font-Bold="True" Font-Size="Medium" Visible="False"></asp:Label>
                &nbsp;<h3 style="color:#ff6a00">TURNO:&nbsp;
            <asp:Label ID="lblTurno" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label></h3>
			      		
		      		</div> <!-- /widget-content -->
		      		
	      		</div> <!-- /widget -->
	      		
      		</div> <!-- /span12 -->
      		
      		
      		
      		
      		 	
	      	
	      	<div class="span6">
	      		
	      		<div class="widget" id="DivGrupoBrigada" runat="server">
	      			
	      			<div class="widget-content" id="target-2">
	      				
			      		<h3>Grupo y Brigada</h3>
			      		
			      		 Grupo: <br /> <asp:DropDownList ID="cmbGrupoBrigada" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceGrupoBrigada" DataTextField="GRUPO" DataValueField="GRUPO" CssClass="drop-down-style" OnSelectedIndexChanged="cmbGrupoBrigada_SelectedIndexChanged" OnTextChanged="cmbGrupoBrigada_TextChanged"></asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:SqlDataSource ID="SqlDataSourceGrupoBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT DISTINCT bri_grupo AS GRUPO, bri_semestre AS SEMESTRE FROM brigada ORDER BY GRUPO">
                </asp:SqlDataSource>Semestre:<asp:DropDownList ID="cmbSemestre" runat="server" DataSourceID="SqlDataSourceSemestre" DataTextField="bri_semestre" DataValueField="bri_semestre" AutoPostBack="True" OnTextChanged="cmbSemestre_TextChanged">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceSemestre" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT DISTINCT [bri_semestre] FROM [brigada] WHERE ([bri_grupo] = @bri_grupo)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cmbGrupoBrigada" Name="bri_grupo" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <br />Brigada:
    <br /><asp:DropDownList ID="cmbBrigada" runat="server" DataSourceID="SqlDataSourceBrigada" DataTextField="bri_nombre" DataValueField="bri_codigo" OnSelectedIndexChanged="ActualizarNombres" AutoPostBack="True" CssClass="drop-down-style"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSourceBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [brigada] WHERE ([bri_grupo] = @bri_grupo)">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbGrupoBrigada" Name="bri_grupo" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
			      		
		      		    <h3>Profesor y Práctica</h3>
                        Profesor:<br />
                        <asp:DropDownList ID="cmbMaestros" runat="server" AutoPostBack="True" CssClass="drop-down-style" DataSourceID="SqlDataSourceMAestros" DataTextField="profesor_nombre" DataValueField="profesor_codigo" Width="300px" OnTextChanged="cmbMaestros_TextChanged">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceMAestros" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [profesor]"></asp:SqlDataSource>
                        <br />
                        Práctica:<br />
                        <asp:DropDownList ID="cmbPractica" runat="server" AutoPostBack="True" CssClass="drop-down-style" DataSourceID="SqlDataSourcePracticas" DataTextField="PRACTICA" DataValueField="practica_codigo">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourcePracticas" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practica_profesor" SelectCommandType="StoredProcedure">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cmbMaestros" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
                                <asp:ControlParameter ControlID="cmbSemestre" Name="semestre" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <br />
                        
                        <br />
			      		
		      		</div> <!-- /widget-content -->
		      		
	      		</div> <!-- /widget -->
	      		
      		</div> <!-- /span6 -->
      		 	
	      	
	      	<div class="span6" id="DivIntegrantesBrigada" runat="server">
	        <div class="widget">		
                <div class="widget-content">
			 <div class="widget widget-table action-table">
            <div class="widget-header" id="target-3"> <i class="icon-th-list"></i>
              <h3>Integrantes de la Brigada</h3>
            </div>
            <!-- /widget-header -->
            
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table" DataKeyNames="CUENTA" DataSourceID="SqlDataSourceAlumnosPorBrigada">
                    <Columns>
                        <asp:BoundField DataField="CUENTA" HeaderText="CUENTA" ReadOnly="True" SortExpression="CUENTA" />
                        <asp:BoundField DataField="INTEGRANTES" HeaderText="NOMBRE" SortExpression="INTEGRANTES" />
                        <asp:BoundField DataField="CELULAR" HeaderText="CELULAR" SortExpression="CELULAR" />
                        <asp:TemplateField FooterText="_____________________________" HeaderText="FIRMAS"></asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSourceAlumnosPorBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT al_cuenta as CUENTA, al_nombre AS INTEGRANTES, al_telefono as CELULAR FROM alumno WHERE (bri_codigo = @bri_codigo)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="cmbBrigada" Name="bri_codigo" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            
            <!-- /widget-content --> 
          </div>
			      		
		      		</div> <!-- /widget-content -->
		      		
	      		</div> 
	      		
      		</div>
            <!-- /span6 -->      	
	     
        <div class="span6" id="btnElegirEquipos" runat="server">      		
	      		<div class="widget" id="target-4">
	      			<div class="widget-content">
                        
                        <center><asp:Button ID="btnSeleccionarEquipos" runat="server" CssClass="button" Height="52px" OnClick="btnSeleccionarEquipos_Click" Text="Elegir Equipos" Width="204px" /></center>
                        
                     </div> <!-- /widget-content -->
	      		</div> <!-- /widget -->
      	</div> <!-- /span6 -->     	
         <div class="span6" id="DivSeleccionarEquipos" runat="server">      		
	      		<div class="widget" id="target-5">
	      			<div class="widget-content" id="divSelEquipos" runat="server">
                          
                        <h3>Seleccionar Equipos</h3>
                        <asp:DropDownList ID="cmbSolicitudNumero0" runat="server" CssClass="drop-down-style" DataSourceID="SqlDataSourceObtenerUltimaSolicitud" DataTextField="FOLIO" DataValueField="FOLIO" Visible="False">
                        </asp:DropDownList>
                        Equipos Disponibles:<asp:DropDownList ID="cmbEquipos" runat="server" AutoPostBack="True" CssClass="drop-down-style" DataSourceID="SqlDataSourceEquiposPorPractica" DataTextField="EQUIPO" DataValueField="CODIGO">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceEquiposPorPractica" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_equipos_por_practica" SelectCommandType="StoredProcedure">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cmbPractica" Name="practica" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        Cantidad:
                        <asp:TextBox ID="txtCantidad" runat="server" Width="50px"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click1" Text="Agregar" Width="100px" />
                        <br />
                          
                     </div> <!-- /widget-content -->
	      		</div> <!-- /widget -->
      	</div> <!-- /span6 -->

           <div class="span6">
	        <div class="widget" id="target-6"> 
             <div class="widget-content"  id="divSolEquipos" runat="server">		
			 <div class="widget widget-table action-table">
            <div class="widget-header"> <i class="icon-th-list"></i>
              <h3>Equipo Solicitado:</h3> 
            </div>
            <!-- /widget-header -->
           
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDetalleSolicitud" Width="100%" CssClass="table table-striped table-bordered" DataKeyNames="ID">
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
                        <asp:ControlParameter ControlID="cmbSolicitudNumero" Name="codigo" PropertyName="SelectedValue" Type="Int32" DefaultValue="" />
                    </SelectParameters>
                </asp:SqlDataSource>
            <!-- /widget-content --> 
          </div>
			      		
		      		</div> <!-- /widget-content -->
		      		
	      		</div> 
      		</div>
            <!-- /span6 --> 
        <div class="span12" id="DivBotonImprimir" runat="server">      		
	      		<div class="widget" id="target-7">
	      			<div class="widget-content">
                        
                        <center><asp:Button ID="btnCancelar" runat="server" Text="Cancelar Solicitud"  OnClick="btnCancelar_Click" Height="60px" Width="253px"/>
                            &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnTerminar" runat="server" Text="Enviar Solicitud"  OnClick="Button1_Click" Height="60px" Width="253px"/>
                            <br />
                        </center>   
                     </div> <!-- /widget-content -->
	      		</div> <!-- /widget -->
      	        
      	</div> <!-- /span6 --> 

         <script type="text/javascript">
             function printDiv(divID) {
                 //Get the HTML of div
                 var divElements = document.getElementById(divID).innerHTML;
                 //Get the HTML of whole page
                 var oldPage = document.body.innerHTML;

                 //Reset the page's HTML with div's HTML only
                 document.body.innerHTML =
                   "<html><head><title></title></head><body>" +
                   divElements + "</body>";

                 //Print Page
                 window.print();

                 //Restore orignal HTML
                 document.body.innerHTML = oldPage;
             }
</script>
 	
	      </div>
    <script>

        $(function () {

            guidely.add({
                attachTo: '#target-1'
                , anchor: 'top-left'
                , title: 'Guía - SELECCIONAR FECHA Y TURNO'
                , text: 'Seleccione la Fecha para la cual esta solicitando el equipo.<br><br>Presione el Boton en forma de calendario para obtener un turno.'
            });

            guidely.add({
                attachTo: '#target-2'
                , anchor: 'top-middle'
                , title: 'Guía - SELECCION DE BRIGADA Y PRÁCTICA'
                , text: 'Seleccione un Grupo para buscar su brigada. <br><br>Seleccione un profesor para seleccionar la práctica que realizarán.'
            });

            guidely.add({
                attachTo: '#target-3'
                , anchor: 'top-middle'
                , title: 'Guía - DETALLE DE LA BRIGADA'
                , text: 'Verifique que sea su brigada y se encuentren todos los integrantes en la tabla.'
            });

            guidely.add({
                attachTo: '#target-4'
                , anchor: 'top-middle'
                , title: 'Guía - HABILITAR LA SELECCION DE EQUIPOS'
                , text: 'Si todods los datos que selecciono son correctos presione el boton Elegir Equipos'
            });
            guidely.add({
                attachTo: '#target-5'
               , anchor: 'top-middle'
               , title: 'Guía - SELECCION DE EQUIPOS REQUERIDOS'
               , text: 'Seleccione los equipos que necesita para su práctica de la lista y especifique la cantidad que quiere solicitar<br><br>Por lo general la cantidad es de 1'
            });
            guidely.add({
                attachTo: '#target-6'
              , anchor: 'top-middle'
              , title: 'Guía - DETALLE DE LOS EQUIPOS SELECCIONADOS'
              , text: 'Verifique que los equipos que selecciono son los correctos.'
            });
            guidely.add({
                attachTo: '#target-7'
             , anchor: 'bottom-middle'
             , title: 'Guía - ENVIO DE LA SOLICITUD'
             , text: 'Presione el boton Enviar Solicitud ya que verificó que los equipos que esta solicitando son correcto.'
            });
            guidely.add({
                attachTo: '#target-8'
             , anchor: 'middle-right'
             , title: 'Guía - IMPRESION DE LA SOLICITUD'
             , text: 'Por ultimo Presionar el boton de Imprimir Solicitud que es la que se va entregar en el Área de instrumental.'
            });
            guidely.add({
                attachTo: '#target-9'
             , anchor: 'top-right'
             , title: 'Guía'
             , text: 'omg'
            });
            guidely.init({ welcome: true, startTrigger: true });


        });

</script>
</asp:Content>
