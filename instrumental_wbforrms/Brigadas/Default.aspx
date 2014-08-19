<%@ Page Title="" Language="C#" MasterPageFile="~/flat.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Brigadas.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
      <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li class="current_page_item"><a id="A6" runat="server" href="~/Brigadas/">Brigadas</a></li>
                        <li><a id="A2" runat="server" href="~/Alumnos/">Alumnos</a></li>
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
    <h1>
     <asp:RequiredFieldValidator ID="RequieredNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="El nombre es requerido." ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;NOMBRE:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequieredCantidad" runat="server" ControlToValidate="txtGrupo" ErrorMessage="El grupo es requerido." ForeColor="Red">*</asp:RequiredFieldValidator>
        grupo:
        <asp:TextBox ID="txtGrupo" runat="server" Width="50px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
</h1>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="bri_codigo" DataSourceID="SqlDataSourceBrigadas">
        <Columns>
            <asp:BoundField DataField="bri_codigo" HeaderText="CODIGO" InsertVisible="False" ReadOnly="True" SortExpression="bri_codigo" />
            <asp:BoundField DataField="bri_nombre" HeaderText="NOMBRE" SortExpression="bri_nombre" />
            <asp:BoundField DataField="bri_grupo" HeaderText="GRUPO" SortExpression="bri_grupo" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
     </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSourceBrigadas" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" DeleteCommand="DELETE FROM [brigada] WHERE [bri_codigo] = @original_bri_codigo AND [bri_nombre] = @original_bri_nombre AND [bri_grupo] = @original_bri_grupo" InsertCommand="INSERT INTO [brigada] ([bri_nombre], [bri_grupo]) VALUES (@bri_nombre, @bri_grupo)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [brigada]" UpdateCommand="UPDATE [brigada] SET [bri_nombre] = @bri_nombre, [bri_grupo] = @bri_grupo WHERE [bri_codigo] = @original_bri_codigo AND [bri_nombre] = @original_bri_nombre AND [bri_grupo] = @original_bri_grupo">
         <DeleteParameters>
             <asp:Parameter Name="original_bri_codigo" Type="Int32" />
             <asp:Parameter Name="original_bri_nombre" Type="String" />
             <asp:Parameter Name="original_bri_grupo" Type="String" />
         </DeleteParameters>
         <InsertParameters>
             <asp:Parameter Name="bri_nombre" Type="String" />
             <asp:Parameter Name="bri_grupo" Type="String" />
         </InsertParameters>
         <UpdateParameters>
             <asp:Parameter Name="bri_nombre" Type="String" />
             <asp:Parameter Name="bri_grupo" Type="String" />
             <asp:Parameter Name="original_bri_codigo" Type="Int32" />
             <asp:Parameter Name="original_bri_nombre" Type="String" />
             <asp:Parameter Name="original_bri_grupo" Type="String" />
         </UpdateParameters>
     </asp:SqlDataSource>
</asp:Content>
