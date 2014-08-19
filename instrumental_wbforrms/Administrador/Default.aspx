<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms._Default" %>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li class="current_page_item"><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li><a id="A2" runat="server" href="~/TipoEquipos/">Categorias-Equipos</a></li>
                        <li ><a id="A6" runat="server" href="~/Brigadas/">Brigadas-Alumnos</a></li>
                        <li ><a id="A3" runat="server" href="~/Materias/">Materias-Profesores</a></li>
                        <li ><a id="A5" runat="server" href="~/Practicas/">Prácticas</a></li>
            <div style="position:fixed; top:0px; right:0px;">
                            <section id="Section1">
                    <asp:LoginView ID="LoginView2" runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                                <a id="registerLink" runat="server" href="~/Account/Register.aspx">Registrarse</a>
                                <a id="loginLink" runat="server" href="~/Account/Login.aspx">Iniciar sesión</a>
                        </AnonymousTemplate>
                        <LoggedInTemplate>
                            <p>
                                Hola, <a id="A4" runat="server" class="username" href="~/Account/Manage.aspx" title="Manage your account">
                                    <asp:LoginName ID="LoginName1" runat="server" CssClass="username" /></a>.
                                <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" LogoutText="Salir" LogoutPageUrl="~/" />
                            </p>
                        </LoggedInTemplate>
                    </asp:LoginView>
                </section>
                        </div>                  
        </ul>
        
    </nav>
    <!-- /Nav -->
   <div id="banner-wrapper">
				<section id="banner">
                    <img src="../Content/themes/theme_up/css/images/uas.png" style="width:100px; float:left;"/><img src="../Content/themes/theme_up/css/images/LOGO%20GEODESIA.png" style="width:130px; float:right;"/>
					<h2>SISTEMA DE INSTRUMENTAL GEODÉSICO</h2>      
					<h3 style="color:white;">FACULTAD DE CIENCIAS DE LA TIERRA Y EL ESPACIO</h3>				
				</section>
</div>
</asp:Content>
