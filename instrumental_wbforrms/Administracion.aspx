<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="instrumental_wbforrms.Administracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="menu" runat="server">
     <div class="subnavbar">
                  <div class="subnavbar-inner">
                    <div class="container">
                      <ul class="mainnav">
                          <li class="active"><a href="Administracion.aspx"><i class="icon-home"></i><span>INICIO</span> </a> </li>
                          <li ><a href="ListaSolicitudes.aspx"><i class="icon-list"></i><span>Lista de Solicitudes</span> </a> </li> 
                          <li ><a href="Recibir.aspx"><i class="icon-retweet"></i><span>Recepción de Equipos</span> </a> </li> 
                          <li ><a href="AsignarEquipos.aspx"><i class="icon-briefcase"></i><span>Asignar Equipos a Prácticas</span> </a> </li>  
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
    <div class="widget">
            <div class="widget-header"> <i class="icon-bookmark"></i>
              <h3>Accesos Importantes</h3>
            </div>
            <!-- /widget-header -->
            <div class="widget-content">
              <div class="shortcuts"> 
                  <a href="ListaSolicitudes.aspx" class="shortcut">
                      <i class="shortcut-icon icon-list"></i>
                      <span class="shortcut-label">Ver solicitudes Pendientes</span> 
                  </a>
                  <a href="Recibir.aspx" class="shortcut">
                      <i class="shortcut-icon icon-retweet"></i>
                        <span class="shortcut-label">Recibir Equipos</span> </a>  
                  <a href="AsignarEquipos.aspx" class="shortcut">
                      <i class="shortcut-icon icon-briefcase"></i>
                      <span class="shortcut-label">Asignar Equipos a Prácticas</span> </a>
                  <!--<a href="javascript:;" class="shortcut">
                      <i class="shortcut-icon icon-signal"></i> 
                      <span class="shortcut-label">Ver Reportes</span> </a>
                  <a href="javascript:;" class="shortcut"> 
                      <i class="shortcut-icon icon-comment"></i>
                      <span class="shortcut-label">Commentarios</span> </a>
                  <a href="javascript:;" class="shortcut">
                      <i class="shortcut-icon icon-group"></i>
                      <span class="shortcut-label">Brigadas</span> </a>
                
                  <a href="javascript:;" class="shortcut">
                      <i class="shortcut-icon icon-book"></i> 
                      <span class="shortcut-label">Prácticas</span> 
                  </a><a href="javascript:;" class="shortcut"> 
                      <i class="shortcut-icon icon-cogs"></i>
                      <span class="shortcut-label">Opciones</span> </a> </div>-->
              <!-- /shortcuts --> 
            </div>
            <!-- /widget-content --> 
          </div>
            </a>
    </div>
</asp:Content>
