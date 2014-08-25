<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iniciar_sesion.aspx.cs" Inherits="instrumental_wbforrms.iniciar_sesion" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <link rel="shortcut icon" href="img/favicon.png">

    <title>Sistema de Instrumental Geodésico / Inicio de Sesion</title>

    <!-- Bootstrap core CSS -->
    <link href="Content/themes/flat/css/bootstrap.min.css" rel="stylesheet">
    <link href="Content/themes/flat/css/bootstrap-reset.css" rel="stylesheet">
    <!--external css-->
    <link href="Content/themes/flat/Content/themes/flat/assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <!-- Custom styles for this template -->
    <link href="Content/themes/flat/css/style.css" rel="stylesheet">
    <link href="Content/themes/flat/css/style-responsive.css" rel="stylesheet" />

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 tooltipss and media queries -->
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
        .auto-style1 {
            width: 340px;
            height: 64px;
            margin-bottom:-10px;
        }
    </style>
</head>
    
<body class="lock-screen" onload="startTime()">
    <div id="time"></div> <CENTER><h2 style="font-family:'Swis721 Cn BT'; font-weight:bold; color:#808080;">UNIVERSIDAD AUTONÓMA DE SINALOA<br />Facultad de Ciencias de la Tierra y el Espacio</h2></CENTER>   <div class="lock-wrapper">
        
        <div class="lock-box text-center">
            <form id="Form1" runat="server" class="form-inline"><img class="auto-style1" src="Content/themes/AdminTemplate/img/Notebook.png" />
            <asp:Login ID="Login1" runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
            <LayoutTemplate>   
                <fieldset>
                    <h2 style="color:#fff; text-shadow: 3px 3px 3px #808080;">Acceso a Miembros</h2>
                    <div class="login-fields">
                        	        <span style="color:#fff; text-shadow: 3px 3px 3px #808080;">Usuario:</span><div class="field">
					                    
                                        <asp:TextBox runat="server" ID="UserName" CssClass="form-control lock-input" ToolTip="Usuario" Width="100%" ></asp:TextBox>
					                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="El campo de nombre de usuario es obligatorio." ></asp:RequiredFieldValidator>       
				        </div> <!-- /field -->
                        <span style="color:#fff; text-shadow: 3px 3px 3px #808080;"> Contraseña:</span><div class="field">
					       
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control lock-input" ToolTip="Contraseña" Width="100%" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="El campo de contraseña es obligatorio." ></asp:RequiredFieldValidator>
					    </div> <!-- /password -->
                    </div><!-- /login-fields -->
                            <div class="login-actions">
				<asp:Button ID="Button1" runat="server" CommandName="Login" Text="Iniciar sesión" CssClass="btn btn-send" Width="100%"/>
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-lock" Width="100%" NavigateUrl="~/Account/Register.aspx">Registrarse</asp:HyperLink>
				<span class="login-checkbox">
                    <asp:CheckBox runat="server" ID="RememberMe"/>
					<asp:Label ID="Label1" runat="server" AssociatedControlID="RememberMe">¿Recordar cuenta?</asp:Label>
				</span>
                               
			</div> <!-- .actions --> 		        
                </fieldset>   
            </LayoutTemplate>
        </asp:Login>
                 </form>
            <center><img src="Content/themes/AdminTemplate/img/logo%20(2).png" /><img src="Content/themes/AdminTemplate/img/logouasderecha.png" /><br />
                
            </center>
           
        </div>
    </div>
    <script>
        function startTime() {
            var today = new Date();
            var h = today.getHours();
            var m = today.getMinutes();
            var s = today.getSeconds();
            // add a zero in front of numbers<10
            m = checkTime(m);
            s = checkTime(s);
            document.getElementById('time').innerHTML = h + ":" + m + ":" + s;
            t = setTimeout(function () { startTime() }, 500);
        }

        function checkTime(i) {
            if (i < 10) {
                i = "0" + i;
            }
            return i;
        }
    </script>
</body>
       
</html>