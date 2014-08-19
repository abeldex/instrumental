<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Alumnos.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
     <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                         <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li><a id="A6" runat="server" href="~/Brigadas/">Brigadas</a></li>
                        <li  class="current_page_item"><a id="A2" runat="server" href="~/Alumnos/">Alumnos</a></li>
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
    <div>
    <div style="text-align:left;">  
        <br />
        <asp:RequiredFieldValidator ID="RequieredNombre" runat="server" ControlToValidate="txtCuenta" ErrorMessage="Numero de Cuenta requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;NO. CUENTA:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCuenta" runat="server" Width="100px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequieredCategoria" runat="server" ControlToValidate="cmbBrigada" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        BRIGADA:&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="cmbBrigada" runat="server" DataSourceID="SqlDataSourceBrigadas" DataTextField="bri_nombre" DataValueField="bri_codigo"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceBrigadas" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [brigada]"></asp:SqlDataSource>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequieredCantidad" runat="server" ControlToValidate="txtNombre" ErrorMessage="Nombre requerido." ForeColor="Red">*</asp:RequiredFieldValidator>
        NOMBRE:
        <asp:TextBox ID="txtNombre" runat="server" Width="300px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;

        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGrupo" ErrorMessage="El grupo es requerido" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
        &nbsp;GRUPO:&nbsp;&nbsp;
        <asp:TextBox ID="txtGrupo" runat="server" Width="100px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Telefono requerido" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
        TELEFONO:&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefono" runat="server" Width="150px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" CssClass="button"/>
</div>
  
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
  </div>
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="al_cuenta" DataSourceID="SqlDataSourceAlumnos">
        <Columns>
            <asp:BoundField DataField="al_cuenta" HeaderText="NUMERO CUENTA" ReadOnly="True" SortExpression="al_cuenta" />
            <asp:BoundField DataField="al_nombre" HeaderText="NOMBRE" SortExpression="al_nombre" />
            <asp:BoundField DataField="al_grupo" HeaderText="GRUPO" SortExpression="al_grupo" />
            <asp:BoundField DataField="al_telefono" HeaderText="TELEFONO" SortExpression="al_telefono" />
            <asp:BoundField DataField="bri_codigo" HeaderText="BRIGADA" SortExpression="bri_codigo" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceAlumnos" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" DeleteCommand="DELETE FROM [alumno] WHERE [al_cuenta] = @original_al_cuenta AND [bri_codigo] = @original_bri_codigo AND [al_nombre] = @original_al_nombre AND [al_grupo] = @original_al_grupo AND (([al_telefono] = @original_al_telefono) OR ([al_telefono] IS NULL AND @original_al_telefono IS NULL))" InsertCommand="INSERT INTO [alumno] ([al_cuenta], [bri_codigo], [al_nombre], [al_grupo], [al_telefono]) VALUES (@al_cuenta, @bri_codigo, @al_nombre, @al_grupo, @al_telefono)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [alumno]" UpdateCommand="UPDATE [alumno] SET [bri_codigo] = @bri_codigo, [al_nombre] = @al_nombre, [al_grupo] = @al_grupo, [al_telefono] = @al_telefono WHERE [al_cuenta] = @original_al_cuenta AND [bri_codigo] = @original_bri_codigo AND [al_nombre] = @original_al_nombre AND [al_grupo] = @original_al_grupo AND (([al_telefono] = @original_al_telefono) OR ([al_telefono] IS NULL AND @original_al_telefono IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_al_cuenta" Type="String" />
            <asp:Parameter Name="original_bri_codigo" Type="Int32" />
            <asp:Parameter Name="original_al_nombre" Type="String" />
            <asp:Parameter Name="original_al_grupo" Type="String" />
            <asp:Parameter Name="original_al_telefono" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="al_cuenta" Type="String" />
            <asp:Parameter Name="bri_codigo" Type="Int32" />
            <asp:Parameter Name="al_nombre" Type="String" />
            <asp:Parameter Name="al_grupo" Type="String" />
            <asp:Parameter Name="al_telefono" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="bri_codigo" Type="Int32" />
            <asp:Parameter Name="al_nombre" Type="String" />
            <asp:Parameter Name="al_grupo" Type="String" />
            <asp:Parameter Name="al_telefono" Type="String" />
            <asp:Parameter Name="original_al_cuenta" Type="String" />
            <asp:Parameter Name="original_bri_codigo" Type="Int32" />
            <asp:Parameter Name="original_al_nombre" Type="String" />
            <asp:Parameter Name="original_al_grupo" Type="String" />
            <asp:Parameter Name="original_al_telefono" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
