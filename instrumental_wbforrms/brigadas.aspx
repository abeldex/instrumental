<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true"  MasterPageFile="~/flat.Master" AutoEventWireup="true" CodeBehind="brigadas.aspx.cs" Inherits="instrumental_wbforrms.brigadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <form id="form1" runat="server">
          <!-- Custom styles for this template -->
    <!--external css-->
    <link href="Content/themes/flat/assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <link href="Content/themes/flat/css/tasks.css" rel="stylesheet">
    <link href="Content/themes/flat/css/style.css" rel="stylesheet">
    <link href="Content/themes/flat/css/style-responsive.css" rel="stylesheet" />
                     
 
                                                 <div class="col-sm-12">
                                                      <section class="panel">
                                                          <header class="panel-heading">
                                                              Brigadas Registradas
                                                          </header>
                                                           
                                                          <asp:GridView ID="GridViewBrigadas" runat="server" AutoGenerateColumns="False" DataKeyNames="bri_codigo" DataSourceID="SqlDataSourceBrigada"  CssClass="table table-striped" AllowPaging="True" GridLines="None">
                                                                  <Columns>
                                                                       <asp:BoundField DataField="bri_codigo" HeaderText="Código" SortExpression="bri_codigo" InsertVisible="False" ReadOnly="True"/>
                                                                      <asp:BoundField DataField="bri_nombre" HeaderText="Nombre" SortExpression="bri_nombre" >
                                                                      </asp:BoundField>
                                                                      <asp:BoundField DataField="bri_grupo" HeaderText="Grupo" SortExpression="bri_grupo" />
                                                                     
                                                                      <asp:BoundField DataField="bri_semestre" HeaderText="Semestre" SortExpression="bri_semestre" />
                                                                      <asp:BoundField DataField="bri_tipo" HeaderText="Tipo" SortExpression="bri_tipo" />
                                                                       <asp:CommandField ShowEditButton="True" />
                                                                       <asp:CommandField ShowSelectButton="true"/>
                                                                  </Columns>
                                                              </asp:GridView> 
                                                          <asp:Button ID="btnNuevaBrigada" runat="server" Text="Crear Nueva Brigada" CssClass="btn btn-shadow btn-primary" OnClick="btnNuevaBrigada_Click" /><br />
                                                              

                                                           

                                                          </section>
                                              </div>
                                          
                                                  <div class="col-sm-6" id="divNuevaBrigada" runat="server">
                                                      <section class="panel">
                                                           <header class="panel-heading">
                                                              Agregar Nueva Brigada
                                                          </header>
                                                          <div class="panel-body">
                                                                 <div class="input-group m-bot15">
                                              <span class="input-group-addon"><i class="icon-group"></i></span>
                                              <input type="text" class="form-control" placeholder="Nombre" id="txt_bri_nombre" runat="server">
                                          </div>
                                                              <div class="input-group m-bot15">
                                              <span class="input-group-addon"><i class="icon-group"></i></span>
                                              <input type="text" class="form-control" placeholder="Grupo" id="txt_bri_grupo" runat="server">
                                          </div>
                                                              <div class="input-group m-bot15">
                                              <span class="input-group-addon"><i class="icon-group"></i></span>
                                              <input type="text" class="form-control" placeholder="Semestre" id="txt_bri_semestre" runat="server">
                                          </div>
                                                              <div class="input-group m-bot15">
                                              <span class="input-group-addon"><i class="icon-group"></i></span>
                                             <select class="form-control m-bot15" id="txt_bri_tipo" runat="server">
                                              <option>PA</option>
                                              <option>SS</option>
                                              <option>PP</option>
                                              <option>PI</option>
                                          </select>
                                          </div>                                                         
        
                                                               <asp:Button ID="btnCrearBrigada" runat="server" Text="Crear Brigada" CssClass="btn btn-shadow btn-primary" OnClick="btnCrearBrigada_Click" />
                                                              <asp:Button ID="btnActualiarBrigada" runat="server" Text="Actualizar Datos" CssClass="btn btn-shadow btn-primary" />

                                                          </div>
                                                      </section>
                                                      <div class="alert alert-success alert-block fade in" id="divSuccess" runat="server">
                                  <button data-dismiss="alert" class="close close-sm" type="button">
                                      <i class="icon-remove"></i>
                                  </button>
                                  <h4>
                                      Brigada
                                      Guardada!
                                  </h4>
                                  <p>La brigada ha sigo guardada correctamente.</p>
                              </div>
                                                      <div class="alert alert-block alert-danger fade in" id="divError" runat="server">
                                  <button data-dismiss="alert" class="close close-sm" type="button">
                                      <i class="icon-remove"></i>
                                  </button>
                                                           <h4>
                                      ¡Error Guardando!
                                  </h4>
                                  <strong>Oh no!</strong> Un error ah ocurrido al guardar la brigada. Verifique que los campos no estén vacios.
                              </div>

                                                  </div>
                 
              <div class="col-sm-6" id="integrantesBrigada" runat="server">
                                                      <section class="panel">
                                                          <header class="panel-heading">
                                                             Integrantes de la Brigada
                                                          </header>
                                                             <asp:GridView ID="GridViewIntegrantesBrigada" runat="server" AutoGenerateColumns="False" DataKeyNames="al_cuenta" DataSourceID="SqlDataSourceIntegrantes"  CssClass="table table-striped" GridLines="None" AllowPaging="True">
                                                                  <Columns>
                                                                      
                                                                      <asp:BoundField DataField="al_cuenta" HeaderText="No. Cuenta" ReadOnly="True" SortExpression="al_cuenta" >
                                                                      </asp:BoundField>
                                                                      <asp:BoundField DataField="bri_codigo" HeaderText="bri_codigo" SortExpression="bri_codigo" />
                                                                      <asp:BoundField DataField="al_nombre" HeaderText="Nombre" SortExpression="al_nombre" />
                                                                      <asp:BoundField DataField="al_grupo" HeaderText="Grupo" SortExpression="al_grupo" />
                                                                      <asp:BoundField DataField="al_telefono" HeaderText="Telefono" SortExpression="al_telefono" />
                                                                      <asp:CommandField ShowEditButton="True" />
                                                                  </Columns>
                                                              </asp:GridView>
                                                           


                                                          <asp:SqlDataSource ID="SqlDataSourceIntegrantes" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [alumno] WHERE ([bri_codigo] = @bri_codigo)">
                                                              <SelectParameters>
                                                                  <asp:ControlParameter ControlID="GridViewBrigadas" Name="bri_codigo" PropertyName="SelectedValue" Type="Int32" />
                                                              </SelectParameters>
                                                              
                                                          </asp:SqlDataSource>

                                                         
                                                          <asp:SqlDataSource ID="SqlDataSourceBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [brigada]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [brigada] WHERE [bri_codigo] = @original_bri_codigo AND [bri_nombre] = @original_bri_nombre AND [bri_grupo] = @original_bri_grupo AND (([bri_semestre] = @original_bri_semestre) OR ([bri_semestre] IS NULL AND @original_bri_semestre IS NULL)) AND (([bri_tipo] = @original_bri_tipo) OR ([bri_tipo] IS NULL AND @original_bri_tipo IS NULL))" InsertCommand="INSERT INTO [brigada] ([bri_nombre], [bri_grupo], [bri_semestre], [bri_tipo]) VALUES (@bri_nombre, @bri_grupo, @bri_semestre, @bri_tipo)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [brigada] SET [bri_nombre] = @bri_nombre, [bri_grupo] = @bri_grupo, [bri_semestre] = @bri_semestre, [bri_tipo] = @bri_tipo WHERE [bri_codigo] = @original_bri_codigo AND [bri_nombre] = @original_bri_nombre AND [bri_grupo] = @original_bri_grupo AND (([bri_semestre] = @original_bri_semestre) OR ([bri_semestre] IS NULL AND @original_bri_semestre IS NULL)) AND (([bri_tipo] = @original_bri_tipo) OR ([bri_tipo] IS NULL AND @original_bri_tipo IS NULL))">
                                                              <DeleteParameters>
                                                                  <asp:Parameter Name="original_bri_codigo" Type="Int32" />
                                                                  <asp:Parameter Name="original_bri_nombre" Type="String" />
                                                                  <asp:Parameter Name="original_bri_grupo" Type="String" />
                                                                  <asp:Parameter Name="original_bri_semestre" Type="Int32" />
                                                                  <asp:Parameter Name="original_bri_tipo" Type="String" />
                                                              </DeleteParameters>
                                                              <InsertParameters>
                                                                  <asp:Parameter Name="bri_nombre" Type="String" />
                                                                  <asp:Parameter Name="bri_grupo" Type="String" />
                                                                  <asp:Parameter Name="bri_semestre" Type="Int32" />
                                                                  <asp:Parameter Name="bri_tipo" Type="String" />
                                                              </InsertParameters>
                                                              <UpdateParameters>
                                                                  <asp:Parameter Name="bri_nombre" Type="String" />
                                                                  <asp:Parameter Name="bri_grupo" Type="String" />
                                                                  <asp:Parameter Name="bri_semestre" Type="Int32" />
                                                                  <asp:Parameter Name="bri_tipo" Type="String" />
                                                                  <asp:Parameter Name="original_bri_codigo" Type="Int32" />
                                                                  <asp:Parameter Name="original_bri_nombre" Type="String" />
                                                                  <asp:Parameter Name="original_bri_grupo" Type="String" />
                                                                  <asp:Parameter Name="original_bri_semestre" Type="Int32" />
                                                                  <asp:Parameter Name="original_bri_tipo" Type="String" />
                                                              </UpdateParameters>
                                                          </asp:SqlDataSource>
                                                          </section>
                                              </div>
                  
              
              <!-- page end-->

     <!--common script for all pages-->
    <script src="Content/themes/flat/js/common-scripts.js"></script>
    <script src="Content/themes/flat/js/tasks.js" type="text/javascript"></script>




    <script>
        jQuery(document).ready(function () {
            TaskList.initTaskWidget();
        });

        $(function () {
            $("#sortable").sortable();
            $("#sortable").disableSelection();
        });

    </script>
          </form>
</asp:Content>
