<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AsignarEquipos.aspx.cs" Inherits="instrumental_wbforrms.AsignarEquipos" %>
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
       &nbsp;<!--ENCABEZADO DE LA SOLICITUD--><h3 style="color:#1eb265">ASIGNAR EQUIPOS A PRÁCTICAS<br />
              <br />
          </h3>
    </div>
     <div class="row" id="imp">	      	
	      	
	      	<div class="span6">	      		
	      		<div id="target-1" class="widget">
                      <div class="widget-content">
                           <div id="datos" runat="server">   
                            <center><h3>PRÁCTICAS<br /><br />
                                </h3>
                                <table style="width:100%">
                                <tr>
                                    <td style="text-align:right; padding-right:10px;">
                                        Nombre de la
                                        Materia:
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="cmbMaterias" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceMateria" DataTextField="materia_nombre" DataValueField="materia_codigo" OnSelectedIndexChanged="cmbMaterias_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSourceMateria" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [materia]"></asp:SqlDataSource>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:right; padding-right:10px;">
                                        Nùmero de
                                        Práctica:
                                    </td>
                                    <td>
                                    <asp:DropDownList ID="cmbPractica" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourcePractica" DataTextField="practica_numero" DataValueField="practica_codigo" OnSelectedIndexChanged="cmbPractica_SelectedIndexChanged"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSourcePractica" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practicas" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="cmbMaterias" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>    
                                    </td>
                                </tr>
                                </table></center>
                      </div>
                </div>
            </div>
         </div>

         <!--Equipos div-->
         <div class="span6">	      		
	      		<div id="Div1" class="widget">
                      <div class="widget-content">
                           <div id="Div2" runat="server">   
                            <center><h3>EQUIPOS<br /><br />
                                </h3>
                                <table style="width:100%">
                                    <tr>
                                        <td style="text-align:right; padding-right:10px;">
                                            Categoría del equipo: </td>
                                        <td>
                                            <asp:DropDownList ID="cmbCategoria" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceCAtegoria" DataTextField="eq_tipo_nombre" DataValueField="eq_tipo_codigo"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceCAtegoria" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [equipo_tipo]"></asp:SqlDataSource>
                                        </td>
                                        <td rowspan="2">
                                            <asp:Button ID="btnAsignar" runat="server" CssClass="button btn btn-success btn-large" Height="70px" Text="Asignar" Width="120px" OnClick="btnAsignar_Click" />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td style="text-align:right; padding-right:10px;">
                                            Nombre del Equipo: </td>
                                        <td>
                                           <asp:DropDownList ID="cmbEquipo" runat="server" DataSourceID="SqlDataSourceEquipo" DataTextField="NOMBRE" DataValueField="ID"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceEquipo" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_equipos" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbCategoria" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
                                        </td>
                                    </tr>
                                </table>
                             </center>
                            </div>
                          </div>
                      </div>
             </div><!--/DivEquipos-->
         <div class="span12">	      		
	      		<div id="Div3" class="widget">
                      <div class="widget-content">
                             <div class="widget widget-table action-table">
                                     <div class="widget-header" id="target-3"> <i class="icon-th-list"></i>
                                          <h3>EQUIPOS ASIGNADOS A LA PRÁCTICA&nbsp;</h3>
                                      </div><!-- /widget-header -->
                                             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CODIGO" DataSourceID="SqlDataSourcePracticaEquipo" CssClass="table table-striped table" OnRowCommand="GridView1_RowCommand1">
                                                <Columns>
                                                    <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" InsertVisible="False" ReadOnly="True" SortExpression="CODIGO" />
                                                    <asp:BoundField DataField="EQUIPO" HeaderText="EQUIPO" SortExpression="EQUIPO" />
                                                    <asp:CommandField SelectImageUrl="~/Content/themes/AdminTemplate/img/delete.png" SelectText="Eliminar" ShowSelectButton="True" />
                                                </Columns>
                                            </asp:GridView>
                                             <asp:SqlDataSource ID="SqlDataSourcePracticaEquipo" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_equipos_practica" SelectCommandType="StoredProcedure">
                                                <SelectParameters>
                                                    <asp:ControlParameter ControlID="cmbPractica" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                               </div><!-- div de la tabla-->
                          </div>
                      </div>
             </div>
      </div><!--/row-->
</asp:Content>
