<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Practicas.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/theme_up/css/tablas.css" rel="stylesheet" />
     <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li><a id="A1" runat="server" href="~/Administrador/">Inicio</a></li>
                        <li class="current_page_item"><a id="A10" runat="server" href="~/Practicas/">Prácticas</a></li>
                        <li><a id="A2" runat="server" href="~/Profesor-Practica/">ASIGNAR PRACTICAS A PROFESORES</a></li>
                        <li><a id="A3" runat="server" href="~/Equipos-Practica/">ASIGNAR EQUIPOS A PRÁCTICAS</a></li>
                        
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
    <h1>No. Práctica: 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="numero de práctica es requerido" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtCodigo" runat="server" Width="39px"></asp:TextBox>&nbsp; NOMBRE:
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="El nombre de la práctica es requerido." ForeColor="#FF3300">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
     &nbsp;MATERIA:
        <asp:DropDownList ID="cmbMateria" runat="server" DataSourceID="SqlDataSourceMaterias" DataTextField="materia_nombre" DataValueField="materia_codigo" Font-Names="Segoe UI" Font-Size="Medium" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceMaterias" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [materia]"></asp:SqlDataSource>
&nbsp;&nbsp;
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" Width="148px" />
     </h1>
     <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
     <p>
         <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePracticas" DataKeyNames="practica_codigo">
             <Columns>
                 <asp:BoundField DataField="practica_numero" HeaderText="NO. PRÁCTICA" SortExpression="practica_numero" />
                 <asp:BoundField DataField="practica_nombre" HeaderText="NOMBRE DE LA PRÁCTICA" SortExpression="practica_nombre" />
             </Columns>
         </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSourcePracticas" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practicas" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [practica] WHERE [practica_codigo] = @original_practica_codigo AND [practica_numero] = @original_practica_numero AND [practica_nombre] = @original_practica_nombre AND [materia_codigo] = @original_materia_codigo" InsertCommand="INSERT INTO [practica] ([practica_numero], [practica_nombre], [materia_codigo]) VALUES (@practica_numero, @practica_nombre, @materia_codigo)" OldValuesParameterFormatString="original_{0}" SelectCommandType="StoredProcedure" UpdateCommand="UPDATE [practica] SET [practica_numero] = @practica_numero, [practica_nombre] = @practica_nombre, [materia_codigo] = @materia_codigo WHERE [practica_codigo] = @original_practica_codigo AND [practica_numero] = @original_practica_numero AND [practica_nombre] = @original_practica_nombre AND [materia_codigo] = @original_materia_codigo">
             <DeleteParameters>
                 <asp:Parameter Name="original_practica_codigo" Type="Int32" />
                 <asp:Parameter Name="original_practica_numero" Type="Int32" />
                 <asp:Parameter Name="original_practica_nombre" Type="String" />
                 <asp:Parameter Name="original_materia_codigo" Type="Int32" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="practica_numero" Type="Int32" />
                 <asp:Parameter Name="practica_nombre" Type="String" />
                 <asp:Parameter Name="materia_codigo" Type="Int32" />
             </InsertParameters>
             <SelectParameters>
                 <asp:ControlParameter ControlID="cmbMateria" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
             </SelectParameters>
             <UpdateParameters>
                 <asp:Parameter Name="practica_numero" Type="Int32" />
                 <asp:Parameter Name="practica_nombre" Type="String" />
                 <asp:Parameter Name="materia_codigo" Type="Int32" />
                 <asp:Parameter Name="original_practica_codigo" Type="Int32" />
                 <asp:Parameter Name="original_practica_numero" Type="Int32" />
                 <asp:Parameter Name="original_practica_nombre" Type="String" />
                 <asp:Parameter Name="original_materia_codigo" Type="Int32" />
             </UpdateParameters>
         </asp:SqlDataSource>
     </p>

</asp:Content>
