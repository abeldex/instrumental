<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Practica_Profesor.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
     <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li><a id="A10" runat="server" href="~/Practicas/">Prácticas</a></li>
                        <li><a id="A2" runat="server" href="~/Profesores/">PROFESORES</a></li>
                        <li ><a id="A5" runat="server" href="~/Materias/">MATERIAS</a></li>
                        <li class="current_page_item"><a id="A3" runat="server" href="~/Practica-Profesor/">Practicas-Profesor</a></li>
                        
            <div style="position:fixed; top:0px; right:0px;">
                            <section id="Section1">
                    <asp:LoginView ID="LoginView2" runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                            <ul>
                                <li><a id="registerLink" runat="server" href="~/Account/Register.aspx">Registrarse</a></li>
                                <li><a id="loginLink" runat="server" href="~/Account/Login.aspx">Iniciar sesión</a></li>
                            </ul>
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
    <h2>ASIGNAR PRÁCTICAS A PROFESORES</h2>
    <h1>PROFESOR: <asp:DropDownList ID="cmbProfesor" runat="server" DataSourceID="SqlDataSourceProfesor" DataTextField="profesor_nombre" DataValueField="profesor_codigo" Font-Names="Segoe UI" Font-Size="Medium" AutoPostBack="True"></asp:DropDownList></h1>
        <asp:SqlDataSource ID="SqlDataSourceProfesor" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [profesor]"></asp:SqlDataSource>
        <h1>MATERIA:
        <asp:DropDownList ID="cmbMateria" runat="server" DataSourceID="SqlDataSourceMateria" DataTextField="materia_nombre" DataValueField="materia_codigo" Font-Names="Segoe UI" Font-Size="Medium" AutoPostBack="True">
        </asp:DropDownList></h1>
        <asp:SqlDataSource ID="SqlDataSourceMateria" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [materia]"></asp:SqlDataSource>
        <h1>PRÁCTICA: <asp:DropDownList ID="cmbPractica" runat="server" DataSourceID="SqlDataSourcePractica" DataTextField="practica_nombre" DataValueField="practica_codigo" Font-Names="Segoe UI" Font-Size="Medium"></asp:DropDownList></h1>
        <asp:SqlDataSource ID="SqlDataSourcePractica" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practicas" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbMateria" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Button ID="btnAsignar" runat="server" Text="Asignar" Width="123px" OnClick="btnAsignar_Click" />
    
    <p>
        <h2>PRÁCTICAS ASIGNADAS</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePracticaProfesor" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="MATERIA" HeaderText="MATERIA" SortExpression="MATERIA" />
                <asp:BoundField DataField="PRACTICA" HeaderText="PRACTICA" SortExpression="PRACTICA" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourcePracticaProfesor" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practica_profesor" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbProfesor" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
