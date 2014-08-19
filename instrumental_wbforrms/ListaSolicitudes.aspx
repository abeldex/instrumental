<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaSolicitudes.aspx.cs" Inherits="instrumental_wbforrms.ListaSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="menu" runat="server">
<div class="subnavbar">
                  <div class="subnavbar-inner">
                    <div class="container">
                      <ul class="mainnav">
                          <li class="active"><a href="Administracion.aspx"><i class="icon-home"></i><span>INICIO</span> </a> </li>
                          <li ><a href="ListaSolicitudes.aspx"><i class="icon-list"></i><span>Lista de Solicitudes</span> </a> </li> 
                          <li ><a href="Recibir.aspx"><i class="icon-retweet"></i><span>Recepción de Equipos</span> </a> </li> 
                          <li ><a href="AsignarEquipos.aspx"><i class="icon-briefcase"></i><span>Recepción de Equipos</span> </a> </li>  
                        <!--  <li ><a href="#"><i class="icon-briefcase "></i><span>Equipos</span> </a> </li>                                                               
                          <li ><a href="#"><i class="icon-group"></i><span>Brigadas</span> </a> </li> 
                          <li ><a href="#"><i class="icon-book"></i><span>Prácticas</span> </a> </li>
                        <li><a href="guidely.html"><i class="icon-facetime-video"></i><span>App Tour</span> </a></li>
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
                             <asp:LoginView ID="LoginView2" runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                           
                                <a id="registerLink" runat="server" href="~/Account/Register.aspx">Registrarse</a>
                                <a id="loginLink" runat="server" href="~/Account/Login.aspx">Iniciar sesión</a>
                           
                        </AnonymousTemplate>
                        <LoggedInTemplate>
                            <p><br />
                                usuario: <i class="icon-user"></i><a id="A4" runat="server" class="" href="~/Account/Manage.aspx" title="Cambiar Contraseña">
                                    <asp:LoginName ID="LoginName1" runat="server" CssClass="dropdown" /></a> | 
                                <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" LogoutText="Salir" LogoutPageUrl="http://servidor/" /><i class="icon-signout"></i>
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
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div style="text-align:center;">
       &nbsp;<!--ENCABEZADO DE LA SOLICITUD--><h3 style="color:#1eb265">LISTA DE SOLICITUDES PENDIENTES</h3>
    </div>
     <div class="row" id="imp">	      	
	      	
	      	<div class="span6" id="divFecha" runat="server">
	      		
	      		<div id="target-1" class="widget">
	      			
	      			<div class="widget-content">
                          <div class="widget widget-table action-table" >
            <div class="widget-header" style="width:100%"> <i class="icon-list-alt"></i>
              <h3>Fecha:</h3>
            </div> 
                       <br /> <center><asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Italic="False" Font-Names="Segoe UI" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="305px">
                                  <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                                  <DayStyle Width="14%" />
                                  <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                                  <OtherMonthDayStyle ForeColor="#999999" />
                                  <SelectedDayStyle BackColor="#00CC66" ForeColor="White" />
                                  <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                                  <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                                  <TodayDayStyle BackColor="#CCCC99" />
                                  </asp:Calendar>
                                  <br />
                                  
                              </center>
           </div>
                         
                    </div>
                </div>
            </div>

           <!-- TABLA DE EQUIPOS SOLICITADOS-->
         <div class="span6" id="DivEquiposSol" runat="server">
	        <div id="Div2" class="widget">		
                <div class="widget-content">
			 <div class="widget widget-table action-table">
            <div class="widget-header"> <i class="icon-list-alt"></i>
              <h3>Equipos Solicitados de la Solicitud Numero <asp:Label ID="MessageLabel" runat="server"></asp:Label></h3>
            </div>
            <!-- /widget-header -->
            
                <asp:GridView ID="dgEquiposSolicitados" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="CATEGORIA" HeaderText="CATEGORIA" SortExpression="CATEGORIA" />
                        <asp:BoundField DataField="SERIE" HeaderText="SERIE" SortExpression="SERIE" />
                        <asp:BoundField DataField="EQUIPO" HeaderText="EQUIPO" SortExpression="EQUIPO" />
                        <asp:BoundField DataField="SOLICITADO" HeaderText="SOLICITADO" SortExpression="SOLICITADO" />
                        <asp:BoundField DataField="EXISTENCIA" HeaderText="EXISTENCIA" SortExpression="EXISTENCIA" />
                    </Columns>
                </asp:GridView>
            
                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT et.eq_tipo_nombre AS CATEGORIA, e.eq_serie AS SERIE, e.eq_nombre AS EQUIPO, sd.cantidad AS SOLICITADO, e.eq_stock AS EXISTENCIA FROM solicitud_detalle AS sd INNER JOIN equipo AS e ON sd.eq_codigo = e.eq_codigo INNER JOIN equipo_tipo AS et ON e.eq_tipo_codigo = et.eq_tipo_codigo WHERE (sd.sol_codigo = @solicitud)">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="MessageLabel" Name="solicitud" PropertyName="Text" />
                     </SelectParameters>
                 </asp:SqlDataSource>
            
            <!-- /widget-content --> 
          </div>
			      		
		      		<img src="Content/themes/AdminTemplate/img/1382651183_print.png" style="width: 32px; height: 32px" /><asp:LinkButton ID="LinkButton2" runat="server" Font-Size="Larger" OnClick="LinkButton2_Click" OnClientClick="javascript:printDiv('main');muestra_oculta('divFecha')">IMPRIMIR SOLICITUD</asp:LinkButton>
			      		
		      		</div> <!-- /widget-content -->
	      		</div> 
	      		
      		</div>
            <!-- /span6 -->      	

         <div class="span12">
	      		
	      		<div id="Div1" class="widget">
	      			
	      			<div class="widget-content">
                          <div class="widget widget-table action-table" >
            <div class="widget-header" style="width:100%"> <i class="icon-list-alt"></i>
              <h3>Solicitudes Pendientes:</h3>
            </div> 
                              <asp:GridView ID="dgvSolPendientes" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceSolPendientes" Width="100%" CssClass="table table-striped table-bordered" DataKeyNames="SOLICITUD" OnRowDataBound="dgvSolPendientes_RowDataBound" OnSelectedIndexChanged="dgvSolPendientes_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="SOLICITUD" HeaderText="SOLICITUD" SortExpression="SOLICITUD" InsertVisible="False" ReadOnly="True" />
                        <asp:BoundField DataField="TURNO" SortExpression="TURNO" HeaderText="TURNO" >
                        </asp:BoundField>
                        <asp:BoundField DataField="BRIGADA" SortExpression="BRIGADA" HeaderText="BRIGADA" >
                        </asp:BoundField>
                        <asp:BoundField DataField="bri_grupo" HeaderText="bri_grupo" SortExpression="bri_grupo" />
                        <asp:BoundField DataField="PRÁCTICA" HeaderText="PRÁCTICA" SortExpression="PRÁCTICA" />
                        <asp:BoundField DataField="PROFESOR" HeaderText="PROFESOR" SortExpression="PROFESOR" />
                        <asp:ButtonField CommandName="Select" Text="Ver" />
                    </Columns>
                </asp:GridView>
                              <asp:SqlDataSource ID="SqlDataSourceSolPendientes" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT solicitud.sol_codigo AS SOLICITUD, solicitud.turno AS TURNO, brigada.bri_nombre AS BRIGADA, brigada.bri_grupo, practica.practica_numero AS PRÁCTICA, profesor.profesor_nombre AS PROFESOR FROM solicitud INNER JOIN brigada ON solicitud.bri_codigo = brigada.bri_codigo INNER JOIN practica ON solicitud.practica_codigo = practica.practica_codigo INNER JOIN profesor ON solicitud.profesor_codigo = profesor.profesor_codigo WHERE (solicitud.estado = 1) AND (solicitud.sol_fecha = @fecha) ORDER BY TURNO">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="Calendar1" Name="fecha" PropertyName="SelectedDate" />
                                  </SelectParameters>
                              </asp:SqlDataSource>
           </div>
                         
                    </div>
                </div>
            </div>
      </div>
      </div>
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
    <script>

        function muestra_oculta(id) {
            if (document.getElementById) { //se obtiene el id
                var el = document.getElementById(id); //se define la variable "el" igual a nuestro div
                el.style.display = (el.style.display == 'none') ? 'block' : 'none'; //damos un atributo display:none que oculta el div
            }
        }
        window.onload = function () {/*hace que se cargue la función lo que predetermina que div estará oculto hasta llamar a la función nuevamente*/
            muestra_oculta('contenido_a_mostrar');/* "contenido_a_mostrar" es el nombre de la etiqueta DIV que deseamos mostrar */
        }
</script>
</asp:Content>
