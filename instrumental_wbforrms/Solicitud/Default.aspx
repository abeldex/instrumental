<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="instrumental_wbforrms.Solititud.Default" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<%@ Register assembly="BasicFrame.WebControls.BasicDatePicker" namespace="BasicFrame.WebControls" tagprefix="BDP" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/themes/login/css/demo.css" rel="stylesheet" />
    <link href="../Content/themes/login/css/style.css" rel="stylesheet" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6/jquery.min.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txtFecha]").datepicker({
                showOn: 'button',
                buttonImageOnly: true,
                buttonImage: 'http://geodesia.uas.edu.mx/img/calendar.png'
            });
        });
        // Traducción al español
        $(function ($) {
            $.datepicker.regional['es'] = {
                closeText: 'Cerrar',
                prevText: '<Ant',
                nextText: 'Sig>',
                currentText: 'Hoy',
                monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
                dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
                dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
                dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
                weekHeader: 'Sm',
                dateFormat: 'dd/mm/yy',
                firstDay: 1,
                isRTL: false,
                showMonthAfterYear: false,
                yearSuffix: ''
            };
            $.datepicker.setDefaults($.datepicker.regional['es']);
        });

    </script>
     <!-- Nav -->
    <nav id="nav" class="skel-panels-fixed">
        <ul>
                        <li ><a id="A1" runat="server" href="~/">Inicio</a></li>
                        <li class="current_page_item"><a id="A2" runat="server" href="~/Solicitud/">SOLICITAR EQUIPOS</a></li>
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

    <script type="text/javascript">
        function printDiv(divID) {
            //Get the HTML of div
            var divElements = document.getElementById(divID).innerHTML;
            //Get the HTML of whole page
            var oldPage = document.body.innerHTML;

            //Reset the page's HTML with div's HTML only
            document.body.innerHTML =
              "<html><head><title></title></head><body>" +
              divElements + "</body>";

            //Print Page
            window.print();

            //Restore orignal HTML
            document.body.innerHTML = oldPage;
        }
</script>

    <style>
    .list {
        color: #555;
        font-size: 22px;
        padding: 0 !important;
        width: 500px;
        font-family: courier, monospace;
        border: 1px solid #dedede;
    }
  .list li 
  {
  list-style: none;
  border-bottom: 1px dotted #ccc;
  text-indent: 25px;
  height: auto;
  padding: 10px;
  text-transform: capitalize;
   }
           
  .list li:hover 
  {
  background-color: #f0f0f0;
  -webkit-transition: all 0.2s;
  -moz-transition:    all 0.2s;
  -ms-transition:     all 0.2s;
  -o-transition:      all 0.2s;
    }

        .auto-style1 {
            text-align: center;
        }

        .auto-style2 {
            width: 43px;
            height: 45px;
        }

        .auto-style3 {
            width: 24px;
            height: 22px;
        }
        .auto-style4 {
            width: 26px;
            height: 28px;
        }
        .auto-style5 {
            width: 25px;
            height: 28px;
        }
        .auto-style6 {
            width: 25px;
            height: 25px;
        }

        </style>
    <!--CUERPO DE LA SOLICITUD EN FORMA DE HOJA DE LIBRETA-->
    <div id="instructions" class="paper">
        <img src="../Content/themes/theme_up/css/images/uas.png" style="position:absolute; left:50px; width:80px;" /><img src="../Content/themes/theme_up/css/images/LOGO%20GEODESIA.png" style="position:absolute; right:20px; width:100px;"/>
        <img src="../Content/themes/theme_up/css/images/TRIPE.png" style="position:absolute; right:20px; width:100px; bottom:20px;"/>
        <!--ENCABEZADO DE LA SOLICITUD-->
        <div style="text-align:center;">
            <h2>UNIVERSIDAD AUTÓNOMA DE SINALOA</h2>
            <h2>FACULTAD DE CIENCIAS DE LA TIERRA Y EL ESPACIO</h2>
            <h3>SOLICITUD DE EQUIPO PARA PRáCTICAS ACADÉMICAS</h3>
        </div>
        <!--/ENCABEZADO DE LA SOLICITUD-->

        <!--DIV DEL FOLIO-->
        <div style="position:absolute; float:left;">
            <h1 style="color:#ff6a00">FOLIO:    <asp:Label ID="lblFolio" runat="server" Text="" Font-Bold="true" Font-Size="Medium"></asp:Label></h1>
        </div>
        <!--/DIV DEL FOLIO-->
&nbsp;<asp:SqlDataSource ID="SqlDataSourceObtenerUltimaSolicitud" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT IDENT_CURRENT('solicitud') AS FOLIO"></asp:SqlDataSource>
        <!--DIV CONTENEDOR DE LOS DROPDOWNLIST-->
        <div style="width:100%;">
            <!-- AQUI EMPIEZA OTRO DIV-->
            <div style="width:100%; text-align:left; ">
                <!-- DIV DEL DATETIMEPICKER (FECHA)-->
                <div style="width:205px; float:left; height:308px; margin-right:15px; padding-right:5px;">
                    <h1>FECHA:
                    <BDP:BDPLite ID="BDPLite1" runat="server" DateFormat="d" Width="150px" CssClass="drop-down-style" />
                    <h1><h1 style="color:#ff6a00;"> 
                    <asp:LinkButton ID="btnTurno" runat="server" OnClick="btnTurno_Click" BorderStyle="Solid" ForeColor="Orange" Height="37px" Width="40px"><img alt="" class="auto-style2" src="../Content/themes/theme_up/css/images/1379011746_schedule.png" /></asp:LinkButton>  
                    
                        TURNO: <asp:DropDownList ID="cmbTurno" runat="server" Font-Bold="True" Font-Size="Large" CssClass="turno" DataSourceID="SqlDataSourceTurno" DataTextField="TURNO" DataValueField="TURNO">
                 </asp:DropDownList></h1>
                    <asp:Label ID="lblFecha" runat="server" Font-Bold="True" Font-Size="Medium" Visible="False"></asp:Label>
                    <br /> 
                        
                 <h1>
                     <img alt="" class="auto-style4" src="../Content/themes/theme_up/css/images/1379011832_analysis.png" />&nbsp;&nbsp;&nbsp; GRUPO: <br /> <asp:DropDownList ID="cmbGrupoBrigada" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceGrupoBrigada" DataTextField="GRUPO" DataValueField="GRUPO" CssClass="drop-down-style"></asp:DropDownList>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                     <img alt="" class="auto-style6" src="../Content/themes/theme_up/css/images/1379011756_tests.png" />&nbsp;&nbsp;&nbsp;
                     BRIGADA:<asp:DropDownList ID="cmbBrigada" runat="server" DataSourceID="SqlDataSourceBrigada" DataTextField="bri_nombre" DataValueField="bri_codigo" OnSelectedIndexChanged="ActualizarNombres" AutoPostBack="True" CssClass="drop-down-style"></asp:DropDownList>
                     <br />
                     <br />
                    </h1> 
                 </div>
                <!-- /DIV DEL DATETIMEPICKER (FECHA)-->
&nbsp;&nbsp;
&nbsp;<asp:RequiredFieldValidator ID="RequiredSalida" runat="server" ControlToValidate="txtHoraSalida" ErrorMessage="Hora de salida es requerido." ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtHoraSalida" ErrorMessage="la hora debe ser en formato hh:mm (ejemplo 06:30)" ForeColor="#FF3300" ValidationExpression="([01]?[0-9]|2[0-3]):[0-5][0-9]">*</asp:RegularExpressionValidator>
&nbsp;<asp:TextBox ID="txtHoraSalida" runat="server" Width="100px" Visible="False"></asp:TextBox>
                    
               
                 &nbsp;&nbsp;&nbsp;<asp:SqlDataSource ID="SqlDataSourceTurno" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_turno" SelectCommandType="StoredProcedure">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="lblFecha" Name="fecha" PropertyName="Text" />
                     </SelectParameters>
                 </asp:SqlDataSource>
              
                <br />
                <!--GRUPO -MAESTRO - PRACTICA - INTEGRANTES BRIGADA -BOTON SELECCIONAR EQUIPOS-->
                <div style="text-align:left;">
                     <asp:SqlDataSource ID="SqlDataSourceGrupoBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT DISTINCT bri_grupo AS GRUPO FROM brigada ORDER BY GRUPO">
                </asp:SqlDataSource>
                    <center><h1>INTEGRANTES DE LA BRIGADA:</h1>
                        <div class="tdiseño">
                   <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceAlumnosPorBrigada" DataKeyNames="CUENTA">
                       <Columns>
                           <asp:BoundField DataField="CUENTA" SortExpression="CUENTA" HeaderText="CUENTA" ReadOnly="True" />
                           <asp:BoundField DataField="INTEGRANTES" HeaderText="NOMBRE" SortExpression="INTEGRANTES" />
                           <asp:BoundField DataField="CELULAR" HeaderText="CELULAR" SortExpression="CELULAR" />
                           <asp:TemplateField FooterText="_____________________________" HeaderText="FIRMAS"></asp:TemplateField>
                       </Columns>
                   </asp:GridView></div>
                    </center>

                    <h1> &nbsp;<br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <img alt="" class="auto-style5" src="../Content/themes/theme_up/css/images/1379011605_library.png" />&nbsp;&nbsp;&nbsp;
                        PROFESOR:&nbsp;</h1>
                     <asp:DropDownList ID="cmbMaestros" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceMAestros" DataTextField="profesor_nombre" DataValueField="profesor_codigo" Width="300px" CssClass="drop-down-style">
                 </asp:DropDownList>
                 <asp:SqlDataSource ID="SqlDataSourceMAestros" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [profesor]">
                 </asp:SqlDataSource>
                <br />
                 <h1>
                     <img alt="" class="auto-style4" src="../Content/themes/theme_up/css/images/1379011810_glossary.png" />&nbsp;&nbsp;&nbsp; NOMBRE DE LA PRÁCTICA : </h1>
                     <asp:DropDownList ID="cmbPractica" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourcePracticas" DataTextField="PRACTICA" DataValueField="practica_codigo" CssClass="drop-down-style">
                 </asp:DropDownList>
                     <br />
                        <asp:Button ID="btnSeleccionarEquipos" runat="server" Text="Elegir Equipos" Width="180px" OnClick="btnSeleccionarEquipos_Click" CssClass="button" />
                 <asp:SqlDataSource ID="SqlDataSourcePracticas" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_practica_profesor" SelectCommandType="StoredProcedure">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="cmbMaestros" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
                     </SelectParameters>
                 </asp:SqlDataSource>
                 <br />
                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" /><br />

                    </div>
                <!--/GRUPO -MAESTRO - PRACTICA - INTEGRANTES BRIGADA -BOTON SELECCIONAR EQUIPOS--> 
                
                  <!-- DIV DE SELECCION DE EQUIPOS-->
            <!--/DIV DE SELECCION DE EQUIPOS-->        
                </div>
            <!-- AQUI TERMINA OTRO DIV-->

            <!--DIV DEL TURNO-->
            <div style="width:100%; border-bottom:solid; border-bottom-color:#f0f0f0;" class="auto-style1" runat="server" id="DivDatos"> 
                
            </div>
            <!--/DIV DEL TURNO-->

                      
            </div>
        <!--/DIV CONTENEDOR DE LOS DROPDOWNLIST-->
            <div style="width:100%; border-bottom:solid; border-bottom-color:#f0f0f0; float:left;" class="auto-style1" runat="server" id="DivEquipos"><center><h1>
                <br />
                ELEGIR EQUIPOS <img alt="" class="auto-style3" src="../Content/themes/theme_up/css/images/1379011769_options.png" /></h1> </center>
                &nbsp;<asp:DropDownList ID="cmbSolicitudNumero" runat="server" DataSourceID="SqlDataSourceObtenerUltimaSolicitud" DataTextField="FOLIO" DataValueField="FOLIO" Visible="False" CssClass="drop-down-style"></asp:DropDownList>
                &nbsp; Equipo:
                <asp:DropDownList ID="cmbEquipos" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceEquiposPorPractica" DataTextField="EQUIPO" DataValueField="CODIGO" CssClass="drop-down-style"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceEquiposPorPractica" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_equipos_por_practica" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="cmbPractica" Name="practica" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                &nbsp;&nbsp;
                Cantidad:<asp:RequiredFieldValidator ID="RequiredCantidad" runat="server" ControlToValidate="txtCantidad" ErrorMessage="Debe agregar una cantidad" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtCantidad" runat="server" Width="50px"></asp:TextBox>
                &nbsp;&nbsp;<asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="100px" OnClick="btnAgregar_Click1" />
                &nbsp;
                <br />
                <br />
                <div style="width:100%; text-align:center;">
                <h1>Equipos SOLICITADOS:
                    <img alt="" class="auto-style4" src="../Content/themes/theme_up/css/images/1379011776_paste.png" /></h1> 
                                                                                                        
                    <div style="width:100%">
                    </div>
                    <div style="width:100%">
                        <center>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDetalleSolicitud" Width="100%">
                    <Columns>
                        <asp:BoundField DataField="SERIE" HeaderText="SERIE" SortExpression="SERIE" />
                        <asp:BoundField DataField="NOMBRE" SortExpression="NOMBRE" HeaderText="NOMBRE" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SOLCITADO" SortExpression="SOLCITADO" HeaderText="SOLCITADO" >
                        </asp:BoundField>
                    </Columns>
                </asp:GridView></center></div>
                    <center><H1>
            <br />
            <br />

            ___________________________________________________________________________<br />
            NOMBRE Y FIRMA DE CONFORMIDAD DE RECEPCIÓN DE EQUIPO</H1><br />
            <asp:Button ID="Button1" runat="server" Text="Enviar Solicitud e Imprimir" OnClientClick="javascript:printDiv('instructions')" OnClick="Button1_Click"/>
        </center>

                </div>
                <asp:SqlDataSource ID="SqlDataSourceDetalleSolicitud" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="obtener_detalle_solicitud" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="cmbSolicitudNumero" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
&nbsp;
            </div>
        <asp:SqlDataSource ID="SqlDataSourceBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT * FROM [brigada] WHERE ([bri_grupo] = @bri_grupo)">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbGrupoBrigada" Name="bri_grupo" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
                    
                    <asp:SqlDataSource ID="SqlDataSourceAlumnosPorBrigada" runat="server" ConnectionString="<%$ ConnectionStrings:InstrumentalConnectionString %>" SelectCommand="SELECT al_cuenta as CUENTA, al_nombre AS INTEGRANTES, al_telefono as CELULAR FROM alumno WHERE (bri_codigo = @bri_codigo)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="cmbBrigada" Name="bri_codigo" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
        
        <img src="../Content/themes/theme_up/css/images/consolidacion.png" />
    </div>
    <!--/CUERPO DE LA SOLICITUD EN FORMA DE HOJA DE LIBRETA-->
</asp:Content>
