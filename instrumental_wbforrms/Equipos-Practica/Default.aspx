<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Equipos_Practica.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
     <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li><a id="A10" runat="server" href="~/Practicas/">Prácticas</a></li>
                        <li><a id="A2" runat="server" href="~/Equipos/">EQUIPOS</a></li>
                        <li class="current_page_item"><a id="A3" runat="server" href="~/Equipos-Practica/">Equipos-Prácticas</a></li>
                        
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
    <h2>ASIGNAR EQUIPOS A PRÁCTICAS</h2>
    <h1>Materia: <asp:DropDownList ID="cmbMaterias" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceMateria" DataTextField="materia_nombre" DataValueField="materia_codigo" Font-Names="Segoe UI" Font-Size="Medium"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceMateria" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [materia]"></asp:SqlDataSource>
    </h1>
    <h1>Practica: <asp:DropDownList ID="cmbPractica" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourcePractica" DataTextField="practica_numero" DataValueField="practica_codigo" Font-Names="Segoe UI" Font-Size="Medium"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourcePractica" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practicas" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbMaterias" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </h1>
    <h1>Categoria: <asp:DropDownList ID="cmbCategoria" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceCAtegoria" DataTextField="eq_tipo_nombre" DataValueField="eq_tipo_codigo" Font-Names="Segoe UI" Font-Size="Medium"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceCAtegoria" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [equipo_tipo]"></asp:SqlDataSource>
    </h1>
    <h1>Equipo: <asp:DropDownList ID="cmbEquipo" runat="server" DataSourceID="SqlDataSourceEquipo" DataTextField="NOMBRE" DataValueField="ID" Font-Names="Segoe UI" Font-Size="Medium"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceEquipo" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_equipos" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbCategoria" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </h1>
    <asp:Button ID="Button1" runat="server" Text="ASIGNAR" OnClick="Button1_Click" Width="216px" />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CODIGO" DataSourceID="SqlDataSourcePracticaEquipo" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" InsertVisible="False" ReadOnly="True" SortExpression="CODIGO" />
            <asp:BoundField DataField="EQUIPO" HeaderText="EQUIPO" SortExpression="EQUIPO" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourcePracticaEquipo" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_equipos_practica" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbPractica" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
