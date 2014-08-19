<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Equipos.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
    <link href="../Content/themes/login/css/style.css" rel="stylesheet" />
    <link href="../Content/themes/login/css/demo.css" rel="stylesheet" />
     <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li class="current_page_item"><a id="A5" runat="server" href="~/Equipos/">Equipos</a></li>
                        <li><a id="A2" runat="server" href="~/TipoEquipos/">Categorias</a></li>
                        
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
    <h1>
        <asp:RequiredFieldValidator ID="RequieredCategoria" runat="server" ControlToValidate="cmbCategoria" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        Categoria:&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="cmbCategoria" runat="server" DataSourceID="SqlDataSourceEquipoTipo" DataTextField="eq_tipo_nombre" DataValueField="eq_tipo_codigo" CssClass="drop-down-style"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceEquipoTipo" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [equipo_tipo]"></asp:SqlDataSource>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequieredNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="El nombre no debe estar vacio." ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;NOMBRE:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        NO. SERIE:
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSerie" ErrorMessage="El numero de serie es requerido" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtSerie" runat="server" Width="50px"></asp:TextBox>
        CANTIDAD:
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtCantidad" ErrorMessage="No se admiten letras ni cantidades negativas." ForeColor="#FF3300" MaximumValue="999" MinimumValue="0">*</asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequieredCantidad" runat="server" ControlToValidate="txtCantidad" ErrorMessage="La cantidad no debe estar vacia." ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtCantidad" runat="server" Width="50px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
</h1>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" />
    <asp:GridView ID="gvEquipos" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="eq_codigo" DataSourceID="SqlDataSourceEquipos" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="eq_codigo" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="eq_codigo" />
            <asp:BoundField DataField="eq_tipo_nombre" HeaderText="CATEGORIA" SortExpression="eq_tipo_nombre" />
            <asp:BoundField DataField="eq_serie" HeaderText="NO. SERIE" SortExpression="eq_serie" />
            <asp:BoundField DataField="eq_nombre" HeaderText="NOMBRE" SortExpression="eq_nombre" />
            <asp:BoundField DataField="eq_stock" HeaderText="CANTIDAD" SortExpression="eq_stock" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>


    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceEquipos" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" DeleteCommand="DELETE FROM equipo WHERE (eq_codigo = @original_eq_codigo)" InsertCommand="INSERT INTO [equipo] ([eq_tipo_codigo], [eq_nombre], [eq_stock]) VALUES (@eq_tipo_codigo, @eq_nombre, @eq_stock)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT equipo.eq_codigo, equipo_tipo.eq_tipo_nombre, equipo.eq_serie, equipo.eq_nombre, equipo.eq_stock FROM equipo INNER JOIN equipo_tipo ON equipo.eq_tipo_codigo = equipo_tipo.eq_tipo_codigo ORDER BY equipo.eq_stock DESC, equipo.eq_codigo, equipo.eq_nombre" UpdateCommand="UPDATE [equipo] SET [eq_tipo_codigo] = @eq_tipo_codigo, [eq_nombre] = @eq_nombre, [eq_stock] = @eq_stock WHERE [eq_codigo] = @original_eq_codigo AND [eq_tipo_codigo] = @original_eq_tipo_codigo AND [eq_nombre] = @original_eq_nombre AND [eq_stock] = @original_eq_stock">
        <DeleteParameters>
            <asp:Parameter Name="original_eq_codigo" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="eq_tipo_codigo" Type="Int32" />
            <asp:Parameter Name="eq_nombre" Type="String" />
            <asp:Parameter Name="eq_stock" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="eq_tipo_codigo" Type="Int32" />
            <asp:Parameter Name="eq_nombre" Type="String" />
            <asp:Parameter Name="eq_stock" Type="Int32" />
            <asp:Parameter Name="original_eq_codigo" Type="Int32" />
            <asp:Parameter Name="original_eq_tipo_codigo" Type="Int32" />
            <asp:Parameter Name="original_eq_nombre" Type="String" />
            <asp:Parameter Name="original_eq_stock" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
