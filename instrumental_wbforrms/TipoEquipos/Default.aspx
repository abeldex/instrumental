<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.TipoEquipos.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
       <br />
       <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li class="current_page_item"><a id="A2" runat="server" href="~/TipoEquipos/">Categorias</a></li>
                        <li ><a id="A5" runat="server" href="~/Equipos/">Equipos</a></li>
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
    <h1>CODIGO: <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;  NOMBRE:  <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar"  OnClick="btnAgregar_Click" CssClass="button"/>
</h1>

    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="eq_tipo_codigo" DataSourceID="SqlDataSourceCategorias" CssClass="datagrid">
        <Columns>
            <asp:BoundField DataField="eq_tipo_codigo" HeaderText="CODIGO" ReadOnly="True" SortExpression="eq_tipo_codigo" />
            <asp:BoundField DataField="eq_tipo_nombre" HeaderText="CATEGORIA" SortExpression="eq_tipo_nombre"/>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSourceCategorias" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" DeleteCommand="DELETE FROM [equipo_tipo] WHERE [eq_tipo_codigo] = @eq_tipo_codigo" InsertCommand="INSERT INTO [equipo_tipo] ([eq_tipo_codigo], [eq_tipo_nombre]) VALUES (@eq_tipo_codigo, @eq_tipo_nombre)" SelectCommand="SELECT [eq_tipo_codigo], [eq_tipo_nombre] FROM [equipo_tipo]" UpdateCommand="UPDATE [equipo_tipo] SET [eq_tipo_nombre] = @eq_tipo_nombre WHERE [eq_tipo_codigo] = @eq_tipo_codigo">
        <DeleteParameters>
            <asp:Parameter Name="eq_tipo_codigo" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="eq_tipo_codigo" Type="Int32" />
            <asp:Parameter Name="eq_tipo_nombre" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="eq_tipo_nombre" Type="String" />
            <asp:Parameter Name="eq_tipo_codigo" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>   
</asp:Content>
