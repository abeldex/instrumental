<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Profesores.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
    <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/">Inicio</a></li>
                        <li ><a id="A8" runat="server" href="~/Materias/">Materias</a></li>
                        <li class="current_page_item"><a id="A2" runat="server" href="~/Profesores/">Profesores</a></li>
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
    <h1>NUMERO DE EMPLEADO:<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="El numero de empleado es requerido." ForeColor="#FF3300">*</asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="txtCodigo" runat="server" Width="115px"></asp:TextBox>&nbsp;&nbsp; NOMBRE:
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNomnbre" ErrorMessage="El nomre del profesor es requerido." ForeColor="#FF3300">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtNomnbre" runat="server"></asp:TextBox>
    &nbsp;
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" Width="152px" />
    </h1>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="profesor_codigo" DataSourceID="SqlDataSourceProfesores">
            <Columns>
                <asp:BoundField DataField="profesor_codigo" HeaderText="NUM. EMPLEADO" ReadOnly="True" SortExpression="profesor_codigo" />
                <asp:BoundField DataField="profesor_nombre" HeaderText="NOMBRE" SortExpression="profesor_nombre" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceProfesores" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" DeleteCommand="DELETE FROM [profesor] WHERE [profesor_codigo] = @original_profesor_codigo AND [profesor_nombre] = @original_profesor_nombre" InsertCommand="INSERT INTO [profesor] ([profesor_codigo], [profesor_nombre]) VALUES (@profesor_codigo, @profesor_nombre)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [profesor]" UpdateCommand="UPDATE [profesor] SET [profesor_nombre] = @profesor_nombre WHERE [profesor_codigo] = @original_profesor_codigo AND [profesor_nombre] = @original_profesor_nombre">
            <DeleteParameters>
                <asp:Parameter Name="original_profesor_codigo" Type="Int32" />
                <asp:Parameter Name="original_profesor_nombre" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="profesor_codigo" Type="Int32" />
                <asp:Parameter Name="profesor_nombre" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="profesor_nombre" Type="String" />
                <asp:Parameter Name="original_profesor_codigo" Type="Int32" />
                <asp:Parameter Name="original_profesor_nombre" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
