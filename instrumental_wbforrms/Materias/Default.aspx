<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Materias.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
    <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li class="current_page_item"><a id="A8" runat="server" href="~/Materias/">Materias</a></li>
                        <li><a id="A2" runat="server" href="~/Profesores/">Profesores</a></li>
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
    <h1>Nombre:&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="El nombre es requerido." ForeColor="#FF3300">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    &nbsp;
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" /></h1>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="materia_codigo" DataSourceID="SqlDataSourceMaterias">
            <Columns>
                <asp:BoundField DataField="materia_codigo" HeaderText="CODIGO" InsertVisible="False" ReadOnly="True" SortExpression="materia_codigo" />
                <asp:BoundField DataField="materia_nombre" HeaderText="NOMBRE" SortExpression="materia_nombre" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceMaterias" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" DeleteCommand="DELETE FROM [materia] WHERE [materia_codigo] = @original_materia_codigo AND [materia_nombre] = @original_materia_nombre" InsertCommand="INSERT INTO [materia] ([materia_nombre]) VALUES (@materia_nombre)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [materia]" UpdateCommand="UPDATE [materia] SET [materia_nombre] = @materia_nombre WHERE [materia_codigo] = @original_materia_codigo AND [materia_nombre] = @original_materia_nombre">
            <DeleteParameters>
                <asp:Parameter Name="original_materia_codigo" Type="Int32" />
                <asp:Parameter Name="original_materia_nombre" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="materia_nombre" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="materia_nombre" Type="String" />
                <asp:Parameter Name="original_materia_codigo" Type="Int32" />
                <asp:Parameter Name="original_materia_nombre" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
