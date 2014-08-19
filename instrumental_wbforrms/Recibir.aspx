<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Recibir.aspx.cs" Inherits="instrumental_wbforrms.Recibir" %>
<asp:Content ID="menu2" ContentPlaceHolderID="menu" runat="server">
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
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center;">
       &nbsp;<!--ENCABEZADO DE LA SOLICITUD--><h3 style="color:#1eb265">RECIBIR EQUIPOS</h3>
    </div>
     <div class="row" id="imp">	      	
	      	
	      	<div class="span12">
	      		
	      		<div id="target-1" class="widget">
	      			
	      			<div class="widget-content">
	      				
			      		<h4 style="float:right" id="botones" runat="server">
                        <img src="Content/themes/AdminTemplate/img/1382651183_print.png" style="width: 32px; height: 32px" /><asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="javascript:printDiv('main')" Font-Size="Larger">IMPRIMIR SOLICITUD</asp:LinkButton>
                              <br /><br /><br /><br />
                            <img alt="" src="Images/1382657409_login.png" style="width: 32px; height: 32px" /><asp:LinkButton ID="btnRecibir" runat="server" Font-Size="Larger" OnClick="btnRecibir_Click" OnClientClick="return confirm(&quot;¿Desea recibir los equipos de esta solicitud?&quot;)">RECIBIR LOS EQUIPOS</asp:LinkButton>
			      		    
                          </h4>
			      		
			      		<h3 style="color:#ff6a00"> Número de Solicitud :
                &nbsp;<asp:TextBox ID="txtNumSol" runat="server" Height="26px" Width="47px" ToolTip="Ingrese un Número válido"></asp:TextBox><asp:ImageButton ID="btnBuscar" runat="server" Height="30px" ImageUrl="~/Images/1382652633_search.png" ToolTip="Buscar" OnClick="btnBuscar_Click" /></h3>
                        <div id="datos" runat="server">   
                            <table>
                                <tr>
                                    <td>
                                        <b>Solicitud :</b>
                                    </td>
                                    <td>
                                        <asp:label runat="server" ID="lblSolicitud"></asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <b>Fecha :</b>
                                    </td>
                                    <td>
                                        <asp:label runat="server" ID="lblFecha"></asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <b>Turno :</b>
                                    </td>
                                    <td>
                                        <asp:label runat="server" ID="lblTurno"></asp:label>
                                    </td>
                                </tr>
                            </table>
                           <p style="color:#000"> &nbsp;<asp:label runat="server" ID="lblBride" Visible="False"></asp:label>
                               
                            </p>
                           </div> 
                          <div id="error" runat="server"><p style="color:#f00"> Error : <asp:label runat="server" ID="lblError"></asp:label></p></div>
                           
                    </div> <!-- /widget-content -->
		      		
	      		</div> <!-- /widget -->
	      		
      		</div> <!-- /span12 -->
         <!-- TABLA DE INTEGRANTES DE LA BRIGADA-->
         <div class="span6" id="DivIntegrantesBrigada" runat="server">
	        <div id="target-2" class="widget">		
                <div class="widget-content">
			 <div class="widget widget-table action-table">
            <div class="widget-header"> <i class="icon-th-list"></i>
              <h3>Integrantes de la Brigada</h3>
            </div>
            <!-- /widget-header -->
            
                <asp:GridView ID="dgIntegrantesBrigada" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table" DataKeyNames="CUENTA" DataSourceID="SqlDataSourceAlumnoBrigada">
                    <Columns>
                        <asp:BoundField DataField="CUENTA" HeaderText="CUENTA" ReadOnly="True" SortExpression="CUENTA" />
                        <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
                        <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
                    </Columns>
                </asp:GridView>
            
                 <asp:SqlDataSource ID="SqlDataSourceAlumnoBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT al_cuenta AS CUENTA, al_nombre AS NOMBRE, al_telefono AS TELEFONO FROM alumno WHERE (bri_codigo = @brigada)">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="lblBride" DefaultValue="0" Name="brigada" PropertyName="Text" />
                     </SelectParameters>
                 </asp:SqlDataSource>
            
            <!-- /widget-content --> 
          </div>
			      		
		      		</div> <!-- /widget-content -->
		      		
	      		</div> 
	      		
      		</div>
            <!-- /span6 -->      	

     <!-- TABLA DE EQUIPOS SOLICITADOS-->
         <div class="span6" id="DivEquiposSol" runat="server">
	        <div id="Div2" class="widget">		
                <div class="widget-content">
			 <div class="widget widget-table action-table">
            <div class="widget-header"> <i class="icon-list-alt"></i>
              <h3>Equipos Solicitados</h3>
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
                         <asp:ControlParameter ControlID="lblSolicitud" Name="solicitud" PropertyName="Text" />
                     </SelectParameters>
                 </asp:SqlDataSource>
            
            <!-- /widget-content --> 
          </div>
			      		
		      		</div> <!-- /widget-content -->
		      		
	      		</div> 
	      		
      		</div>
            <!-- /span6 -->      	
         </div><!-- / DivBox -->
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
</asp:Content>
